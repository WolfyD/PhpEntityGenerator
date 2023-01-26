using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PhpEntityGenerator
{
    public partial class Form1 : Form
    {
        #region Variables

        string FieldTemplate;
        string GetterTemplate;
        string SetterTemplate;

        string ClassName = "";
        string Namespace = "";
        string Extends = "";

        string defaultNamespace = "Dzeta\\Forms\\Entity";
        string defaultClassName = "CLASS_NAME";
        string defaultExtends = "Form";

        List<Field> Fields = new List<Field>();
        StringBuilder sb = new StringBuilder();
        string Output = "";
        Dictionary<FieldType, int> TypeCounter = new Dictionary<FieldType, int>();
        Thread generatorThread;

        #endregion

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            SetupTypeCounter();

            tb_Input.ClearUndo();
            tb_Output.ClearUndo();
        }

        private void SetupTypeCounter()
        {
            TypeCounter.Clear();

            foreach (FieldType type in Enum.GetValues(typeof(FieldType)))
            {
                TypeCounter.Add(type, 0);
            }
        }

        private void ShowSettings()
        {
            Options opt = new Options();
            opt.ShowDialog();
            if (opt.OK)
            {
                LoadSettings();
            }
        }

        public void LoadSettings()
        {
            tb_Input.ForeColor = tb_Output.ForeColor = Properties.Settings.Default.s_FGC;
            tb_Input.BackColor = tb_Output.BackColor = Properties.Settings.Default.s_BGC;
            tb_Input.Font = tb_Output.Font = Properties.Settings.Default.s_Font;

            FieldTemplate = Properties.Settings.Default.s_FieldTemplate;
            GetterTemplate = Properties.Settings.Default.s_GetterTemplate;
            SetterTemplate = Properties.Settings.Default.s_SetterTemplate;
        }

        private string Templater(Field f, string template)
        {
            template = template.Replace("{col_def}", f.GenerateColumnDefinition());
            template = template
                .Replace("{name}", f.Name)
                .Replace("{field_name}", GetNextFieldName(f.Type))
                .Replace("{proper_name}", f.ProperName)
                .Replace("{type}", f.Type.ToString().ToLower())
                .Replace("{length}", f.Length.ToString())
                .Replace("{precision}", f.Length.ToString())
                .Replace("{scale}", f.Scale.ToString())
                .Replace("{nullable}", f.Nullable ? "true" : "false");

            Invoke(new ManageProgressBar(IncrementProgressBar));

            return template;
        }

        private string GetNextFieldName(FieldType type)
        {
            if (TypeCounter.TryGetValue(type, out int val))
            {
                val++;
                TypeCounter[type] = val;
                return $"{type.ToString().ToLower()}_{val}";
            }
            return "";
        }

        private void CopyOutput()
        {
            Clipboard.SetText(tb_Output.Text);
        }

        private string GeneratePhpFile()
        {
            generatorThread = new Thread(new ThreadStart(GenerateOutput));
            generatorThread.Start();

            string phptemplate = @"<?php

{namespace}

/**
 * @Entity
 */
{class_name} {extends}
{

{output}

}

// - EOF

";

            if (Namespace != "") { phptemplate = phptemplate.Replace("{namespace}", "namespace " + Namespace.Trim() + ";\r\n"); }
            else { phptemplate = phptemplate.Replace("{namespace}", "namespace " + defaultNamespace); }

            if (ClassName != "")
            {
                phptemplate = phptemplate.Replace("{class_name}", "\r\nclass " + ClassName.Trim());
                if (Extends != "")
                {
                    phptemplate = phptemplate.Replace("{extends}", " extends " + Extends.Trim());
                }
            }
            else
            {
                phptemplate = phptemplate.Replace("{class_name}", "class " + defaultClassName);
                phptemplate = phptemplate.Replace("{extends}", " extends " + defaultExtends);
            }

            phptemplate = phptemplate.Replace("{output}", Output);

            return phptemplate;
        }

        private void SaveAsPhp()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Select file to output your PHP",
                ShowHelp = true,
                OverwritePrompt = true,
                Filter = "PHP Files|*.php,*.phtml|Text Files|*.txt|All Files|*.*",
                FileName = "entity.php",
                CreatePrompt = false,
                AutoUpgradeEnabled = true,
                AddExtension = true,
                SupportMultiDottedExtensions = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Create(sfd.FileName).Close();
                File.WriteAllText(sfd.FileName, GeneratePhpFile());
            }
        }

        private Field ParseLine(string line)
        {
            Invoke(new ManageProgressBar(IncrementProgressBar));

            if (line.StartsWith("#NAMESPACE:")) { Namespace = line.Replace("#NAMESPACE:", ""); return null; }
            if (line.StartsWith("#CLASS:")) { ClassName = line.Replace("#CLASS:", ""); return null; }
            if (line.StartsWith("#EXTENDS:")) { Extends = line.Replace("#EXTENDS:", ""); return null; }

            if (line.StartsWith("#") || line.Trim() == string.Empty) { return null; }

            string[] trueTypes = { "true", "t", "1" };

            string[] parts = line.Split(':');
            string name = parts[0];
            string type = "";
            string length = "";
            string scale = "";
            int len = 0;
            int sca = 0;
            bool nullable = true;

            for (int i = 0; i < parts.Length; i++)
            {
                switch (i)
                {
                    case 0: name = parts[i]; break;
                    case 1: type = parts[i]; break;
                    case 2: length = parts[i]; break;
                    case 3: scale = parts[i]; break;
                    case 4: nullable = trueTypes.Contains(parts[i].ToLower()); break;
                }
            }

            if (!int.TryParse(length, out len)) { len = 255; };
            if (!int.TryParse(scale, out sca)) { sca = 3; }

            return new Field(name, Field.GetTypeFromString(type), len, sca, nullable);
        }

        private void GenerateOutput()
        {
            Invoke(new ManageControls(LockControls));
            Invoke(new ManageProgressBar(ResetProgressBar));
            Invoke(new ManageProgressBarMax(SetProgressBarMax), tb_Input.Lines.Length);

            SetupTypeCounter();
            sb.Clear();
            Fields.Clear();
            Output = "";

            foreach (string s in tb_Input.Lines)
            {
                Field f = ParseLine(s);
                if (f != null)
                {
                    Fields.Add(f);
                }
            }

            Invoke(new ManageProgressBar(ResetProgressBar));
            Invoke(new ManageProgressBarMax(SetProgressBarMax), 3 * Fields.Count());

            foreach (Field field in Fields)
            {
                sb.Append(Templater(field, FieldTemplate));
            }

            sb.Append("\r\n\r\n\t// ========================== Getters and Setters ==========================\r\n\r\n");

            foreach (Field field in Fields)
            {
                sb.Append(Templater(field, GetterTemplate));
                sb.Append(Templater(field, SetterTemplate));
            }

            Output = sb.ToString();

            Invoke(new ManageProgressBar(HideProgressBar));

            Invoke(new ManageOutputBox(SetOutputContent), Output);
            Invoke(new ManageControls(OpenControls));
        }

        #region Invoke Stuff

        public delegate void ManageControls();
        public delegate void ManageProgressBar();
        public delegate void ManageOutputBox(string text);
        public delegate void ManageProgressBarMax(int max);

        private void ResetProgressBar()
        {
            pb_Progress.Value = 0;
            pb_Progress.Show();
        }

        private void HideProgressBar()
        {
            pb_Progress.Hide();
        }

        private void IncrementProgressBar()
        {
            try { pb_Progress.Value++; } catch { }
        }

        private void SetProgressBarMax(int max)
        {
            pb_Progress.Maximum = max;
        }

        private void SetOutputContent(string text)
        {
            tb_Output.Text = text;
        }

        private void LockControls()
        {
            btn_Generate.Enabled = false;
            btn_SaveAsFile.Enabled = false;
            btn_Settings.Enabled = false;
            btn_Exit.Enabled = false;
            tb_Input.Enabled = false;
        }

        private void OpenControls()
        {
            btn_Generate.Enabled = true;
            btn_SaveAsFile.Enabled = true;
            btn_Settings.Enabled = true;
            btn_Exit.Enabled = true;
            tb_Input.Enabled = true;
        }

        #endregion

        #region Buttons

        private void btn_SaveAsFile_Click(object sender, EventArgs e)
        {
            SaveAsPhp();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            CopyOutput();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            generatorThread = new Thread(new ThreadStart(GenerateOutput));
            generatorThread.Start();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        #endregion

        #region Menu Items

        private void btn_Output_Clear_Click(object sender, EventArgs e)
        {
            Output = "";
            SetupTypeCounter();
            sb.Clear();
            Fields.Clear();
            tb_Output.Clear();
        }

        private void btn_Input_InsertClass_Click(object sender, EventArgs e)
        {
            tb_Input.Text = @"#NAMESPACE:
#CLASS:
#EXTENDS:
" + tb_Input.Text;
        }

        private void btn_Input_InsertExample_Click(object sender, EventArgs e)
        {
            tb_Input.Text += @"

# Lines starting with '#' are comments and discounted
# Except for lines starting with '#NAMESPACE:', '#CLASS:' or '#EXTENDS:'
# These three set some template lines for the PHP file output
# 'Namespace' sets the namespace line and defaults to '" + defaultNamespace + @"'
# 'Class' sets the class name and defaults to '" + defaultClassName + @"'
# and 'Extends' sets the inherited class, and defaults to '" + defaultExtends + @"'

# The layout of a field is as follows:
# Field name:Type:Length:Precision:Nullable

# Type can be:
# string
# text
# varChar
# char
# boolean
# integer
# double
# float
# decimal
# date
# timeStamp
# enum
# set

# If no type is set, it defaults to string

# Length is an integer that defines the length of a string or number
# If not set length defaults to 255

# Precision is an integer that defines how many numbers after the decimal point should be used
# It is useful in values of type double, float and decimal
# If not set precision defaults to 3

# Nullable defines if a value can be null.
# It is true when the value is 'true', 't' or '1'
# By default, when not set, nullable is true

# Examples:
example_string:string:60
example_boolean:boolean
example_integer:integer:13:0:false
example_double:double:11:5:true
example_float:float:30
example_date:date
example_string_number_two

";
        }

        private void btn_Input_Copy_Click(object sender, EventArgs e)
        {
            if (tb_Input.SelectedText == "") { Clipboard.SetText(tb_Input.Text); }
            else { Clipboard.SetText(tb_Input.SelectedText); }
        }

        private void btn_Input_Paste_Click(object sender, EventArgs e)
        {
            tb_Input.Paste();
        }

        private void btn_Input_Clear_Click(object sender, EventArgs e)
        {
            tb_Input.Clear();
        }

        private void btn_Output_SaveFile_Click(object sender, EventArgs e)
        {
            SaveAsPhp();
        }

        private void btn_Output_Copy_Click(object sender, EventArgs e)
        {
            CopyOutput();
        }

        #endregion
    }
}

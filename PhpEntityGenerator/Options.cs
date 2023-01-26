using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhpEntityGenerator
{
    public partial class Options : Form
    {
        public bool OK { get; set; }
        private int padding = 13;

        public Options()
        {
            InitializeComponent();
            Load += Options_Load;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            StyleSetup();
            TemplatesSetup();
            ResizeFields();
        }

        public void StyleSetup()
        {
            tb_Font.Font = Properties.Settings.Default.s_Font;
            setFontText();
            p_BGC.BackColor = Properties.Settings.Default.s_BGC;
            p_FGC.BackColor = Properties.Settings.Default.s_FGC;
        }

        public void TemplatesSetup()
        {
            tb_FieldTemplate.Text = Properties.Settings.Default.s_FieldTemplate;
            tb_GetterTemplate.Text = Properties.Settings.Default.s_GetterTemplate;
            tb_SetterTemplate.Text = Properties.Settings.Default.s_SetterTemplate;
        }

        private void setFontText()
        {
            tb_Font.Text = $"{tb_Font.Font.Name} | {tb_Font.Font.Size} | {tb_Font.Font.Style}";
        }

        private void Save()
        {
            Properties.Settings.Default.s_FieldTemplate = tb_FieldTemplate.Text;
            Properties.Settings.Default.s_GetterTemplate = tb_GetterTemplate.Text;
            Properties.Settings.Default.s_SetterTemplate = tb_SetterTemplate.Text;

            Properties.Settings.Default.s_Font = tb_Font.Font;
            Properties.Settings.Default.s_BGC = p_BGC.BackColor;
            Properties.Settings.Default.s_FGC = p_FGC.BackColor;

            Properties.Settings.Default.Save();
            OK = true;
            this.Close();
        }

        private void Cancel()
        {
            OK = false;
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void p_BGC_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = p_BGC.BackColor;
            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            cd.ShowHelp = true;

            if(cd.ShowDialog() == DialogResult.OK)
            {
                p_BGC.BackColor = cd.Color;
            }
        }

        private void p_FGC_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = p_FGC.BackColor;
            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            cd.ShowHelp = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                p_FGC.BackColor = cd.Color;
            }
        }

        private void tb_Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = tb_Font.Font;
            fd.FontMustExist = true;
            fd.AllowScriptChange = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                tb_Font.Font = fd.Font;
            }
        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {
            ResizeFields();
        }

        private void ResizeFields()
        {
            int tbHeight = (groupBox2.Height - (4 * padding)) / 3;

            tb_FieldTemplate.Top = padding;
            tb_FieldTemplate.Height = tbHeight;
            lbl_Field.Top = tb_FieldTemplate.Top + padding;

            tb_GetterTemplate.Top = (2 * padding) + tbHeight;
            tb_GetterTemplate.Height = tbHeight;
            lbl_Getter.Top = tb_GetterTemplate.Top + padding;

            tb_SetterTemplate.Top = (3 * padding) + (2 * tbHeight);
            tb_SetterTemplate.Height = tbHeight;
            lbl_Setter.Top = tb_SetterTemplate.Top + padding;
        }
    }
}

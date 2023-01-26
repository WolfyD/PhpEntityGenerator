namespace PhpEntityGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.btn_SaveAsFile = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.cms_Input = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Input_InsertClass = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Input_InsertExample = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Input_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Input_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Input_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.cms_Output = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Output_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Output_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Output_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cms_Input.SuspendLayout();
            this.cms_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_Progress);
            this.panel1.Controls.Add(this.btn_SaveAsFile);
            this.panel1.Controls.Add(this.btn_Copy);
            this.panel1.Controls.Add(this.btn_Generate);
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 73);
            this.panel1.TabIndex = 0;
            // 
            // pb_Progress
            // 
            this.pb_Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_Progress.Location = new System.Drawing.Point(0, 63);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(809, 10);
            this.pb_Progress.TabIndex = 7;
            this.pb_Progress.Visible = false;
            // 
            // btn_SaveAsFile
            // 
            this.btn_SaveAsFile.Location = new System.Drawing.Point(411, 24);
            this.btn_SaveAsFile.Name = "btn_SaveAsFile";
            this.btn_SaveAsFile.Size = new System.Drawing.Size(118, 34);
            this.btn_SaveAsFile.TabIndex = 6;
            this.btn_SaveAsFile.Text = "Save Output as PHP";
            this.btn_SaveAsFile.UseVisualStyleBackColor = true;
            this.btn_SaveAsFile.Click += new System.EventHandler(this.btn_SaveAsFile_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(287, 24);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(118, 34);
            this.btn_Copy.TabIndex = 5;
            this.btn_Copy.Text = "Copy Output";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(163, 24);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(118, 34);
            this.btn_Generate.TabIndex = 4;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(12, 24);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(118, 34);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(679, 24);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(118, 34);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_Output);
            this.splitContainer1.Size = new System.Drawing.Size(809, 260);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tb_Input
            // 
            this.tb_Input.ContextMenuStrip = this.cms_Input;
            this.tb_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Input.Location = new System.Drawing.Point(0, 0);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Input.MaxLength = 999999999;
            this.tb_Input.Multiline = true;
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Input.Size = new System.Drawing.Size(365, 260);
            this.tb_Input.TabIndex = 0;
            // 
            // cms_Input
            // 
            this.cms_Input.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Input_InsertClass,
            this.btn_Input_InsertExample,
            this.toolStripSeparator2,
            this.btn_Input_Copy,
            this.btn_Input_Paste,
            this.toolStripSeparator3,
            this.btn_Input_Clear});
            this.cms_Input.Name = "cms_Input";
            this.cms_Input.Size = new System.Drawing.Size(190, 126);
            // 
            // btn_Input_InsertClass
            // 
            this.btn_Input_InsertClass.Name = "btn_Input_InsertClass";
            this.btn_Input_InsertClass.Size = new System.Drawing.Size(189, 22);
            this.btn_Input_InsertClass.Text = "Insert Class properties";
            this.btn_Input_InsertClass.Click += new System.EventHandler(this.btn_Input_InsertClass_Click);
            // 
            // btn_Input_InsertExample
            // 
            this.btn_Input_InsertExample.Name = "btn_Input_InsertExample";
            this.btn_Input_InsertExample.Size = new System.Drawing.Size(189, 22);
            this.btn_Input_InsertExample.Text = "Insert Example line";
            this.btn_Input_InsertExample.Click += new System.EventHandler(this.btn_Input_InsertExample_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // btn_Input_Copy
            // 
            this.btn_Input_Copy.Name = "btn_Input_Copy";
            this.btn_Input_Copy.Size = new System.Drawing.Size(189, 22);
            this.btn_Input_Copy.Text = "Copy";
            this.btn_Input_Copy.Click += new System.EventHandler(this.btn_Input_Copy_Click);
            // 
            // btn_Input_Paste
            // 
            this.btn_Input_Paste.Name = "btn_Input_Paste";
            this.btn_Input_Paste.Size = new System.Drawing.Size(189, 22);
            this.btn_Input_Paste.Text = "Paste";
            this.btn_Input_Paste.Click += new System.EventHandler(this.btn_Input_Paste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // btn_Input_Clear
            // 
            this.btn_Input_Clear.Name = "btn_Input_Clear";
            this.btn_Input_Clear.Size = new System.Drawing.Size(189, 22);
            this.btn_Input_Clear.Text = "Clear";
            this.btn_Input_Clear.Click += new System.EventHandler(this.btn_Input_Clear_Click);
            // 
            // tb_Output
            // 
            this.tb_Output.ContextMenuStrip = this.cms_Output;
            this.tb_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Output.Location = new System.Drawing.Point(0, 0);
            this.tb_Output.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Output.Multiline = true;
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Output.Size = new System.Drawing.Size(438, 260);
            this.tb_Output.TabIndex = 1;
            // 
            // cms_Output
            // 
            this.cms_Output.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Output_Copy,
            this.btn_Output_SaveFile,
            this.toolStripSeparator6,
            this.btn_Output_Clear});
            this.cms_Output.Name = "cms_Input";
            this.cms_Output.Size = new System.Drawing.Size(154, 76);
            // 
            // btn_Output_Copy
            // 
            this.btn_Output_Copy.Name = "btn_Output_Copy";
            this.btn_Output_Copy.Size = new System.Drawing.Size(153, 22);
            this.btn_Output_Copy.Text = "Copy Contents";
            this.btn_Output_Copy.Click += new System.EventHandler(this.btn_Output_Copy_Click);
            // 
            // btn_Output_SaveFile
            // 
            this.btn_Output_SaveFile.Name = "btn_Output_SaveFile";
            this.btn_Output_SaveFile.Size = new System.Drawing.Size(153, 22);
            this.btn_Output_SaveFile.Text = "Save File";
            this.btn_Output_SaveFile.Click += new System.EventHandler(this.btn_Output_SaveFile_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(150, 6);
            // 
            // btn_Output_Clear
            // 
            this.btn_Output_Clear.Name = "btn_Output_Clear";
            this.btn_Output_Clear.Size = new System.Drawing.Size(153, 22);
            this.btn_Output_Clear.Text = "Clear";
            this.btn_Output_Clear.Click += new System.EventHandler(this.btn_Output_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 333);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(705, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP Entity Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cms_Input.ResumeLayout(false);
            this.cms_Output.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveAsFile;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.ContextMenuStrip cms_Input;
        private System.Windows.Forms.ToolStripMenuItem btn_Input_InsertClass;
        private System.Windows.Forms.ToolStripMenuItem btn_Input_InsertExample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn_Input_Copy;
        private System.Windows.Forms.ToolStripMenuItem btn_Input_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn_Input_Clear;
        private System.Windows.Forms.ContextMenuStrip cms_Output;
        private System.Windows.Forms.ToolStripMenuItem btn_Output_Copy;
        private System.Windows.Forms.ToolStripMenuItem btn_Output_SaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btn_Output_Clear;
    }
}


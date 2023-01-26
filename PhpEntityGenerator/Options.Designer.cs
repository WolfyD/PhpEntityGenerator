namespace PhpEntityGenerator
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_FGC = new System.Windows.Forms.Panel();
            this.p_BGC = new System.Windows.Forms.Panel();
            this.tb_Font = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_SetterTemplate = new System.Windows.Forms.TextBox();
            this.tb_GetterTemplate = new System.Windows.Forms.TextBox();
            this.tb_FieldTemplate = new System.Windows.Forms.TextBox();
            this.lbl_Setter = new System.Windows.Forms.Label();
            this.lbl_Getter = new System.Windows.Forms.Label();
            this.lbl_Field = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.p_FGC);
            this.groupBox1.Controls.Add(this.p_BGC);
            this.groupBox1.Controls.Add(this.tb_Font);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style";
            // 
            // p_FGC
            // 
            this.p_FGC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_FGC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_FGC.Location = new System.Drawing.Point(154, 103);
            this.p_FGC.Name = "p_FGC";
            this.p_FGC.Size = new System.Drawing.Size(30, 30);
            this.p_FGC.TabIndex = 5;
            this.p_FGC.Click += new System.EventHandler(this.p_FGC_Click);
            // 
            // p_BGC
            // 
            this.p_BGC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_BGC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_BGC.Location = new System.Drawing.Point(154, 61);
            this.p_BGC.Name = "p_BGC";
            this.p_BGC.Size = new System.Drawing.Size(30, 30);
            this.p_BGC.TabIndex = 4;
            this.p_BGC.Click += new System.EventHandler(this.p_BGC_Click);
            // 
            // tb_Font
            // 
            this.tb_Font.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_Font.Location = new System.Drawing.Point(154, 24);
            this.tb_Font.Name = "tb_Font";
            this.tb_Font.Size = new System.Drawing.Size(550, 20);
            this.tb_Font.TabIndex = 3;
            this.tb_Font.Click += new System.EventHandler(this.tb_Font_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Foreground";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tb_SetterTemplate);
            this.groupBox2.Controls.Add(this.tb_GetterTemplate);
            this.groupBox2.Controls.Add(this.tb_FieldTemplate);
            this.groupBox2.Controls.Add(this.lbl_Setter);
            this.groupBox2.Controls.Add(this.lbl_Getter);
            this.groupBox2.Controls.Add(this.lbl_Field);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Content Generator";
            this.groupBox2.Resize += new System.EventHandler(this.groupBox2_Resize);
            // 
            // tb_SetterTemplate
            // 
            this.tb_SetterTemplate.AcceptsReturn = true;
            this.tb_SetterTemplate.AcceptsTab = true;
            this.tb_SetterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SetterTemplate.Location = new System.Drawing.Point(154, 209);
            this.tb_SetterTemplate.Multiline = true;
            this.tb_SetterTemplate.Name = "tb_SetterTemplate";
            this.tb_SetterTemplate.Size = new System.Drawing.Size(550, 78);
            this.tb_SetterTemplate.TabIndex = 5;
            // 
            // tb_GetterTemplate
            // 
            this.tb_GetterTemplate.AcceptsReturn = true;
            this.tb_GetterTemplate.AcceptsTab = true;
            this.tb_GetterTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_GetterTemplate.Location = new System.Drawing.Point(154, 121);
            this.tb_GetterTemplate.Multiline = true;
            this.tb_GetterTemplate.Name = "tb_GetterTemplate";
            this.tb_GetterTemplate.Size = new System.Drawing.Size(550, 78);
            this.tb_GetterTemplate.TabIndex = 4;
            // 
            // tb_FieldTemplate
            // 
            this.tb_FieldTemplate.AcceptsReturn = true;
            this.tb_FieldTemplate.AcceptsTab = true;
            this.tb_FieldTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_FieldTemplate.Location = new System.Drawing.Point(154, 29);
            this.tb_FieldTemplate.Multiline = true;
            this.tb_FieldTemplate.Name = "tb_FieldTemplate";
            this.tb_FieldTemplate.Size = new System.Drawing.Size(550, 78);
            this.tb_FieldTemplate.TabIndex = 3;
            // 
            // lbl_Setter
            // 
            this.lbl_Setter.AutoSize = true;
            this.lbl_Setter.Location = new System.Drawing.Point(21, 212);
            this.lbl_Setter.Name = "lbl_Setter";
            this.lbl_Setter.Size = new System.Drawing.Size(35, 13);
            this.lbl_Setter.TabIndex = 2;
            this.lbl_Setter.Text = "Setter";
            // 
            // lbl_Getter
            // 
            this.lbl_Getter.AutoSize = true;
            this.lbl_Getter.Location = new System.Drawing.Point(21, 124);
            this.lbl_Getter.Name = "lbl_Getter";
            this.lbl_Getter.Size = new System.Drawing.Size(36, 13);
            this.lbl_Getter.TabIndex = 1;
            this.lbl_Getter.Text = "Getter";
            // 
            // lbl_Field
            // 
            this.lbl_Field.AutoSize = true;
            this.lbl_Field.Location = new System.Drawing.Point(21, 36);
            this.lbl_Field.Name = "lbl_Field";
            this.lbl_Field.Size = new System.Drawing.Size(29, 13);
            this.lbl_Field.TabIndex = 0;
            this.lbl_Field.Text = "Field";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(647, 491);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(92, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save && Close";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.Location = new System.Drawing.Point(12, 491);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(751, 526);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel p_FGC;
        private System.Windows.Forms.Panel p_BGC;
        private System.Windows.Forms.TextBox tb_Font;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Setter;
        private System.Windows.Forms.Label lbl_Getter;
        private System.Windows.Forms.Label lbl_Field;
        private System.Windows.Forms.TextBox tb_SetterTemplate;
        private System.Windows.Forms.TextBox tb_GetterTemplate;
        private System.Windows.Forms.TextBox tb_FieldTemplate;
    }
}
namespace AdvancedConnectPlugin.GUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxFieldMappings = new System.Windows.Forms.GroupBox();
            this.textBoxRDPHeight = new System.Windows.Forms.TextBox();
            this.textBoxRDPWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEnableRDPFullScreen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRDPInfo = new System.Windows.Forms.Label();
            this.checkBoxEnableBuiltinRDP = new System.Windows.Forms.CheckBox();
            this.labelEnableBuiltinRDP = new System.Windows.Forms.Label();
            this.labelMainSeparator1 = new System.Windows.Forms.Label();
            this.comboBoxConnectionMethod = new System.Windows.Forms.ComboBox();
            this.labelConnectionMethod = new System.Windows.Forms.Label();
            this.tabPageApplications = new System.Windows.Forms.TabPage();
            this.groupBoxApplications = new System.Windows.Forms.GroupBox();
            this.buttonApplicationRemove = new System.Windows.Forms.Button();
            this.buttonApplicationAdd = new System.Windows.Forms.Button();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxFieldMappings.SuspendLayout();
            this.tabPageApplications.SuspendLayout();
            this.groupBoxApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageApplications);
            this.tabControl.Location = new System.Drawing.Point(13, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(518, 391);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxFieldMappings);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(510, 365);
            this.tabPageMain.TabIndex = 1;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxFieldMappings
            // 
            this.groupBoxFieldMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFieldMappings.Controls.Add(this.label3);
            this.groupBoxFieldMappings.Controls.Add(this.textBoxRDPHeight);
            this.groupBoxFieldMappings.Controls.Add(this.textBoxRDPWidth);
            this.groupBoxFieldMappings.Controls.Add(this.label2);
            this.groupBoxFieldMappings.Controls.Add(this.checkBoxEnableRDPFullScreen);
            this.groupBoxFieldMappings.Controls.Add(this.label1);
            this.groupBoxFieldMappings.Controls.Add(this.labelRDPInfo);
            this.groupBoxFieldMappings.Controls.Add(this.checkBoxEnableBuiltinRDP);
            this.groupBoxFieldMappings.Controls.Add(this.labelEnableBuiltinRDP);
            this.groupBoxFieldMappings.Controls.Add(this.labelMainSeparator1);
            this.groupBoxFieldMappings.Controls.Add(this.comboBoxConnectionMethod);
            this.groupBoxFieldMappings.Controls.Add(this.labelConnectionMethod);
            this.groupBoxFieldMappings.Location = new System.Drawing.Point(7, 6);
            this.groupBoxFieldMappings.Name = "groupBoxFieldMappings";
            this.groupBoxFieldMappings.Size = new System.Drawing.Size(497, 355);
            this.groupBoxFieldMappings.TabIndex = 0;
            this.groupBoxFieldMappings.TabStop = false;
            this.groupBoxFieldMappings.Text = "Settings";
            // 
            // textBoxRDPHeight
            // 
            this.textBoxRDPHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRDPHeight.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxRDPHeight.Location = new System.Drawing.Point(180, 182);
            this.textBoxRDPHeight.MaxLength = 4;
            this.textBoxRDPHeight.Name = "textBoxRDPHeight";
            this.textBoxRDPHeight.Size = new System.Drawing.Size(40, 21);
            this.textBoxRDPHeight.TabIndex = 20;
            this.textBoxRDPHeight.Text = "600";
            this.textBoxRDPHeight.WordWrap = false;
            // 
            // textBoxRDPWidth
            // 
            this.textBoxRDPWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRDPWidth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxRDPWidth.Location = new System.Drawing.Point(180, 155);
            this.textBoxRDPWidth.MaxLength = 4;
            this.textBoxRDPWidth.Name = "textBoxRDPWidth";
            this.textBoxRDPWidth.Size = new System.Drawing.Size(40, 21);
            this.textBoxRDPWidth.TabIndex = 19;
            this.textBoxRDPWidth.Text = "800";
            this.textBoxRDPWidth.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "RDP Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxEnableRDPFullScreen
            // 
            this.checkBoxEnableRDPFullScreen.AutoSize = true;
            this.checkBoxEnableRDPFullScreen.Location = new System.Drawing.Point(180, 138);
            this.checkBoxEnableRDPFullScreen.Name = "checkBoxEnableRDPFullScreen";
            this.checkBoxEnableRDPFullScreen.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnableRDPFullScreen.TabIndex = 17;
            this.checkBoxEnableRDPFullScreen.UseVisualStyleBackColor = true;
            this.checkBoxEnableRDPFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxEnableRDPFullScreen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enable RDP FullScreen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRDPInfo
            // 
            this.labelRDPInfo.AutoSize = true;
            this.labelRDPInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRDPInfo.Location = new System.Drawing.Point(6, 93);
            this.labelRDPInfo.Name = "labelRDPInfo";
            this.labelRDPInfo.Size = new System.Drawing.Size(101, 13);
            this.labelRDPInfo.TabIndex = 15;
            this.labelRDPInfo.Text = "RDP [mstsc.exe]";
            // 
            // checkBoxEnableBuiltinRDP
            // 
            this.checkBoxEnableBuiltinRDP.AutoSize = true;
            this.checkBoxEnableBuiltinRDP.Location = new System.Drawing.Point(180, 117);
            this.checkBoxEnableBuiltinRDP.Name = "checkBoxEnableBuiltinRDP";
            this.checkBoxEnableBuiltinRDP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEnableBuiltinRDP.TabIndex = 8;
            this.checkBoxEnableBuiltinRDP.UseVisualStyleBackColor = true;
            // 
            // labelEnableBuiltinRDP
            // 
            this.labelEnableBuiltinRDP.AutoSize = true;
            this.labelEnableBuiltinRDP.Location = new System.Drawing.Point(7, 117);
            this.labelEnableBuiltinRDP.Name = "labelEnableBuiltinRDP";
            this.labelEnableBuiltinRDP.Size = new System.Drawing.Size(167, 12);
            this.labelEnableBuiltinRDP.TabIndex = 7;
            this.labelEnableBuiltinRDP.Text = "Enable built-in RDP support";
            this.labelEnableBuiltinRDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMainSeparator1
            // 
            this.labelMainSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMainSeparator1.Location = new System.Drawing.Point(7, 79);
            this.labelMainSeparator1.Name = "labelMainSeparator1";
            this.labelMainSeparator1.Size = new System.Drawing.Size(484, 2);
            this.labelMainSeparator1.TabIndex = 6;
            // 
            // comboBoxConnectionMethod
            // 
            this.comboBoxConnectionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConnectionMethod.FormattingEnabled = true;
            this.comboBoxConnectionMethod.Location = new System.Drawing.Point(157, 18);
            this.comboBoxConnectionMethod.Name = "comboBoxConnectionMethod";
            this.comboBoxConnectionMethod.Size = new System.Drawing.Size(334, 20);
            this.comboBoxConnectionMethod.TabIndex = 3;
            this.comboBoxConnectionMethod.Text = "Keepass Field";
            // 
            // labelConnectionMethod
            // 
            this.labelConnectionMethod.AutoSize = true;
            this.labelConnectionMethod.Location = new System.Drawing.Point(6, 20);
            this.labelConnectionMethod.Name = "labelConnectionMethod";
            this.labelConnectionMethod.Size = new System.Drawing.Size(143, 12);
            this.labelConnectionMethod.TabIndex = 2;
            this.labelConnectionMethod.Text = "Connection method field";
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.Controls.Add(this.groupBoxApplications);
            this.tabPageApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplications.Size = new System.Drawing.Size(510, 365);
            this.tabPageApplications.TabIndex = 2;
            this.tabPageApplications.Text = "Applications";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // groupBoxApplications
            // 
            this.groupBoxApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxApplications.Controls.Add(this.buttonApplicationRemove);
            this.groupBoxApplications.Controls.Add(this.buttonApplicationAdd);
            this.groupBoxApplications.Controls.Add(this.dataGridViewApplications);
            this.groupBoxApplications.Location = new System.Drawing.Point(7, 6);
            this.groupBoxApplications.Name = "groupBoxApplications";
            this.groupBoxApplications.Size = new System.Drawing.Size(497, 355);
            this.groupBoxApplications.TabIndex = 0;
            this.groupBoxApplications.TabStop = false;
            this.groupBoxApplications.Text = "Applications";
            // 
            // buttonApplicationRemove
            // 
            this.buttonApplicationRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplicationRemove.Location = new System.Drawing.Point(375, 324);
            this.buttonApplicationRemove.Name = "buttonApplicationRemove";
            this.buttonApplicationRemove.Size = new System.Drawing.Size(116, 26);
            this.buttonApplicationRemove.TabIndex = 2;
            this.buttonApplicationRemove.Text = "Remove";
            this.buttonApplicationRemove.UseVisualStyleBackColor = true;
            this.buttonApplicationRemove.Click += new System.EventHandler(this.buttonApplicationRemove_Click);
            // 
            // buttonApplicationAdd
            // 
            this.buttonApplicationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplicationAdd.Location = new System.Drawing.Point(375, 293);
            this.buttonApplicationAdd.Name = "buttonApplicationAdd";
            this.buttonApplicationAdd.Size = new System.Drawing.Size(116, 26);
            this.buttonApplicationAdd.TabIndex = 0;
            this.buttonApplicationAdd.Text = "Add";
            this.buttonApplicationAdd.UseVisualStyleBackColor = true;
            this.buttonApplicationAdd.Click += new System.EventHandler(this.buttonApplicationAdd_Click);
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.AllowUserToAddRows = false;
            this.dataGridViewApplications.AllowUserToDeleteRows = false;
            this.dataGridViewApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApplications.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.RowHeadersVisible = false;
            this.dataGridViewApplications.Size = new System.Drawing.Size(485, 270);
            this.dataGridViewApplications.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(456, 409);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 21);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(375, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(294, 409);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "RDP Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 441);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(559, 480);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxFieldMappings.ResumeLayout(false);
            this.groupBoxFieldMappings.PerformLayout();
            this.tabPageApplications.ResumeLayout(false);
            this.groupBoxApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxFieldMappings;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxConnectionMethod;
        private System.Windows.Forms.Label labelConnectionMethod;
        private System.Windows.Forms.TabPage tabPageApplications;
        private System.Windows.Forms.GroupBox groupBoxApplications;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.Button buttonApplicationRemove;
        private System.Windows.Forms.Button buttonApplicationAdd;
        private System.Windows.Forms.Label labelMainSeparator1;
        private System.Windows.Forms.CheckBox checkBoxEnableBuiltinRDP;
        private System.Windows.Forms.Label labelEnableBuiltinRDP;
        private System.Windows.Forms.Label labelRDPInfo;
        private System.Windows.Forms.CheckBox checkBoxEnableRDPFullScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRDPHeight;
        private System.Windows.Forms.TextBox textBoxRDPWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
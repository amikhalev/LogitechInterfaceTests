namespace LogitechInterfaceTest
{
    partial class LogitechInterfaceTest
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
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.comboBoxInitType = new System.Windows.Forms.ComboBox();
            this.textBoxInitSuccess = new System.Windows.Forms.TextBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.comboBoxTestConnectionType = new System.Windows.Forms.ComboBox();
            this.textBoxConnectionTestSuccess = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMain.SuspendLayout();
            this.groupBoxInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Controls.Add(this.groupBoxInit);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1002, 503);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.buttonInit);
            this.groupBoxInit.Controls.Add(this.comboBoxInitType);
            this.groupBoxInit.Controls.Add(this.textBoxInitSuccess);
            this.groupBoxInit.Controls.Add(this.buttonTestConnection);
            this.groupBoxInit.Controls.Add(this.comboBoxTestConnectionType);
            this.groupBoxInit.Controls.Add(this.textBoxConnectionTestSuccess);
            this.groupBoxInit.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(211, 79);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "Initialize";
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(10, 19);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(62, 23);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Initialize";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // comboBoxInitType
            // 
            this.comboBoxInitType.FormattingEnabled = true;
            this.comboBoxInitType.Items.AddRange(new object[] {
            "Color",
            "Monochrome",
            "Both"});
            this.comboBoxInitType.Location = new System.Drawing.Point(77, 20);
            this.comboBoxInitType.Name = "comboBoxInitType";
            this.comboBoxInitType.Size = new System.Drawing.Size(82, 21);
            this.comboBoxInitType.TabIndex = 1;
            // 
            // textBoxInitSuccess
            // 
            this.textBoxInitSuccess.Enabled = false;
            this.textBoxInitSuccess.Location = new System.Drawing.Point(165, 20);
            this.textBoxInitSuccess.Name = "textBoxInitSuccess";
            this.textBoxInitSuccess.Size = new System.Drawing.Size(40, 20);
            this.textBoxInitSuccess.TabIndex = 2;
            this.textBoxInitSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(10, 48);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(62, 23);
            this.buttonTestConnection.TabIndex = 3;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            // 
            // comboBoxTestConnectionType
            // 
            this.comboBoxTestConnectionType.FormattingEnabled = true;
            this.comboBoxTestConnectionType.Items.AddRange(new object[] {
            "Color",
            "Monochrome",
            "Both"});
            this.comboBoxTestConnectionType.Location = new System.Drawing.Point(77, 49);
            this.comboBoxTestConnectionType.Name = "comboBoxTestConnectionType";
            this.comboBoxTestConnectionType.Size = new System.Drawing.Size(82, 21);
            this.comboBoxTestConnectionType.TabIndex = 4;
            // 
            // textBoxConnectionTestSuccess
            // 
            this.textBoxConnectionTestSuccess.Enabled = false;
            this.textBoxConnectionTestSuccess.Location = new System.Drawing.Point(165, 49);
            this.textBoxConnectionTestSuccess.Name = "textBoxConnectionTestSuccess";
            this.textBoxConnectionTestSuccess.Size = new System.Drawing.Size(40, 20);
            this.textBoxConnectionTestSuccess.TabIndex = 5;
            this.textBoxConnectionTestSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogitechInterfaceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Name = "LogitechInterfaceTest";
            this.Text = "Logitech Interface Test";
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.groupBoxInit.ResumeLayout(false);
            this.groupBoxInit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxInit;
        private System.Windows.Forms.TextBox textBoxInitSuccess;
        private System.Windows.Forms.ComboBox comboBoxInitType;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.TextBox textBoxConnectionTestSuccess;
        private System.Windows.Forms.ComboBox comboBoxTestConnectionType;
    }
}


using System.Windows.Forms;

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
            this.textBoxAppletName = new System.Windows.Forms.TextBox();
            this.textBoxConnectionTestSuccess = new System.Windows.Forms.TextBox();
            this.comboBoxTestConnectionType = new System.Windows.Forms.ComboBox();
            this.comboBoxInitType = new System.Windows.Forms.ComboBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.textBoxInitSuccess = new System.Windows.Forms.TextBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.groupBoxColorButtons = new System.Windows.Forms.GroupBox();
            this.checkBoxColorCancel = new System.Windows.Forms.CheckBox();
            this.checkBoxColorMenu = new System.Windows.Forms.CheckBox();
            this.checkBoxColorOk = new System.Windows.Forms.CheckBox();
            this.checkBoxColorRight = new System.Windows.Forms.CheckBox();
            this.checkBoxColorLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxColorDown = new System.Windows.Forms.CheckBox();
            this.checkBoxColorUp = new System.Windows.Forms.CheckBox();
            this.groupBoxMonochromButtons = new System.Windows.Forms.GroupBox();
            this.checkBoxMonoButton1 = new System.Windows.Forms.CheckBox();
            this.checkBoxMonoButton4 = new System.Windows.Forms.CheckBox();
            this.checkBoxMonoButton2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMonoButton3 = new System.Windows.Forms.CheckBox();
            this.groupBoxMonochromeLcd = new System.Windows.Forms.GroupBox();
            this.groupBoxColorLcd = new System.Windows.Forms.GroupBox();
            this.buttonShutdownApplet = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.panelControlButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain.SuspendLayout();
            this.groupBoxInit.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxColorButtons.SuspendLayout();
            this.groupBoxMonochromButtons.SuspendLayout();
            this.panelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.Controls.Add(this.groupBoxInit);
            this.flowLayoutPanelMain.Controls.Add(this.groupBoxButtons);
            this.flowLayoutPanelMain.Controls.Add(this.groupBoxMonochromeLcd);
            this.flowLayoutPanelMain.Controls.Add(this.groupBoxColorLcd);
            this.flowLayoutPanelMain.Controls.Add(this.panelControlButtons);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(610, 338);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.buttonInit);
            this.groupBoxInit.Controls.Add(this.textBoxAppletName);
            this.groupBoxInit.Controls.Add(this.textBoxConnectionTestSuccess);
            this.groupBoxInit.Controls.Add(this.comboBoxTestConnectionType);
            this.groupBoxInit.Controls.Add(this.comboBoxInitType);
            this.groupBoxInit.Controls.Add(this.buttonTestConnection);
            this.groupBoxInit.Controls.Add(this.textBoxInitSuccess);
            this.groupBoxInit.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(364, 144);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "Initialize";
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(6, 19);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(60, 21);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Initialize";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // textBoxAppletName
            // 
            this.textBoxAppletName.Location = new System.Drawing.Point(178, 19);
            this.textBoxAppletName.Name = "textBoxAppletName";
            this.textBoxAppletName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppletName.TabIndex = 2;
            this.textBoxAppletName.Text = "Test";
            // 
            // textBoxConnectionTestSuccess
            // 
            this.textBoxConnectionTestSuccess.Enabled = false;
            this.textBoxConnectionTestSuccess.Location = new System.Drawing.Point(284, 45);
            this.textBoxConnectionTestSuccess.Name = "textBoxConnectionTestSuccess";
            this.textBoxConnectionTestSuccess.Size = new System.Drawing.Size(70, 20);
            this.textBoxConnectionTestSuccess.TabIndex = 5;
            this.textBoxConnectionTestSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxTestConnectionType
            // 
            this.comboBoxTestConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestConnectionType.FormattingEnabled = true;
            this.comboBoxTestConnectionType.Items.AddRange(new object[] {
            "Color",
            "Monochrome",
            "Both"});
            this.comboBoxTestConnectionType.Location = new System.Drawing.Point(72, 46);
            this.comboBoxTestConnectionType.Name = "comboBoxTestConnectionType";
            this.comboBoxTestConnectionType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTestConnectionType.TabIndex = 4;
            // 
            // comboBoxInitType
            // 
            this.comboBoxInitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInitType.FormattingEnabled = true;
            this.comboBoxInitType.Items.AddRange(new object[] {
            "Color",
            "Monochrome",
            "Both"});
            this.comboBoxInitType.Location = new System.Drawing.Point(72, 19);
            this.comboBoxInitType.Name = "comboBoxInitType";
            this.comboBoxInitType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxInitType.TabIndex = 1;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(6, 46);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(60, 21);
            this.buttonTestConnection.TabIndex = 3;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // textBoxInitSuccess
            // 
            this.textBoxInitSuccess.Enabled = false;
            this.textBoxInitSuccess.Location = new System.Drawing.Point(284, 19);
            this.textBoxInitSuccess.Name = "textBoxInitSuccess";
            this.textBoxInitSuccess.Size = new System.Drawing.Size(70, 20);
            this.textBoxInitSuccess.TabIndex = 2;
            this.textBoxInitSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.groupBoxColorButtons);
            this.groupBoxButtons.Controls.Add(this.groupBoxMonochromButtons);
            this.groupBoxButtons.Location = new System.Drawing.Point(373, 3);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(233, 144);
            this.groupBoxButtons.TabIndex = 1;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Buttons";
            // 
            // groupBoxColorButtons
            // 
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorCancel);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorMenu);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorOk);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorRight);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorLeft);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorDown);
            this.groupBoxColorButtons.Controls.Add(this.checkBoxColorUp);
            this.groupBoxColorButtons.Enabled = false;
            this.groupBoxColorButtons.Location = new System.Drawing.Point(135, 19);
            this.groupBoxColorButtons.Name = "groupBoxColorButtons";
            this.groupBoxColorButtons.Size = new System.Drawing.Size(87, 111);
            this.groupBoxColorButtons.TabIndex = 5;
            this.groupBoxColorButtons.TabStop = false;
            this.groupBoxColorButtons.Text = "Color Buttons";
            // 
            // checkBoxColorCancel
            // 
            this.checkBoxColorCancel.AutoSize = true;
            this.checkBoxColorCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorCancel.Location = new System.Drawing.Point(56, 84);
            this.checkBoxColorCancel.Name = "checkBoxColorCancel";
            this.checkBoxColorCancel.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorCancel.TabIndex = 6;
            this.checkBoxColorCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorMenu
            // 
            this.checkBoxColorMenu.AutoSize = true;
            this.checkBoxColorMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorMenu.Location = new System.Drawing.Point(14, 84);
            this.checkBoxColorMenu.Name = "checkBoxColorMenu";
            this.checkBoxColorMenu.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorMenu.TabIndex = 5;
            this.checkBoxColorMenu.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorOk
            // 
            this.checkBoxColorOk.AutoSize = true;
            this.checkBoxColorOk.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorOk.Location = new System.Drawing.Point(35, 43);
            this.checkBoxColorOk.Name = "checkBoxColorOk";
            this.checkBoxColorOk.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorOk.TabIndex = 4;
            this.checkBoxColorOk.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorRight
            // 
            this.checkBoxColorRight.AutoSize = true;
            this.checkBoxColorRight.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorRight.Location = new System.Drawing.Point(56, 43);
            this.checkBoxColorRight.Name = "checkBoxColorRight";
            this.checkBoxColorRight.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorRight.TabIndex = 3;
            this.checkBoxColorRight.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorLeft
            // 
            this.checkBoxColorLeft.AutoSize = true;
            this.checkBoxColorLeft.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorLeft.Location = new System.Drawing.Point(14, 43);
            this.checkBoxColorLeft.Name = "checkBoxColorLeft";
            this.checkBoxColorLeft.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorLeft.TabIndex = 2;
            this.checkBoxColorLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorDown
            // 
            this.checkBoxColorDown.AutoSize = true;
            this.checkBoxColorDown.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorDown.Location = new System.Drawing.Point(35, 66);
            this.checkBoxColorDown.Name = "checkBoxColorDown";
            this.checkBoxColorDown.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorDown.TabIndex = 1;
            this.checkBoxColorDown.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorUp
            // 
            this.checkBoxColorUp.AutoSize = true;
            this.checkBoxColorUp.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxColorUp.Location = new System.Drawing.Point(35, 19);
            this.checkBoxColorUp.Name = "checkBoxColorUp";
            this.checkBoxColorUp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColorUp.TabIndex = 0;
            this.checkBoxColorUp.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonochromButtons
            // 
            this.groupBoxMonochromButtons.Controls.Add(this.checkBoxMonoButton1);
            this.groupBoxMonochromButtons.Controls.Add(this.checkBoxMonoButton4);
            this.groupBoxMonochromButtons.Controls.Add(this.checkBoxMonoButton2);
            this.groupBoxMonochromButtons.Controls.Add(this.checkBoxMonoButton3);
            this.groupBoxMonochromButtons.Enabled = false;
            this.groupBoxMonochromButtons.Location = new System.Drawing.Point(6, 19);
            this.groupBoxMonochromButtons.Name = "groupBoxMonochromButtons";
            this.groupBoxMonochromButtons.Size = new System.Drawing.Size(123, 40);
            this.groupBoxMonochromButtons.TabIndex = 4;
            this.groupBoxMonochromButtons.TabStop = false;
            this.groupBoxMonochromButtons.Text = "Monochrome Buttons";
            // 
            // checkBoxMonoButton1
            // 
            this.checkBoxMonoButton1.AutoSize = true;
            this.checkBoxMonoButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMonoButton1.Location = new System.Drawing.Point(23, 19);
            this.checkBoxMonoButton1.Name = "checkBoxMonoButton1";
            this.checkBoxMonoButton1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonoButton1.TabIndex = 0;
            this.checkBoxMonoButton1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonoButton4
            // 
            this.checkBoxMonoButton4.AutoSize = true;
            this.checkBoxMonoButton4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMonoButton4.Location = new System.Drawing.Point(86, 19);
            this.checkBoxMonoButton4.Name = "checkBoxMonoButton4";
            this.checkBoxMonoButton4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonoButton4.TabIndex = 3;
            this.checkBoxMonoButton4.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonoButton2
            // 
            this.checkBoxMonoButton2.AutoSize = true;
            this.checkBoxMonoButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMonoButton2.Location = new System.Drawing.Point(44, 19);
            this.checkBoxMonoButton2.Name = "checkBoxMonoButton2";
            this.checkBoxMonoButton2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonoButton2.TabIndex = 1;
            this.checkBoxMonoButton2.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonoButton3
            // 
            this.checkBoxMonoButton3.AutoSize = true;
            this.checkBoxMonoButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMonoButton3.Location = new System.Drawing.Point(65, 19);
            this.checkBoxMonoButton3.Name = "checkBoxMonoButton3";
            this.checkBoxMonoButton3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMonoButton3.TabIndex = 2;
            this.checkBoxMonoButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonochromeLcd
            // 
            this.groupBoxMonochromeLcd.Location = new System.Drawing.Point(3, 153);
            this.groupBoxMonochromeLcd.Name = "groupBoxMonochromeLcd";
            this.groupBoxMonochromeLcd.Size = new System.Drawing.Size(200, 100);
            this.groupBoxMonochromeLcd.TabIndex = 2;
            this.groupBoxMonochromeLcd.TabStop = false;
            this.groupBoxMonochromeLcd.Text = "Monochrome LCD";
            // 
            // groupBoxColorLcd
            // 
            this.groupBoxColorLcd.Location = new System.Drawing.Point(209, 153);
            this.groupBoxColorLcd.Name = "groupBoxColorLcd";
            this.groupBoxColorLcd.Size = new System.Drawing.Size(229, 100);
            this.groupBoxColorLcd.TabIndex = 3;
            this.groupBoxColorLcd.TabStop = false;
            this.groupBoxColorLcd.Text = "Color LCD";
            // 
            // buttonShutdownApplet
            // 
            this.buttonShutdownApplet.Location = new System.Drawing.Point(3, 3);
            this.buttonShutdownApplet.Name = "buttonShutdownApplet";
            this.buttonShutdownApplet.Size = new System.Drawing.Size(75, 23);
            this.buttonShutdownApplet.TabIndex = 4;
            this.buttonShutdownApplet.Text = "Shutdown";
            this.buttonShutdownApplet.UseVisualStyleBackColor = true;
            this.buttonShutdownApplet.Click += new System.EventHandler(this.buttonShutdownApplet_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.Location = new System.Drawing.Point(3, 32);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseWindow.TabIndex = 5;
            this.buttonCloseWindow.Text = "Close";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // panelControlButtons
            // 
            this.panelControlButtons.Controls.Add(this.buttonCloseWindow);
            this.panelControlButtons.Controls.Add(this.buttonShutdownApplet);
            this.panelControlButtons.Location = new System.Drawing.Point(444, 153);
            this.panelControlButtons.Name = "panelControlButtons";
            this.panelControlButtons.Size = new System.Drawing.Size(81, 100);
            this.panelControlButtons.TabIndex = 6;
            // 
            // LogitechInterfaceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LogitechInterfaceTest";
            this.Text = "Logitech Interface Test";
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.groupBoxInit.ResumeLayout(false);
            this.groupBoxInit.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxColorButtons.ResumeLayout(false);
            this.groupBoxColorButtons.PerformLayout();
            this.groupBoxMonochromButtons.ResumeLayout(false);
            this.groupBoxMonochromButtons.PerformLayout();
            this.panelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBoxAppletName;
        private GroupBox groupBoxButtons;
        private GroupBox groupBoxColorButtons;
        private CheckBox checkBoxColorCancel;
        private CheckBox checkBoxColorMenu;
        private CheckBox checkBoxColorOk;
        private CheckBox checkBoxColorRight;
        private CheckBox checkBoxColorLeft;
        private CheckBox checkBoxColorDown;
        private CheckBox checkBoxColorUp;
        private GroupBox groupBoxMonochromButtons;
        private CheckBox checkBoxMonoButton1;
        private CheckBox checkBoxMonoButton4;
        private CheckBox checkBoxMonoButton2;
        private CheckBox checkBoxMonoButton3;
        private GroupBox groupBoxMonochromeLcd;
        private GroupBox groupBoxColorLcd;
        private Panel panelControlButtons;
        private Button buttonCloseWindow;
        private Button buttonShutdownApplet;
    }
}


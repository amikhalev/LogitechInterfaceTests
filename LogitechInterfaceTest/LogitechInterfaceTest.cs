using System;
using System.Windows.Forms;
using LogitechInterface;

namespace LogitechInterfaceTest
{
    public partial class LogitechInterfaceTest : Form
    {
        private LogitechLcd _lcd;

        public LogitechInterfaceTest()
        {
            InitializeComponent();
            comboBoxInitType.SelectedItem = "Both";
            comboBoxTestConnectionType.SelectedItem = "Both";
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {

                _lcd = new LogitechLcd("Test", (LogitechLcd.LcdType)Enum.Parse(typeof(LogitechLcd.LcdType), comboBoxInitType.SelectedText));
                textBoxInitSuccess.Text = "Success";

        }
    }
}
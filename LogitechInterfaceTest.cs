using System;
using System.Windows.Forms;
using LogitechInterface;
using Timer = System.Threading.Timer;

namespace LogitechInterfaceTest
{
    public partial class LogitechInterfaceTest : Form
    {
        private LogitechLcd _lcd;
// ReSharper disable NotAccessedField.Local
        private Timer _timer;
// ReSharper restore NotAccessedField.Local

        public LogitechInterfaceTest()
        {
            InitializeComponent();
            comboBoxInitType.SelectedItem = "Both";
            comboBoxTestConnectionType.SelectedItem = "Both";
            checkBoxMonoButton1.Checked = false;
            checkBoxMonoButton2.Checked = false;
            checkBoxMonoButton3.Checked = false;
            checkBoxMonoButton4.Checked = false;

            checkBoxColorUp.Checked = false;
            checkBoxColorDown.Checked = false;
            checkBoxColorLeft.Checked = false;
            checkBoxColorRight.Checked = false;
            checkBoxColorOk.Checked = false;
            checkBoxColorMenu.Checked = false;
            checkBoxColorCancel.Checked = false;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            try
            {
                _lcd = new LogitechLcd(textBoxAppletName.Text,
                                       (LogitechLcd.LcdType)
                                       Enum.Parse(typeof (LogitechLcd.LcdType), comboBoxInitType.Text));
                textBoxInitSuccess.Text = "Success";
                _timer = new Timer(UpdateLcd, null, 0, 50);
                groupBoxMonochromButtons.Enabled = true;
                groupBoxColorButtons.Enabled = true;
            }
            catch (Exception)
            {
                textBoxInitSuccess.Text = "Failed";
            }
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (_lcd != null &&
                _lcd.LcdIsConnected(
                    (LogitechLcd.LcdType) Enum.Parse(typeof (LogitechLcd.LcdType), comboBoxTestConnectionType.Text)))
            {
                textBoxConnectionTestSuccess.Text = "Connected";
            }
            else
            {
                textBoxConnectionTestSuccess.Text = "Failed";
            }
        }

        private void UpdateLcd(object stateData)
        {
            _lcd.LcdUpdate();

            var monoButton1 = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.Monochrome0);
            var monoButton2 = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.Monochrome1);
            var monoButton3 = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.Monochrome2);
            var monoButton4 = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.Monochrome3);

            var colorButtonUp = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorUp);
            var colorButtonDown = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorDown);
            var colorButtonLeft = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorLeft);
            var colorButtonRight = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorRight);
            var colorButtonOk = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorOk);
            var colorButtonCancel = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorCancel);
            var colorButtonMenu = _lcd.LcdIsButtonPressed(LogitechLcd.LcdButton.ColorMenu);

            checkBoxMonoButton1.Invoke(new MethodInvoker(delegate { checkBoxMonoButton1.Checked = monoButton1; }));
            checkBoxMonoButton2.Invoke(new MethodInvoker(delegate { checkBoxMonoButton2.Checked = monoButton2; }));
            checkBoxMonoButton3.Invoke(new MethodInvoker(delegate { checkBoxMonoButton3.Checked = monoButton3; }));
            checkBoxMonoButton4.Invoke(new MethodInvoker(delegate { checkBoxMonoButton4.Checked = monoButton4; }));

            checkBoxColorUp.Invoke(new MethodInvoker(delegate { checkBoxColorUp.Checked = colorButtonUp; }));
            checkBoxColorDown.Invoke(new MethodInvoker(delegate { checkBoxColorDown.Checked = colorButtonDown; }));
            checkBoxColorLeft.Invoke(new MethodInvoker(delegate { checkBoxColorLeft.Checked = colorButtonLeft; }));
            checkBoxColorRight.Invoke(new MethodInvoker(delegate { checkBoxColorRight.Checked = colorButtonRight; }));
            checkBoxColorOk.Invoke(new MethodInvoker(delegate { checkBoxColorOk.Checked = colorButtonOk; }));
            checkBoxColorCancel.Invoke(new MethodInvoker(delegate { checkBoxColorCancel.Checked = colorButtonCancel; }));
            checkBoxColorMenu.Invoke(new MethodInvoker(delegate { checkBoxColorMenu.Checked = colorButtonMenu; }));
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (_lcd != null)
                _lcd.LcdShutdown();
            this.Dispose();
        }

        private void buttonShutdownApplet_Click(object sender, EventArgs e)
        {
            if (_lcd != null)
            {
                _lcd.LcdShutdown();
                _lcd = null;
            }
        }
    }
}
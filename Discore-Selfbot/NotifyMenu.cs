using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Discore_Selfbot
{
    public partial class NotifyMenu : KryptonForm
    {
        public NotifyMenu()
        {
            InitializeComponent();
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height);
        }

        private void BtnOpenGUI_Click(object sender, EventArgs e)
        {
            if (Program.MyForm == null)
            {
                MessageBox.Show("Selfbot has not fully loaded cannot open GUI");
                return;
            }
            if (!Program.MyForm.Visible)
            {
                Program.OpenGUI();
                Program.MyForm.Activate();
            }
            else
            {
                Program.MyForm.Activate();
                Console.WriteLine("Gui already open");
            }
        }

        private void BtnShowConsole_Click(object sender, EventArgs e)
        {
            var handle = Program.GetConsoleWindow();
            Program.ShowWindow(handle, Program.SW_SHOW);
        }
        private void BtnHideConsole_Click(object sender, EventArgs e)
        {
            var handle = Program.GetConsoleWindow();
            Program.ShowWindow(handle, Program.SW_HIDE);
        }
    }
}

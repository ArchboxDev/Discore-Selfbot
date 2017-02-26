using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discore_Selfbot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void GuildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var Log in Program.GuildLogs.FindAll(x => x.Contains(GuildList.Text)))
            {
                textBox1.AppendText(Environment.NewLine + Log);
            }
        }
    }
}

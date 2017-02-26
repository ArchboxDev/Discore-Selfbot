using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;

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
            //var guild = Program.client.GetGuild(264310142785290241);
            //var Chan = guild.GetChannel(264312955829485569) as ITextChannel;
            //Chan.SendMessageAsync("Selfbot test yay i got it to work with windows form");
            foreach (var Log in Program.GuildLogs.FindAll(x => x.Contains(GuildList.Text)))
            {
                textBox1.AppendText(Environment.NewLine + Log);
                
            }
        }
    }
}

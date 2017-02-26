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
        public static Discord.Color EmbedColor;
        public static string SelectGuild;
        public static string SelectChannel;
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

        public void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)

            {
                EmbedColor = new Discord.Color(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                button1.ForeColor = colorDialog1.Color;

            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            var Guild = Program.client.GetGuild(264310142785290241);
            var Chan = Guild.GetChannel(264312955829485569) as ITextChannel;
            var embed = new EmbedBuilder()
            {
                Title = EmbedTitle.Text,
                Description = EmbedText.Text,
                Color = EmbedColor
            };
            Chan.SendMessageAsync("", false, embed);
        }

        
    }
}

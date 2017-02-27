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
        public static ulong SelectedGuild;
        public static ulong SelectChannel;
        public static ulong ActiveGuildID;
        public static ulong ActiveChannelID;
        public MainForm()
        {
            InitializeComponent();
        }

        public void GuildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ChannelIndex = ChannelList.SelectedIndex;
            SelectChannel = Program.ChannelsID[ChannelIndex];
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
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Text = Program.client.CurrentUser.Username + " - " + e.ClickedItem.Text;
            var GuildIndex = GuildList.Items.IndexOf(e.ClickedItem);
            SelectedGuild = Program.GuildsID[GuildIndex];
            ChannelList.Items.Clear();
            ChannelList.Visible = true;
            var GuildID = Program.GuildsID[GuildIndex];
            var Guild = Program.client.GetGuild(GuildID);
            Program.Channels.Clear();
            Program.ChannelsID.Clear();
            foreach (var Chan in Guild.TextChannels)
            {
                ChannelList.Items.Add($"{Chan.Name}");
                Program.Channels.Add(Chan.Name);
                Program.ChannelsID.Add(Chan.Id);
            }
        }

        private void SelectedChannelClick(object sender, EventArgs e)
        {
            if (SelectedGuild == null)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (SelectChannel == null)
            {
                MessageBox.Show("No channel selected");
                return;
            }
            var Guild = Program.client.GetGuild(SelectedGuild);
            var Chan = Guild.GetChannel(SelectChannel) as ITextChannel;
            var embed = new EmbedBuilder()
            {
                Title = EmbedTitle.Text,
                Description = EmbedText.Text,
                Color = EmbedColor
            };
            Chan.SendMessageAsync("", false, embed);
        }

        private void EmbedActive_Click(object sender, EventArgs e)
        {
            if (SelectedGuild == null)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (SelectChannel == null)
            {
                MessageBox.Show("No channel selected");
                return;
            }
            var Guild = Program.client.GetGuild(ActiveGuildID);
            var Chan = Guild.GetChannel(ActiveChannelID) as ITextChannel;
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

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
        public static ulong SelectedGuild = 0;
        public static ulong SelectChannel = 0;
        public static ulong ActiveGuildID = 0;
        public static ulong ActiveChannelID = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        

        public void MainForm_Load(object sender, EventArgs e)
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
            if (SelectedGuild == 0)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (SelectChannel == 0)
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
            if (SelectedGuild == 0)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (SelectChannel == 0)
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

        private void GuildList_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine($"Selected Guild {e.ClickedItem.Name}");
            var Index = ChannelList.SelectedIndex;
            SelectedGuild = Program.GuildsID[Index];
            
        }

        private void ChannelSelected(object sender, EventArgs e)
        {
            Console.WriteLine($"Selected Channel {ChannelList.SelectedText}");
            var Index = ChannelList.SelectedIndex;
            SelectChannel = Program.ChannelsID[Index];
        }

        private void OpenColorsButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)

            {
                EmbedColor = new Discord.Color(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                OpenColorsButton.ForeColor = colorDialog1.Color;

            }
        }
    }
}

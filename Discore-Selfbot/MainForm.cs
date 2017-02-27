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
            if (ActiveGuildID == 0)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (ActiveChannelID == 0)
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

        private void Information_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine(e.Node.Name);
            MoreInfo.Visible = true;
            if (e.Node.Name == "PixelBot")
            {
                MoreInfo.Text = "A gamer featured bot with commands for steam/osu/minecraft and twitch streamer alerts" + Environment.NewLine + "https://discordapp.com/oauth2/authorize?&client_id=277933222015401985&scope=bot&permissions=0";
            }
            if (e.Node.Name == "Minotaur")
            {
                MoreInfo.Text = "A guild moderation bot with ban/kick/mute commands and advanced logging/userlogs/modlogs" + Environment.NewLine + "https://discordapp.com/oauth2/authorize?&client_id=281849383404830733&scope=bot&permissions=0";
            }
            if (e.Node.Name == "Discord Cards")
            {
                MoreInfo.Text = "Buy/Trade/Collect all of the rare cards featured around discord" + Environment.NewLine + "https://discordapp.com/oauth2/authorize?client_id=275388037817696287&scope=bot";
            }
            if (e.Node.Name == "Casino Bot")
            {
                MoreInfo.Text = "Spin the wheel and get the JACKPOT!" + Environment.NewLine + "https://discordapp.com/oauth2/authorize?client_id=263330369409908736&scope=bot&permissions=19456";
            }
            if (e.Node.Name == "Discord RPG")
            {
                MoreInfo.Text = "Who dosent love a good RPG bot?" + Environment.NewLine + "https://discordapp.com/oauth2/authorize?&client_id=170915256833540097&scope=bot&permissions=0";
            }
            if (e.Node.Name == "Sekusuikuto")
            {
                MoreInfo.Text = "Currently down so i cannot add :P" + Environment.NewLine + "No Link :(";
            }
        }
    }
}

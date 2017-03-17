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
using System.Net;
using System.IO;

namespace Discore_Selfbot
{
    public partial class GUI : Form
    {
        public static Discord.Color EmbedColor;
        public static ulong SelectedGuild = 0;
        public static ulong SelectChannel = 0;
        public string LastEmbedTitle = "";
        public string LastEmbedText = "";

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            if (Program.Ready == false)
            {
                if (Properties.Settings.Default.AutoForm == "No")
                {
                    return;
                }
            }
            WebClient WBC = new WebClient();
            Program.Guilds.Clear();
            Program.GuildsID.Clear();
            this.Text = Program.CurrentUserName;
            if (File.Exists($"avatar.png"))
            {
                this.Icon = Program.Avatar;
            }
            foreach (var Guild in Program.client.Guilds)
            {
                if (!File.Exists($"{Guild.Id}.png"))
                {
                    if (Guild.IconUrl == null)
                    {
                        WBC.DownloadFile("http://dev.blaze.ml/Letters/" + Guild.Name.ToUpper().ToCharArray()[0] + ".png", $"{Guild.Id}.png");
                    }
                    else
                    {
                        WBC.DownloadFile(Guild.IconUrl, $"{Guild.Id}.png");
                    }
                    WBC.Dispose();
                }
                GuildList.Items.Add(Guild.Name, System.Drawing.Image.FromFile($"{Guild.Id}.png")).DisplayStyle = ToolStripItemDisplayStyle.Image;
                Program.Guilds.Add(Guild.Name);
                Program.GuildsID.Add(Guild.Id);
            }
        }

        private void GuildList_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine($"Selected Guild {e.ClickedItem.ToolTipText}");
            Text = Program.client.CurrentUser.Username + " - " + e.ClickedItem.Text;
            var GuildIndex = GuildList.Items.IndexOf(e.ClickedItem);
            var Guild = Program.client.GetGuild(Program.GuildsID[GuildIndex]);
            var GuildUser = Guild.GetUser(Program.client.CurrentUser.Id);
            int MembersOnline = 0;
            int MembersOffline = 0;
            int BotsOnline = 0;
            int BotsOffline = 0;
            foreach (var User in Guild.Users)
            {
                if (User.IsBot)
                {
                    if (User.Status == UserStatus.Online || User.Status == UserStatus.Idle || User.Status == UserStatus.AFK || User.Status == UserStatus.DoNotDisturb)
                    {
                        BotsOnline++;
                    }
                    else
                    {
                        BotsOffline++;
                    }
                }
                else
                {
                    if (User.Status == UserStatus.Online || User.Status == UserStatus.Idle || User.Status == UserStatus.AFK || User.Status == UserStatus.DoNotDisturb)
                    {
                        MembersOnline++;
                    }
                    else
                    {
                        MembersOffline++;
                    }
                }
            }
            
            TextGuildInfo.Text = $"ID: {Guild.Id}" + Environment.NewLine + $"Owner: {Guild.Owner.Username} - {Guild.Owner.Id}" + Environment.NewLine + $"Users: Online {MembersOnline}/{MembersOffline} Offline" + Environment.NewLine + $"Bots: Online {BotsOnline}/{BotsOffline} Offline" + Environment.NewLine + $"Roles: {Guild.Roles.Count - 1} Emojis: {Guild.Emojis.Count}" + Environment.NewLine + $"Created: {Guild.CreatedAt.Date.ToShortDateString()}";
            SelectedGuild = Program.GuildsID[GuildIndex];
            ChannelList.Items.Clear();
            ChannelList.Visible = true;
            Program.Channels.Clear();
            Program.ChannelsID.Clear();
            foreach (var Chan in Guild.TextChannels)
            {
                Program.Channels.Add(Chan.Name);
                Program.ChannelsID.Add(Chan.Id);
                ChannelList.Items.Add($"{Chan.Name}");
            }
            TextGuildRoles.Clear();
            List<string> RoleList = new List<string>();
            foreach (var Role in Guild.Roles)
            {
                if (Role != Guild.EveryoneRole)
                {
                    if (Role.Color.R == 0)
                    {
                        AppendText(TextGuildRoles, Role.Name + Environment.NewLine, System.Drawing.Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        AppendText(TextGuildRoles, Role.Name + Environment.NewLine, System.Drawing.Color.FromArgb(Role.Color.R, Role.Color.G, Role.Color.B));
                    }
                    AppendText(TextGuildRoles, Role.Id + Environment.NewLine + Environment.NewLine, System.Drawing.Color.FromArgb(255, 255, 255));
                }
            }
            List<string> EmojiList = new List<string>();
            foreach (var Emoji in Guild.Emojis)
            {
                EmojiList.Add(Emoji.Name);
            }
            TextGuildEmojis.Text = string.Join(Environment.NewLine, EmojiList.ToArray());
        }

        private void ChannelList_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEmbedColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                EmbedColor = new Discord.Color(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                BtnEmbedColor.ForeColor = colorDialog1.Color;
                
            }
            else
            {
                EmbedColor = new Discord.Color();
                BtnEmbedColor.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private async void BtnSendSelected_Click(object sender, EventArgs e)
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
            if (EmbedTitle.Text == LastEmbedTitle)
            {
                if (EmbedText.Text == LastEmbedText)
                {
                    MessageBox.Show("You already send this message");
                    return;
                }
            }
            LastEmbedTitle = EmbedTitle.Text;
            LastEmbedText = EmbedText.Text;
            var Guild = Program.client.GetGuild(SelectedGuild);
            var Chan = Guild.GetChannel(SelectChannel) as ITextChannel;
            var embed = new EmbedBuilder()
            {
                Title = EmbedTitle.Text,
                Description = EmbedText.Text,
                Color = EmbedColor,
                Footer = new EmbedFooterBuilder()
                {
                    Text = EmbedFooter.Text
                }
            };
            await Chan.SendMessageAsync("", false, embed);
        }

        private async void BtnSendActive_Click(object sender, EventArgs e)
        {
            if (BtnSendActive.Text == "Active")
            {
                if (Program.ActiveGuildID == 0)
                {
                    MessageBox.Show("No guild selected");
                    return;
                }
            }
            if (Program.ActiveChannelID == 0)
            {
                MessageBox.Show("No channel selected");
                return;
            }
            if (EmbedTitle.Text == LastEmbedTitle)
            {
                if (EmbedText.Text == LastEmbedText)
                {
                    MessageBox.Show("You already send this message");
                    return;
                }
            }
            LastEmbedTitle = EmbedTitle.Text;
            LastEmbedText = EmbedText.Text;
            var embed = new EmbedBuilder()
            {
                Title = EmbedTitle.Text,
                Description = EmbedText.Text,
                Color = EmbedColor,
                Footer = new EmbedFooterBuilder()
                {
                    Text = EmbedFooter.Text
                }
            };
            if (BtnSendActive.Text == "Active")
            {
                var Guild = Program.client.GetGuild(Program.ActiveGuildID);
                var GuildChan = Guild.GetChannel(Program.ActiveChannelID) as ITextChannel;
                await GuildChan.SendMessageAsync("", false, embed);
            }
            else
            {
                IDMChannel DMChan = Program.client.GetChannel(Program.ActiveChannelID) as IDMChannel;
                await DMChan.SendMessageAsync("", false, embed);
            }
        }

        private void HyperlinkGithub_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArchboxDev/Discore-Selfbot");
        }

        private void HyperlinkWebsite_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blaze.ml/");
            
        }

        private void HyperlinkGuild_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/WJTYdNb");
        }

        private void ViewBotsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "PixelBot")
            {
                TextBotInfo.Text = "A gamer featured bot with commands for steam/osu/minecraft and twitch streamer alerts";
                HyperlinkBotWebsite.AccessibleDescription = "https://blaze.ml";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=277933222015401985&scope=bot&permissions=0";
                HyperlinkBotWebsite.Visible = true;
                HyperlinkBotInvite.Visible = true;
            }
            if (e.Node.Name == "Minotaur")
            {
                TextBotInfo.Text = "A guild moderation bot with ban/kick/mute commands and advanced logging/userlogs/modlogs";
                HyperlinkBotWebsite.AccessibleDescription = "https://blaze.ml";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=281849383404830733&scope=bot&permissions=0";
                HyperlinkBotWebsite.Visible = true;
                HyperlinkBotInvite.Visible = true;
            }
            if (e.Node.Name == "Discord Cards")
            {
                TextBotInfo.Text = "Buy/Trade/Collect all of the rare cards featured around discord";
                HyperlinkBotWebsite.AccessibleDescription = "";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=275388037817696287&scope=bot";
                HyperlinkBotWebsite.Visible = false;
                HyperlinkBotInvite.Visible = true;
            }
            if (e.Node.Name == "Casino Bot")
            {
                TextBotInfo.Text = "Spin the wheel and get the JACKPOT!";
                HyperlinkBotWebsite.AccessibleDescription = "";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=263330369409908736&scope=bot&permissions=19456";
                HyperlinkBotWebsite.Visible = false;
                HyperlinkBotInvite.Visible = true;
            }
            if (e.Node.Name == "Discord RPG")
            {
                TextBotInfo.Text = "Who dosent love a good RPG bot?";
                HyperlinkBotWebsite.AccessibleDescription = "https://wiki.discorddungeons.me/Home";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=170915256833540097&scope=bot&permissions=0";
                HyperlinkBotWebsite.Visible = true;
                HyperlinkBotInvite.Visible = true;
            }
            if (e.Node.Name == "Sekoboto")
            {
                TextBotInfo.Text = "Currently down and also the website so i cannot add :P";
                HyperlinkBotWebsite.AccessibleDescription = "https://sekusuikuto.archbox.pro/";
                HyperlinkBotInvite.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=217215738753056768&scope=bot&permissions=1518657";
                HyperlinkBotWebsite.Visible = true;
                HyperlinkBotInvite.Visible = true;
            }
        }

        private void HyperlinkBotWebsite_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(HyperlinkBotWebsite.AccessibleDescription);
        }

        private void HyperlinkBotInvite_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(HyperlinkBotInvite.AccessibleDescription);
        }

        private void BtnCMEdit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SendAction = "Edit";
            Properties.Settings.Default.Save();
        }

        private void BtnCMDelete_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SendAction = "Delete";
            Properties.Settings.Default.Save();
        }

        private void BtnAFYes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoForm = "Yes";
            Properties.Settings.Default.Save();
        }

        private void BtnAFNo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoForm = "No";
            Properties.Settings.Default.Save();
        }

        private void BtnFavColor_Click(object sender, EventArgs e)
        {
            ColorDialog FavColorForm = OpenFavoriteColor;
            if (FavColorForm.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FavoriteColor = FavColorForm.Color;
                Program.FavoriteColor = new Discord.Color(FavColorForm.Color.R, FavColorForm.Color.G, FavColorForm.Color.B);
            }
            else
            {
                Properties.Settings.Default.FavoriteColor = System.Drawing.Color.Empty;
                Program.FavoriteColor = new Discord.Color();
            }
            Properties.Settings.Default.Save();
        }

        private void BtnAN1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auto nickname timer changed to 1 minute");
            Properties.Settings.Default.ANTimer = "1";
            Program.AutoNickname_Timer.Interval = 60000;
        }

        private void BtnAN5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auto nickname timer changed to 5 minute");
            Properties.Settings.Default.ANTimer = "5";
            Program.AutoNickname_Timer.Interval = 300000;
        }

        private void BtnAN10_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auto nickname timer changed to 10 minute");
            Properties.Settings.Default.ANTimer = "10";
            Program.AutoNickname_Timer.Interval = 600000;
        }
        public void AppendText(RichTextBox box, string text, System.Drawing.Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            //box.SelectionFont = font;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void ChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Selected Channel {ChannelList.SelectedText}");
            var Index = ChannelList.SelectedIndex;
            SelectChannel = Program.ChannelsID[Index];
            var Guild = Program.client.GetGuild(SelectedGuild);
            var Chan = Guild.GetChannel(SelectChannel) as ITextChannel;
            var User = Guild.GetUser(Program.CurrentUserID);
            if (User.GuildPermissions.EmbedLinks == true)
            {
                BtnSendSelected.Text = "Selected";
            }
            else
            {
                if (User.GetPermissions(Chan).EmbedLinks == true)
                {
                BtnSendSelected.Text = "Selected";
                }
                else
                {
                BtnSendSelected.Text = "Selected" + Environment.NewLine + "No perms";
                }
            }
        }
    }
}

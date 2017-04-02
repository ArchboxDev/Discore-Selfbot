using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Net;
using System.IO;
using Discord;
using System.Threading;

namespace Discore_Selfbot
{
    public partial class GUI : KryptonForm
    {
        public static Discord.Color EmbedColor;
        public bool EmbedFirstClick = false;
        public static ulong SelectedGuild = 0;
        public static ulong SelectedChannel = 0;
        public string LastEmbedTitle = "";
        public string LastEmbedText = "";
        public GUI()
        {
            InitializeComponent();
            this.BtnTopMin.Click += BtnTopMin_Click;
            this.BtnOnTop.Click += BtnOnTop_Click;
            this.NavInfo.SelectedPageChanged += NavInfo_SelectedPageChanged;
            this.kryptonContextMenuItem1.Click += KryptonContextMenuItem1_Click;
            this.kryptonContextMenuItem2.Click += KryptonContextMenuItem2_Click;
            this.kryptonContextMenuItem3.Click += KryptonContextMenuItem3_Click;
            this.kryptonContextMenuItem4.Click += KryptonContextMenuItem4_Click;
            
        }
        
        private void KryptonContextMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArchboxDev/Discore-Selfbot/blob/master/LICENSE");
        }

        private void KryptonContextMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/WJTYdNb");
        }

        private void KryptonContextMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArchboxDev/Discore-Selfbot");
        }

        private void KryptonContextMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blaze.ml/");
        }

        private void NavInfo_SelectedPageChanged(object sender, EventArgs e)
        {
           if (NavInfo.SelectedPage.Name == "NavCustomPage")
            {
                CustomCommandsList.Items.Clear();
                foreach (var File in Directory.GetFiles(Program.SelfbotDir + "Custom\\"))
                {
                    if (!File.Contains(".message"))
                    {
                        CustomCommandsList.Items.Add(File.Replace(Program.SelfbotDir + "Custom\\", "").Replace(".txt", ""));
                    }
                }
            }
        }

        private void BtnTopMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnOnTop_Click(object sender, EventArgs e)
        {
            if (BtnOnTop.Checked == ButtonCheckState.Unchecked)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
            if (Properties.Settings.Default.Theme == "Dark Sparkle")
            {
                ThemeManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            if (Program.Ready == false)
            {
                return;
            }
            WebClient WBC = new WebClient();
            Program.GuildIDs.Clear();
            foreach (var Guild in Program.client.Guilds)
            {
                Program.GuildIDs.Add(Guild.Id);
                if (Guild.IconUrl == null)
                {
                    var GuildNameFormat = new String(Guild.Name.Where(Char.IsLetter).ToArray());
                    using (Stream ImageStream = WBC.OpenRead("http://dev.blaze.ml/Letters/" + GuildNameFormat.ToCharArray()[0] + ".png"))
                    {
                        Bitmap Image = new Bitmap(ImageStream);
                        var Item = GuildList.Items.Add(Guild.Name, Image);
                        Item.AccessibleDescription = Guild.Id.ToString();
                        Item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                }
                else
                {
                    using (Stream ImageStream = WBC.OpenRead(Guild.IconUrl))
                    {
                        Bitmap Image = new Bitmap(ImageStream);
                        var Item = GuildList.Items.Add(Guild.Name, Image);
                        Item.AccessibleDescription = Guild.Id.ToString();
                        Item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                }
            }
            this.Text = Program.CurrentUserName;
            using (Stream ImageStream = WBC.OpenRead(Program.client.CurrentUser.GetAvatarUrl()))
            {
                Bitmap b = (Bitmap)System.Drawing.Image.FromStream(ImageStream);
                IntPtr pIcon = b.GetHicon();
                Icon i = Icon.FromHandle(pIcon);
                this.Icon = i;
            }
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

        private void GuildList_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            BtnSendSelected.Enabled = false;
            BtnSendSelected.Text = "Selected";
            Console.WriteLine($"Selected Guild {e.ClickedItem.ToolTipText}");
            Text = Program.client.CurrentUser.Username + " - " + e.ClickedItem.Text;
            var Guild = Program.client.GetGuild(Convert.ToUInt64(e.ClickedItem.AccessibleDescription));
            if (Guild == null)
            {
                Console.WriteLine("Unable to get guild");
                return;
            }
            TextGuildInfo.Text = $"ID: {Guild.Id}" + Environment.NewLine + $"Owner: {Guild.Owner.Username} - {Guild.Owner.Id}" + Environment.NewLine + $"Users: Online {Guild.Users.Where(x => !x.IsBot & x.Status != UserStatus.Offline).Count()}/{Guild.Users.Where(x => !x.IsBot & x.Status == UserStatus.Offline).Count()} Offline" + Environment.NewLine + $"Bots: Online {Guild.Users.Where(x => x.IsBot & x.Status != UserStatus.Offline).Count()}/{Guild.Users.Where(x => x.IsBot & x.Status == UserStatus.Offline).Count()} Offline" + Environment.NewLine + $"Roles: {Guild.Roles.Count - 1} Emojis: {Guild.Emojis.Count}" + Environment.NewLine + $"Created: {Guild.CreatedAt.Date.ToShortDateString()}";
            SelectedGuild = Convert.ToUInt64(e.ClickedItem.AccessibleDescription);
            ChannelList.Items.Clear();
            ChannelList.Visible = true;
            Program.ChannelsID.Clear();
            foreach (var Chan in Guild.TextChannels)
            {
                ChannelList.Items.Add($"{Chan.Name}");
                Program.ChannelsID.Add(Chan.Id);
            }
            ChannelList.Enabled = true;
            TextGuildRoles.Clear();
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

        private void ChannelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Selected Channel {ChannelList.SelectedItem}");
            int Index = ChannelList.SelectedIndex;
            SelectedChannel = Program.ChannelsID[Index];
            var Guild = Program.client.GetGuild(SelectedGuild);
            var Chan = Guild.GetChannel(SelectedChannel) as ITextChannel;
            var User = Guild.GetUser(Program.CurrentUserID);
            if (User.GuildPermissions.EmbedLinks || User.GetPermissions(Chan).EmbedLinks)
            {
                BtnSendSelected.Enabled = true;
                BtnSendSelected.Values.Text = "Selected" + Environment.NewLine + ChannelList.SelectedItem;
            }
            else
            {
                BtnSendSelected.Enabled = false;
                BtnSendSelected.Values.Text = "Selected" + Environment.NewLine + "No Perms";
            }
        }

        

        private async void BtnSendSelected_Click(object sender, EventArgs e)
        {
            if (SelectedGuild == 0)
            {
                MessageBox.Show("No guild selected");
                return;
            }
            if (SelectedChannel == 0)
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
            var Chan = Guild.GetChannel(SelectedChannel) as ITextChannel;
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
            
        }

        private void HyperlinkWebsite_LinkClicked(object sender, EventArgs e)
        {
            
        }

        private void HyperlinkGuild_LinkClicked(object sender, EventArgs e)
        {
            
        }

        private void LinkDownload_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discore.blaze.ml/");
        }

        private void BtnOpenSelfbotFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Program.SelfbotDir);
        }

        private void ViewCommandsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TextCommandInfo.Text = e.Node.ToolTipText;
        }

        private void BtnThemeDefault_Click(object sender, EventArgs e)
        {
            ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            Properties.Settings.Default.Theme = "Default";
            Properties.Settings.Default.Save();
        }

        private void BtnThemeDark_Click(object sender, EventArgs e)
        {
            ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            Properties.Settings.Default.Theme = "Default";
            Properties.Settings.Default.Save();
        }

        private void BtnThemeSparkle_Click(object sender, EventArgs e)
        {
            ThemeManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            Properties.Settings.Default.Theme = "Default";
            Properties.Settings.Default.Save();
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
                TextBotInfo.Text = "A cool bot with random and usefull commands it also her per guild/channel configs";
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
        
        private void CustomAddCustomAdd_LinkClicked(object sender, EventArgs e)
        {
                var Custom = new CustomCommand();
                Custom.Show();
        }

        private void CustomDelete_LinkClicked(object sender, EventArgs e)
        {
            if (CustomCommandsList.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected");
                return;
            }
            string Selected = CustomCommandsList.SelectedItem.ToString();
            File.Delete(Program.SelfbotDir + "Custom\\" + Selected + ".txt");
            File.Delete(Program.SelfbotDir + "Custom\\" + Selected + ".message.txt");
            CustomCommandsList.Items.RemoveAt(CustomCommandsList.SelectedIndex);
        }

        private void KryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            if (e.Color.IsEmpty)
            {
                BtnEmbedColor.StateNormal.Back.Color1 = e.Color;
                BtnEmbedColor.OverrideDefault.Back.Color1 = e.Color;
                EmbedColor = new Discord.Color();
            }
            else
            {
                BtnEmbedColor.StateNormal.Back.Color1 = e.Color;
                BtnEmbedColor.OverrideDefault.Back.Color1 = e.Color;
                EmbedColor = new Discord.Color(e.Color.R, e.Color.G, e.Color.B);
            }
        }

        private void BtnLogsAll_LinkClicked(object sender, EventArgs e)
        {

        }

        private void BtnLogsGuild_LinkClicked(object sender, EventArgs e)
        {

        }

        private void BtnLogsChannel_LinkClicked(object sender, EventArgs e)
        {

        }

        private void EmbedTitle_TextChanged(object sender, EventArgs e)
        {
            if (EmbedFirstClick == false)
            {
                EmbedFirstClick = true;
                EmbedTitle.Text = "";
                EmbedText.Text = "";
                EmbedFooter.Text = "";
            }
        }

        private void EmbedText_TextChanged(object sender, EventArgs e)
        {
            if (EmbedFirstClick == false)
            {
                EmbedFirstClick = true;
                EmbedTitle.Text = "";
                EmbedText.Text = "";
                EmbedFooter.Text = "";
            }
        }

        private void EmbedFooter_TextChanged(object sender, EventArgs e)
        {
            if (EmbedFirstClick == false)
            {
                EmbedFirstClick = true;
                EmbedTitle.Text = "";
                EmbedText.Text = "";
                EmbedFooter.Text = "";
            }
        }

        private void BtnHideConsoleYes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HideConsole = "Yes";
            Properties.Settings.Default.Save();
        }

        private void BtnHideConsoleNo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HideConsole = "No";
            Properties.Settings.Default.Save();
        }
    }
}

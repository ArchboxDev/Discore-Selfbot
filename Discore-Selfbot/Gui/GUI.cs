using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Net;
using System.IO;
using Discord;

namespace Discore_Selfbot
{
    public partial class GUI_Form : KryptonForm
    {
        public static Discord.Color EmbedColor;
        public bool EmbedFirstClick = false;
        public static ulong SelectedGuild = 0;
        public string LastEmbedTitle = "";
        public string LastEmbedText = "";
        public static EmbedPopup FormEmbedPopup = null;
        public static bool Ready = false;
        public GUI_Form()
        {
            InitializeComponent();
            this.GUI_Minimize.Click += BtnTopMin_Click;
            this.GUI_OnTop.Click += BtnOnTop_Click;
            this.GUI_Right.SelectedPageChanged += NavInfo_SelectedPageChanged;
            this.GUI_LinkWebsite.Click += LinkWebsite_Click;
            this.GUI_LinkGithub.Click += LinkGithub_Click;
            this.GUI_LinkMyGuild.Click += LinkMyGuild_Click;
        }
        public string ActiveGuild = "Guild";
        public string ActiveChannel = "Channel";
        public ulong ActiveGuildID = 0;
        public ulong ActiveChannelID = 0;
        public void SetActive(string Guild, ulong GuildID, string Channel, ulong ChannelID)
        {
            ActiveGuild = Guild; ActiveGuildID = GuildID; ActiveChannel = Channel; ActiveChannelID = ChannelID;
            Active_Guild.Text = ActiveGuild;
            Active_Channel.Text = ActiveChannel;
            if (GuildID == 1)
            {
                Embed_SendActive.Text = "DM";
                Embed_SendActive.Enabled = true;
            } else if (GuildID == 2)
            {
                Embed_SendActive.Text = "No Perms";
                Embed_SendActive.Enabled = false;
            } else
            {
                Embed_SendActive.Text = "Active Guild";
                Embed_SendActive.Enabled = true;
            }
            
            if (FormEmbedPopup != null)
            {
                FormEmbedPopup.ActiveGuild.Text = Guild;
                FormEmbedPopup.ActiveChannel.Text = Channel;
            }
        }


        private void LinkMyGuild_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/WJTYdNb");
        }

        private void LinkGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArchboxDev/Discore-Selfbot");
        }

        private void LinkWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blaze.ml/");
        }

        private void NavInfo_SelectedPageChanged(object sender, EventArgs e)
        {
           if (GUI_Right.SelectedPage.Name == "NavCustomPage")
            {
                GUI_CCList.Items.Clear();
                foreach (var File in Directory.GetFiles(Program._Bot.PathCustom))
                {
                    if (!File.Contains(".message"))
                    {
                        GUI_CCList.Items.Add(File.Replace(Program._Bot.PathCustom, "").Replace(".txt", ""));
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
            if (GUI_OnTop.Checked == ButtonCheckState.Unchecked)
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
            Ready = false;
            
            Microsoft.Win32.RegistryKey rkApp = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (rkApp.GetValue("Discore-Selfbot") != null)
            {
                Setting_WindowsStartup.SelectedItem = "Yes";
            }
            else
            {
                Setting_WindowsStartup.SelectedItem = "No";
            }
            
            Setting_CommandAction.SelectedItem = Program.Settings.MessageAction;
            Settings_Startup.SelectedItem = Program.Settings.Startup;
            Setting_ForceRoleColor.SelectedItem = Program.Settings.ForceRoleColor;
            GUI_FavColor.StateNormal.Back.Color1 = Program.Settings.FavColor;
            GUI_FavColor.OverrideDefault.Back.Color1 = Program.Settings.FavColor;
            if (Program.Settings.Theme == "Dark")
            {
                GUI_ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
            if (Program.Settings.Theme == "Dark Sparkle")
            {
                GUI_ThemeManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            
            if (Program._Bot.Ready == false)
            {
                return;
            }
            Active_Guild.Text = ActiveGuild;
            Active_Channel.Text = ActiveChannel;
            
            
            WebClient WBC = new WebClient();
            
            Program._GUI.GuildIDCache.Clear();
            foreach (var Guild in Program._Client.Guilds)
            {
                Program._GUI.GuildIDCache.Add(Guild.Id);
                if (Guild.IconUrl == null)
                {
                    var GuildNameFormat = new String(Guild.Name.Where(Char.IsLetter).ToArray());
                    using (Stream ImageStream = WBC.OpenRead("http://dev.blaze.ml/Letters/" + GuildNameFormat.ToCharArray()[0] + ".png"))
                    {
                        Bitmap Image = new Bitmap(ImageStream);
                        ToolStripButton GuildButton = new ToolStripButton(Guild.Name, Image)
                        {
                            AccessibleDescription = Guild.Id.ToString(),
                            DisplayStyle = ToolStripItemDisplayStyle.Image
                        };
                        if (Guild.OwnerId == Program._Client.CurrentUser.Id)
                        {
                            using (Graphics Grap = Graphics.FromImage(Image))
                            {
                                Grap.DrawRectangle(new Pen(Brushes.Gold, 10), new Rectangle(0, 0, Image.Width, Image.Height));
                            }
                            GuildButton.Image = Image;
                            Guilds_Bar.Items.Insert(0, (GuildButton));
                        }
                        else
                        {
                            Guilds_Bar.Items.Add(GuildButton);
                        }
                    }
                }
                else
                {
                    using (Stream ImageStream = WBC.OpenRead(Guild.IconUrl))
                    {
                        Bitmap Image = new Bitmap(ImageStream);
                        ToolStripButton GuildButton = new ToolStripButton(Guild.Name, Image)
                        {
                            AccessibleDescription = Guild.Id.ToString(),
                            DisplayStyle = ToolStripItemDisplayStyle.Image
                        };
                        if (Guild.OwnerId == Program._Client.CurrentUser.Id)
                        {
                            using (Graphics Grap = Graphics.FromImage(Image))
                            {
                                Grap.DrawRectangle(new Pen(Brushes.Gold, 10), new Rectangle(0, 0, Image.Width, Image.Height));
                            }
                            GuildButton.Image = Image;
                            Guilds_Bar.Items.Insert(0, (GuildButton));
                        }
                        else
                        {
                            Guilds_Bar.Items.Add(GuildButton);
                        }
                    }
                }
            }
            this.Text = Program._Client.CurrentUser.Username;
            using (Stream ImageStream = WBC.OpenRead(Program._Client.CurrentUser.GetAvatarUrl()))
            {
                Bitmap b = (Bitmap)System.Drawing.Image.FromStream(ImageStream);
                IntPtr pIcon = b.GetHicon();
                Icon i = Icon.FromHandle(pIcon);
                this.Icon = i;
            }
            
            Ready = true;
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
            foreach(ToolStripButton ToolButton in Guilds_Bar.Items)
            {
                ToolButton.Checked = false;
            }
            ToolStripButton TSB = e.ClickedItem as ToolStripButton;
            TSB.Checked = true;
            Console.WriteLine($"Selected Guild {e.ClickedItem.ToolTipText}");
            Text = Program._Client.CurrentUser.Username + " - " + e.ClickedItem.Text;
            var Guild = Program._Client.GetGuild(Convert.ToUInt64(e.ClickedItem.AccessibleDescription));
            if (Guild == null)
            {
                Console.WriteLine("Unable to get guild");
                return;
            }
            GUI_GuildInfo.Text = $"ID: {Guild.Id}" + Environment.NewLine + $"Owner: {Guild.Owner.Username} - {Guild.Owner.Id}" + Environment.NewLine + $"Users: Online {Guild.Users.Where(x => !x.IsBot & x.Status != UserStatus.Offline).Count()}/{Guild.Users.Where(x => !x.IsBot & x.Status == UserStatus.Offline).Count()} Offline" + Environment.NewLine + $"Bots: Online {Guild.Users.Where(x => x.IsBot & x.Status != UserStatus.Offline).Count()}/{Guild.Users.Where(x => x.IsBot & x.Status == UserStatus.Offline).Count()} Offline" + Environment.NewLine + $"Roles: {Guild.Roles.Count - 1} Emojis: {Guild.Emotes.Count}" + Environment.NewLine + $"Created: {Guild.CreatedAt.Date.ToShortDateString()}";
            SelectedGuild = Convert.ToUInt64(e.ClickedItem.AccessibleDescription);
            
            GUI_GuildRoles.Clear();
            foreach (var Chan in Guild.TextChannels)
            {
                GuildInfo_ChannelsBox.AppendText($"{Chan.Name} - {Chan.Id}" + Environment.NewLine);
            }
            foreach (var Role in Guild.Roles)
            {
                if (Role != Guild.EveryoneRole)
                {
                    if (Role.Color.R == 0)
                    {
                        AppendText(GUI_GuildRoles, Role.Name + Environment.NewLine, System.Drawing.Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        AppendText(GUI_GuildRoles, Role.Name + Environment.NewLine, System.Drawing.Color.FromArgb(Role.Color.R, Role.Color.G, Role.Color.B));
                    }
                    AppendText(GUI_GuildRoles, Role.Id + Environment.NewLine + Environment.NewLine, System.Drawing.Color.FromArgb(255, 255, 255));
                }
            }
            List<string> EmojiList = new List<string>();
            foreach (var Emoji in Guild.Emotes)
            {
                EmojiList.Add(Emoji.Name);
            }
            GUI_GuildEmojis.Text = string.Join(Environment.NewLine, EmojiList.ToArray());
            GuildInfo_BarText.Text = e.ClickedItem.ToolTipText;
            GuildInfo_BarImage.Image = e.ClickedItem.Image;
        }

        private async void BtnSendActive_Click(object sender, EventArgs e)
        {
            if (Embed_SendActive.Text == "Active")
            {
                if (this.ActiveGuildID == 0)
                {
                    MessageBox.Show("No active guild");
                    return;
                }
            }
            if (this.ActiveChannelID == 0)
            {
                MessageBox.Show("No active channel");
                return;
            }
            if (Embed_SetTitle.Text == LastEmbedTitle)
            {
                if (Embed_SetText.Text == LastEmbedText)
                {
                    MessageBox.Show("You already send this message");
                    return;
                }
            }
            LastEmbedTitle = Embed_SetTitle.Text;
            LastEmbedText = Embed_SetText.Text;
            var embed = new EmbedBuilder()
            {
                Title = Embed_SetTitle.Text,
                Description = Embed_SetText.Text,
                Color = EmbedColor,
                Footer = new EmbedFooterBuilder()
                {
                    Text = Embed_SetFooter.Text
                }
            };
            if (Active_Guild.Text != "DM" & !Active_Channel.Text.Contains("@"))
            {
                var Guild = Program._Client.GetGuild(this.ActiveGuildID);
                var GuildChan = Guild.GetChannel(this.ActiveChannelID) as ITextChannel;
                await GuildChan.SendMessageAsync("", false, embed);
            }
            else
            {
                IDMChannel DMChan = Program._Client.GetChannel(this.ActiveChannelID) as IDMChannel;
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
            System.Diagnostics.Process.Start(Program._Bot.Path);
        }

        private void ViewCommandsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GUI_CommandsInfo.Text = e.Node.ToolTipText;
        }

        private void BtnThemeDefault_Click(object sender, EventArgs e)
        {
            GUI_ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            Program.Settings.Theme = "Default";
            Program.SaveSettings();
        }

        private void BtnThemeDark_Click(object sender, EventArgs e)
        {
            GUI_ThemeManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            Program.Settings.Theme = "Dark";
            Program.SaveSettings();
        }

        private void BtnThemeSparkle_Click(object sender, EventArgs e)
        {
            GUI_ThemeManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            Program.Settings.Theme = "Dark Sparkle";
            Program.SaveSettings();
        }

        private void BtnCMEdit_Click(object sender, EventArgs e)
        {
            Program.Settings.MessageAction = "Edit";
            Program.SaveSettings();
        }

        private void BtnCMDelete_Click(object sender, EventArgs e)
        {
            Program.Settings.MessageAction = "Delete";
            Program.SaveSettings();
        }

        private void BtnAFYes_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnAFNo_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnFavColor_Click(object sender, EventArgs e)
        {

        }

        private void ViewBotsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "PixelBot")
            {
                GUI_BotsInfo.Text = "A gamer featured bot with commands for steam/osu/minecraft and twitch streamer alerts";
                GUI_BotsWebLink.AccessibleDescription = "https://blaze.ml";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=277933222015401985&scope=bot&permissions=0";
                GUI_BotsWebLink.Visible = true;
                GUI_BotsInviteLink.Visible = true;
            }
            if (e.Node.Name == "Minotaur")
            {
                GUI_BotsInfo.Text = "A guild moderation bot with ban/kick/mute commands and advanced logging/userlogs/modlogs";
                GUI_BotsWebLink.AccessibleDescription = "https://blaze.ml";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=281849383404830733&scope=bot&permissions=0";
                GUI_BotsWebLink.Visible = true;
                GUI_BotsInviteLink.Visible = true;
            }
            if (e.Node.Name == "Discord Cards")
            {
                GUI_BotsInfo.Text = "Buy/Trade/Collect all of the rare cards featured around discord";
                GUI_BotsWebLink.AccessibleDescription = "";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=275388037817696287&scope=bot";
                GUI_BotsWebLink.Visible = false;
                GUI_BotsInviteLink.Visible = true;
            }
            if (e.Node.Name == "Casino Bot")
            {
                GUI_BotsInfo.Text = "Spin the wheel and get the JACKPOT!";
                GUI_BotsWebLink.AccessibleDescription = "";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=263330369409908736&scope=bot&permissions=19456";
                GUI_BotsWebLink.Visible = false;
                GUI_BotsInviteLink.Visible = true;
            }
            if (e.Node.Name == "Discord RPG")
            {
                GUI_BotsInfo.Text = "Who dosent love a good RPG bot?";
                GUI_BotsWebLink.AccessibleDescription = "https://wiki.discorddungeons.me/Home";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?&client_id=170915256833540097&scope=bot&permissions=0";
                GUI_BotsWebLink.Visible = true;
                GUI_BotsInviteLink.Visible = true;
            }
            if (e.Node.Name == "Sekoboto")
            {
                GUI_BotsInfo.Text = "A cool bot with random and usefull commands it also her per guild/channel configs";
                GUI_BotsWebLink.AccessibleDescription = "https://sekusuikuto.archbox.pro/";
                GUI_BotsInviteLink.AccessibleDescription = "https://discordapp.com/oauth2/authorize?client_id=217215738753056768&scope=bot&permissions=1518657";
                GUI_BotsWebLink.Visible = true;
                GUI_BotsInviteLink.Visible = true;
            }
        }

        private void HyperlinkBotWebsite_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GUI_BotsWebLink.AccessibleDescription);
        }

        private void HyperlinkBotInvite_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GUI_BotsInviteLink.AccessibleDescription);
        }
        
        private void CustomAddCustomAdd_LinkClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Custom commands disabled > Under construction");
            //var Custom = new CustomCommand();
                //Custom.Show();
        }

        private void CustomDelete_LinkClicked(object sender, EventArgs e)
        {
            if (GUI_CCList.SelectedIndex == -1)
            {
                MessageBox.Show("Custom commands disabled > Under construction");
                return;
                //MessageBox.Show("No item selected");
                //return;
            }
            string Selected = GUI_CCList.SelectedItem.ToString();
            File.Delete(Program._Bot.PathCustom + Selected + ".txt");
            File.Delete(Program._Bot.PathCustom + Selected + ".message.txt");
            GUI_CCList.Items.RemoveAt(GUI_CCList.SelectedIndex);
        }

        private void KryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            
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
                Embed_SetTitle.Text = "";
                Embed_SetText.Text = "";
                Embed_SetFooter.Text = "";
            }
        }

        private void EmbedText_TextChanged(object sender, EventArgs e)
        {
            if (EmbedFirstClick == false)
            {
                EmbedFirstClick = true;
                Embed_SetTitle.Text = "";
                Embed_SetText.Text = "";
                Embed_SetFooter.Text = "";
            }
        }

        private void EmbedFooter_TextChanged(object sender, EventArgs e)
        {
            if (EmbedFirstClick == false)
            {
                EmbedFirstClick = true;
                Embed_SetTitle.Text = "";
                Embed_SetText.Text = "";
                Embed_SetFooter.Text = "";
            }
        }

        private void BtnHideConsoleYes_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnHideConsoleNo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnFavColor_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            if (e.Color.IsEmpty)
            {
                GUI_FavColor.StateNormal.Back.Color1 = e.Color;
                GUI_FavColor.OverrideDefault.Back.Color1 = e.Color;
                Program.Settings.FavColor = System.Drawing.Color.Empty;
                    Program._Bot.FavoriteColor = new Discord.Color();
            }
            else
            {
                GUI_FavColor.StateNormal.Back.Color1 = e.Color;
                GUI_FavColor.OverrideDefault.Back.Color1 = e.Color;
                Program.Settings.FavColor = e.Color;
                    Program._Bot.FavoriteColor = new Discord.Color(e.Color.R, e.Color.G, e.Color.B);
            }
            Program.SaveSettings();
        }

        private void BtnRoleColorYes_Click(object sender, EventArgs e)
        {
            Program.Settings.ForceRoleColor = "Yes";
            Program.SaveSettings();
        }

        private void BtnRoleColorNo_Click(object sender, EventArgs e)
        {
            Program.Settings.ForceRoleColor = "No";
            Program.SaveSettings();
        }

        private void EmbedPaint_Click(object sender, EventArgs e)
        {
            
        }

        private void EmbedClear_Click(object sender, EventArgs e)
        {
            
        }

        private void EmbedPopup_Click(object sender, EventArgs e)
        {
            
        }

        private void ActiveGuildName_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void Embed_OpenColor_Click(object sender, EventArgs e)
        {
            Embed_ColorMenu.PerformDropDown();
        }

        private void Embed_Clear_Click(object sender, EventArgs e)
        {
            EmbedFirstClick = true;
            Embed_SetTitle.Text = "";
            Embed_SetText.Text = "";
            Embed_SetFooter.Text = "";
        }

        private void Embed_Popup_Click(object sender, EventArgs e)
        {
            FormEmbedPopup = new EmbedPopup();
            FormEmbedPopup.ShowDialog();
            FormEmbedPopup.ActiveGuild.Text = this.ActiveGuild;
            FormEmbedPopup.ActiveChannel.Text = this.ActiveChannel;
        }

        private void Embed_ColorMenu_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            if (e.Color.IsEmpty)
            {
                Embed_ColorStrip.BackColor = new System.Drawing.Color();
                EmbedColor = new Discord.Color();
            }
            else
            {
                Embed_ColorStrip.BackColor = e.Color;
                EmbedColor = new Discord.Color(e.Color.R, e.Color.G, e.Color.B);
            }
        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            Program._GUI.Form = null;
        }

        private void Settings_Startup_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (Ready == true)
            {
                Program.Settings.Startup = Settings_Startup.SelectedItem.ToString();
                Program.SaveSettings();
            }
        }

        private void Setting_WindowsStartup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ready == true)
            {
                if (Setting_WindowsStartup.SelectedText == "Yes")
                {
                    try
                    {
                        Microsoft.Win32.RegistryKey RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                        string DiscorePath = Environment.GetFolderPath(Environment.SpecialFolder.Programs) + @"\Blaze\Discore.appref-ms";
                        RegKey.SetValue("Discore-Selfbot", DiscorePath);
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        Microsoft.Win32.RegistryKey RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                        RegKey.DeleteValue("Discore-Selfbot");
                    }
                    catch { }
                }
            }
        }

        private void Setting_CommandAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ready == true)
            {
                Program.Settings.MessageAction = Setting_CommandAction.SelectedItem.ToString();
                Program.SaveSettings();
            }
        }

        private void Setting_ForceRoleColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ready == true)
            {
                Program.Settings.ForceRoleColor = Setting_ForceRoleColor.SelectedItem.ToString();
                Program.SaveSettings();
            }
        }

        private void GUI_NavSettingsPage_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
using Discord;

namespace Discore_Selfbot
{
    public partial class EmbedPopup : KryptonForm
    {
        public static Discord.Color EmbedColor;
        public string LastEmbedTitle;
        public string LastEmbedText;
        public EmbedPopup()
        {
            InitializeComponent();
        }

        private void EmbedPaint_Click(object sender, EventArgs e)
        {
            BtnEmbedColor.PerformDropDown();
        }

        private void EmbedClear_Click(object sender, EventArgs e)
        {
            EmbedTitle.Text = "";
            EmbedText.Text = "";
            EmbedFooter.Text = "";
        }

        private void BtnEmbedColor_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            if (e.Color.IsEmpty)
            {
                EmbedColorStrip.BackColor = new System.Drawing.Color();
                EmbedColor = new Discord.Color();
            }
            else
            {
                EmbedColorStrip.BackColor = e.Color;
                EmbedColor = new Discord.Color(e.Color.R, e.Color.G, e.Color.B);
            }
        }

        private async void EmbedSend_Click(object sender, EventArgs e)
        {
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
            if (Program._GUI.Form.ActiveGuildID == 1)
            {
                IDMChannel DMChan = Program._Client.GetChannel(Program._GUI.Form.ActiveChannelID) as IDMChannel ?? null;
                if (DMChan == null)
                {
                    MessageBox.Show(this, "Could not find DM channel", "Error");
                    return;
                }
                    await DMChan.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                var Guild = Program._Client.GetGuild(Program._GUI.Form.ActiveGuildID) ?? null;
                if (Guild == null)
                {
                    MessageBox.Show(this, "Could not find guild", "Error");
                    return;
                }
                var GuildChan = Guild.GetChannel(Program._GUI.Form.ActiveChannelID) as ITextChannel ?? null;
                if (GuildChan == null)
                {
                    MessageBox.Show(this, "Could not find guild channel", "Error");
                    return;
                }
                await GuildChan.SendMessageAsync("", false, embed.Build());
            }
        }

        private void EmbedPopup_Load(object sender, EventArgs e)
        {

        }
    }
}

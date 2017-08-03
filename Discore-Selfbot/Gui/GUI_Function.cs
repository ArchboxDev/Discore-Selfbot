using Discore_Selfbot;
using System.Drawing;
using Discord;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace Discore_Selfbot
{
    public class _GUI
    {
        public GUI_Form Form = null;
        public Icon Avatar;
        public List<ulong> GuildIDCache = new List<ulong>();
        public WebClient GuildIconDownload = new WebClient();
        public void Open()
        {
            GUI_Form.CheckForIllegalCrossThreadCalls = false;
            _Log.GUI("Opening main GUI");
            Thread mThread = new Thread(delegate ()
            {
                Form = new GUI_Form();
                Form.ShowDialog();
            });

            mThread.SetApartmentState(ApartmentState.STA);

            mThread.Start();
        }
        public Bitmap DownloadIcon(IGuild Guild)
        {
            Bitmap Icon;
                string IconUrl = "";
                if (Guild.IconUrl == null)
                {
                    var GuildNameFormat = new String(Guild.Name.Where(Char.IsLetter).ToArray());
                    IconUrl = "http://dev.blaze.ml/Letters/" + GuildNameFormat.ToUpper().ToCharArray()[0] + ".png";
                    
                }
                else
                {
                    IconUrl = Guild.IconUrl; 
                }
                using (Stream ImageStream = GuildIconDownload.OpenRead(IconUrl))
                {
                    Bitmap Image = new Bitmap(ImageStream);
                    if (Guild.OwnerId == Program._Client.CurrentUser.Id)
                    {
                        using (Graphics Grap = Graphics.FromImage(Image))
                        {
                            Grap.DrawRectangle(new Pen(Brushes.Gold, 10), new Rectangle(0, 0, Image.Width, Image.Height));
                        }
                    }
                    Icon = Image;
                }
            return Icon;
        }

        public void AddGuild(IGuild Guild)
        {
            if (!GuildIDCache.Contains(Guild.Id))
            {
                GuildIDCache.Add(Guild.Id);
                if (Form.Guilds_Loading.Value != Program._Client.Guilds.Count)
                {
                    Form.Guilds_Loading.Maximum = Program._Client.Guilds.Count;
                    Form.Guilds_Loading.Value++;
                }
                ToolStrip GuildList = Form.Guilds_Bar;
                Bitmap Icon = DownloadIcon(Guild);

                ToolStripButton GuildButton = new ToolStripButton(Guild.Name, Icon)
                {
                    AccessibleDescription = Guild.Id.ToString(),
                    DisplayStyle = ToolStripItemDisplayStyle.Image
                };
                if (Guild.OwnerId == Program._Client.CurrentUser.Id)
                {
                    GuildList.Items.Insert(0, (GuildButton));
                    GuildIDCache.Remove(Guild.Id);
                    GuildIDCache.Insert(0, Guild.Id);
                }
                else
                {
                    GuildList.Items.Add(GuildButton);

                }
            }
        }
        public void RemoveGuild(IGuild Guild)
        {
            if (Form.Guilds_Loading.Value != 0)
            {
                Form.Guilds_Loading.Value--;
                Form.Guilds_Loading.Maximum = Program._Client.Guilds.Count;
            }
            ulong ID = 0;
            foreach (var GuildCache in GuildIDCache)
            {
                bool Found = false;
                foreach (var GuildFound in Program._Client.Guilds)
                {
                    if (GuildFound.Id == GuildCache)
                    {
                        Found = true;
                    }
                }
                if (Found == false)
                {
                    ID = GuildCache;
                }
            }
            if (ID != 0)
            {
                int Index = GuildIDCache.IndexOf(Guild.Id);
                Form.Guilds_Bar.Items.RemoveAt(Index);
                GuildIDCache.Remove(Guild.Id);
            }
        }
    }
}

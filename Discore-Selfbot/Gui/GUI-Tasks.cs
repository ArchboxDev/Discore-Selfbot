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

public class _GUI
{
    public GUI_Form Form;
    public Icon Avatar;
    public List<ulong> GuildIDCache = new List<ulong>();
    public WebClient GuildIconDownload = new WebClient();
    public Task ThisTask;
    public bool FirstForm;
    public void Open()
    {
        GUI_Form.CheckForIllegalCrossThreadCalls = false;
        Form = new GUI_Form();
        //ThisTask = Task.Run(() =>
        //{
            if (Program.Settings.Startup != "Show GUI And Console" & Program._Bot.Ready == false)
            {
                return;
            }
            Console.WriteLine("Opening GUI");
            Form.ShowDialog();
        //});
        
    }
    
    public void AddGuild(IGuild Guild)
    {
        if (!GuildIDCache.Contains(Guild.Id))
        {
                GuildIDCache.Add(Guild.Id);
                if (Form.Guilds_Loading.Value != Program._Client.Guilds.Count)
                {
                    if (Form.Handle != null)
                    {
                        Form.Guilds_Loading.Maximum = Program._Client.Guilds.Count;
                        Form.Guilds_Loading.Value++;
                    }
                }
                ToolStrip GuildList = Form.Guilds_Bar;
                if (Guild.IconUrl == null)
                {
                    var GuildNameFormat = new String(Guild.Name.Where(Char.IsLetter).ToArray());
                    using (Stream ImageStream = GuildIconDownload.OpenRead("http://dev.blaze.ml/Letters/" + GuildNameFormat.ToUpper().ToCharArray()[0] + ".png"))
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
                            GuildList.Items.Insert(0, (GuildButton));
                            GuildIDCache.Remove(Guild.Id);
                            GuildIDCache.Insert(0, Guild.Id);
                        }
                        else
                        {
                            if (Form.Handle != null)
                            {
                                GuildList.Items.Add(GuildButton);
                            }
                        }
                    }
                }
                else
                {
                    using (Stream ImageStream = GuildIconDownload.OpenRead(Guild.IconUrl))
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
                            GuildList.Items.Insert(0, (GuildButton));
                            GuildIDCache.Remove(Guild.Id);
                            GuildIDCache.Insert(0, Guild.Id);
                        }
                        else
                        {
                            if (Form.Handle != null)
                            {
                                GuildList.Items.Add(GuildButton);
                            }
                        }
                    }
                
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
            foreach(var GuildFound in Program._Client.Guilds)
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
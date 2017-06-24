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
    public static GUI_Form MyGUI;
    public static Icon Avatar;
    public static List<ulong> GuildIDCache = new List<ulong>();
    public static WebClient GuildIconDownload = new WebClient();
    public static Task ThisTask;
    public static bool FirstForm;
    public static void Open()
    {
        GUI_Form.CheckForIllegalCrossThreadCalls = false;
        _GUI.MyGUI = new GUI_Form();
        ThisTask = Task.Run(() =>
        {
            if (Discore_Selfbot.Properties.Settings.Default.AutoForm == "No" & Program._Bot.Ready == false)
            {
                return;
            }
            Console.WriteLine("Opening GUI");
            _GUI.MyGUI.ShowDialog();
        });
        
    }
    public static void AddGuild(IGuild Guild)
    {
        if (!GuildIDCache.Contains(Guild.Id))
        {
                GuildIDCache.Add(Guild.Id);
                if (MyGUI.Guilds_Loading.Value != Program._Client.Guilds.Count)
                {
                    if (MyGUI.Handle != null)
                    {
                        MyGUI.Guilds_Loading.Maximum = Program._Client.Guilds.Count;
                        MyGUI.Guilds_Loading.Value++;
                    }
                }
                ToolStrip GuildList = MyGUI.Guilds_Bar;
                if (Guild.IconUrl == null)
                {
                    var GuildNameFormat = new String(Guild.Name.Where(Char.IsLetter).ToArray());
                    using (Stream ImageStream = GuildIconDownload.OpenRead("http://dev.blaze.ml/Letters/" + GuildNameFormat.ToUpper().ToCharArray()[0] + ".png"))
                    {
                        Bitmap Image = new Bitmap(ImageStream);
                        ToolStripButton GuildButton = new ToolStripButton(Guild.Name, Image);
                        GuildButton.AccessibleDescription = Guild.Id.ToString();
                        GuildButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
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
                            if (MyGUI.Handle != null)
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
                        ToolStripButton GuildButton = new ToolStripButton(Guild.Name, Image);
                        GuildButton.AccessibleDescription = Guild.Id.ToString();
                        GuildButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
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
                            if (MyGUI.Handle != null)
                            {
                                GuildList.Items.Add(GuildButton);
                            }
                        }
                    }
                
            }
        }
    }
    public static void RemoveGuild(IGuild Guild)
    {
        if (MyGUI.Guilds_Loading.Value != 0)
        {
            MyGUI.Guilds_Loading.Value--;
            MyGUI.Guilds_Loading.Maximum = Program._Client.Guilds.Count;
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
            _GUI.MyGUI.Guilds_Bar.Items.RemoveAt(Index);
            GuildIDCache.Remove(Guild.Id);
        }
    }
}
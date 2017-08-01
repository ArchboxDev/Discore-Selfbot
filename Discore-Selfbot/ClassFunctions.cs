using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discore_Selfbot
{
    public class _TagClass
    {
        public string TagName { get; set; }
        public string Url { get; set; }
        public ulong GuildID { get; set; }
        public ulong ChannelID { get; set; }
        public string UserName { get; set; }
        public ulong UserID { get; set; }
        public string UserIcon { get; set; }
        public string Message { get; set; }
        public string Thumbnail { get; set; }
        public string MainImage { get; set; }
        public Discord.Color Color { get; set; }
    }
    public class _BotClass
    {
        public string Token = "";
        public bool Ready = false;
        public string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\";
        public string FileSettings = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\" + "Settings.json";
        public string PathTags = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
        public string PathCustom = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Custom\\";
        public int Uptime = 0;
        public DateTime StartupTime;
        public Discord.Color FavoriteColor = new Discord.Color();
    }

    public class _StatsClass
    {
        public int TotalUptime = 0;
        public int TotalRuns = 0;
        public int CommandsUsed = 0;
    }
    public class _SettingsClass
    {
        public string MessageAction = "Edit";
        public System.Drawing.Color FavColor = new System.Drawing.Color();
        public string Theme = "Default";
        public string Startup = "Show GUI And Console";
        public string ForceRoleColor = "No";
    }
}

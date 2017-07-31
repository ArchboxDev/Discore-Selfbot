using Discord;
using Discord.Commands;
using Discord.Net.Providers.WS4Net;
using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace Discore_Selfbot
{
    public class Program
    {
        
        private CommandService _Commands;
        public static DiscordSocketClient _Client;

        public static Random RandomGenerator = new Random();
        
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
        public static List<_TagClass> TagList = new List<_TagClass>();
        public static List<IMessage> ErrorMessages = new List<IMessage>();
        public static _GUI _GUI = new _GUI();
        public static NotifyIcon NotifyIcon;
        public static _BotClass _Bot = new _BotClass();
        public System.Timers.Timer UptimeTimer = new System.Timers.Timer();
        WebClient AvatarIconDownload = new WebClient();
        public static _StatsClass Stats = new _StatsClass();
        public static _SettingsClass Settings = new _SettingsClass();
        [STAThread]
        static void Main()
        {
            _Bot.StartupTime = DateTime.Now;
            DisableConsoleQuickEdit.Go();
#region CreateFolders
            if (!Directory.Exists(_Bot.Path))
            {
                Directory.CreateDirectory(_Bot.Path);
            }
            if (!Directory.Exists(_Bot.Path))
            {
                Directory.CreateDirectory(_Bot.PathTags);
            }
            if (!Directory.Exists(_Bot.Path))
            {
                Directory.CreateDirectory(_Bot.PathCustom);
            }
            #endregion
            JsonSerializer serializer = new JsonSerializer();
            TrayIconBuster.TrayIconBuster.RemovePhantomIcons();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Discore - Selfbot";
            Notif();

            foreach (var Files in Directory.GetFiles(_Bot.PathTags))
            {
                if (Files.ToString().EndsWith(".json"))
                {
                    using (StreamReader reader = new StreamReader(Files))
                    { TagList.Add((_TagClass)serializer.Deserialize(reader, typeof(_TagClass))); }
                }
            }
            #region LoadToken
            if (File.Exists(_Bot.Path + "Token.txt"))
            {
                _Bot.Token = File.ReadAllText(_Bot.Path + "Token.txt");
                if (_Bot.Token == "")
                {
                    Console.Title = "Discore - Selfbot - User Token Required";
                    Console.WriteLine("Token not found please enter your user token in this file and restart the bot");
                    Process.Start(_Bot.Path);
                }
            }
            else
            {
                Console.Title = "Discore - Selfbot - User Token Required";
                File.CreateText(_Bot.Path + "Token.txt").Close();
                Console.WriteLine("Insert your User Token into the file Token.txt and restart the bot");
                Console.WriteLine("And no i dont steal tokens you can view the code on github");
                Process.Start(_Bot.Path);
            }
            if (!File.Exists(_Bot.Path + "How-To-Get-User-Token.txt"))
            {
                using (StreamWriter sw = File.CreateText(_Bot.Path + "How-To-Get-User-Token.txt"))
                {
                    sw.WriteLine("Open this in your web browser");
                    sw.WriteLine("");
                    sw.WriteLine("https://github.com/ArchboxDev/Discore-Selfbot/blob/master/UserToken.md");
                }

            }
            while (_Bot.Token == "")
            {
            }
            #endregion

            if (File.Exists(_Bot.Path + "Settings.json"))
            {
                using (StreamReader reader = new StreamReader(_Bot.Path + "Settings.json"))
                { Settings = (_SettingsClass)serializer.Deserialize(reader, typeof(_SettingsClass)); }
            }
            else
            {
                using (StreamWriter file = File.CreateText(_Bot.PathTags + "Settings.json"))
                {
                    serializer.Serialize(file, Settings);
                }
            }

            if (File.Exists(_Bot.Path + "Stats.json"))
            {
                using (StreamReader reader = new StreamReader(_Bot.Path + "Stats.json"))
                { Stats = (_StatsClass)serializer.Deserialize(reader, typeof(_StatsClass)); }
            }
            else
            {
                Stats.TotalRuns++;
                using (StreamWriter file = File.CreateText(_Bot.Path + "Stats.json"))
                {
                    serializer.Serialize(file, Stats);
                }
            }

            Console.WriteLine("Token found Loading Bot");
            if (Settings.Startup == "Hide All")
            {
                NotifyIcon.ShowBalloonTip(30, "Loading!", "Selfbot is now loading", ToolTipIcon.Info);
                var handle = GetConsoleWindow();
                ShowWindow(handle, SW_HIDE);
            }
            new Program().RunBot().GetAwaiter().GetResult();
        }

        [STAThread]
        public static void Notif()
        {
            Thread MyIconThread = new Thread(delegate ()
            {
                NotifyIcon = new NotifyIcon()
                {
                    Icon = Properties.Resources.Selfbot,
                    Visible = true
                };
                NotifyIcon.Click += Notify_Click;
                Application.Run();
            });
            MyIconThread.SetApartmentState(ApartmentState.STA);
            MyIconThread.Start();
        }
        public static void SaveSettings()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter file = File.CreateText(_Bot.Path + "Settings.json"))
            {
                serializer.Serialize(file, Settings);
            }
        }
        private static void Notify_Click(object sender, EventArgs e)
        {
            var NotifyMenu = new NotifyMenu();
            if (NotifyMenu.Visible == false)
            {
                NotifyMenu.ShowDialog();
            }
        }
        public async Task RunBot()
        {

            _Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                WebSocketProvider = WS4NetProvider.Instance,
                MessageCacheSize = 10, AlwaysDownloadUsers = true
            });
            _Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = false
            });
            await InstallCommands();

            
           
            _Bot.FavoriteColor = new Discord.Color(Settings.FavColor.R, Settings.FavColor.G, Settings.FavColor.B);
            int GuildCount = 0;
            _Client.GuildUnavailable += (g) =>
            {
                _GUI.RemoveGuild(g);
                if (_Client.ConnectionState != ConnectionState.Disconnecting)
                {
                    Console.WriteLine($"[Warning] G: {g.Name} is unavailable");
                    NotifyIcon.ShowBalloonTip(30, "Warning!", "G: {g.Name} is unavailable", ToolTipIcon.Warning);
                }
                
                return Task.CompletedTask;
            };

            _Client.GuildAvailable += (g) =>
            {
                _GUI.AddGuild(g);
                if (_Bot.Ready == false & GuildCount == _Client.Guilds.Count)
                {
                    _Bot.Ready = true;
                    if (Settings.Startup == "Hide All")
                    {
                        NotifyIcon.ShowBalloonTip(30, "Connected", "Selfbot is ONLINE!", ToolTipIcon.Info);

                    }
                    string Message = "";
                    switch (_Client.CurrentUser.Id)
                    {
                        case 190590364871032834:
                            Message = "Hi master Builderb";
                            break;
                        case 213621714909659136:
                            Message = "Bubbie's butt is bubbly";
                            break;
                        case 155490847494897664:
                            Message = "Julia + Novus <3";
                            break;
                        case 107827535479353344:
                            Message = "Julia + Novus <3";
                            break;
                        case 213627387206828032:
                            Message = "Towergay confirmed";
                            break;
                        case 149928344811601920:
                            Message = "Builderb pats Chat the neko";
                            break;
                        case 267007263359631380:
                            Message = "Thanks for testing";
                            break;
                        case 190376235128455168:
                            Message = "Get back in the salt mines!";
                            break;
                        default:
                            Message = $"Hi {_Client.CurrentUser.Username}";
                            break;
                    }
                    TimeSpan Startup = DateTime.Now - _Bot.StartupTime;
                    Console.WriteLine($"{Message} | Selfbot ready {_Client.Guilds.Count()} guilds | Loaded fully in {Startup.Seconds} Seconds");
                }
                return Task.CompletedTask;
            };

            _Client.MessageReceived += (m) =>
            {
                if (_GUI.Form != null)
                {
                    if (m.Author.Id == _Client.CurrentUser.Id)
                    {
                        _GUI.Form.Embed_SendActive.Enabled = true;

                        if (m.Channel is IPrivateChannel)
                        {
                            _GUI.Form.SetActive("DM", 1, m.Channel.Name, m.Channel.Id);
                            _GUI.Form.Embed_SendActive.Text = "Active DM";
                        }
                        else
                        {
                            var GU = m.Author as IGuildUser;
                            if (GU.GetPermissions(m.Channel as ITextChannel).EmbedLinks == true)
                            {
                                _GUI.Form.SetActive(GU.Guild.Name, GU.Guild.Id, m.Channel.Name, m.Channel.Id);
                                _GUI.Form.Embed_SendActive.Text = "Active";

                            }
                            else
                            {
                                _GUI.Form.SetActive(GU.Guild.Name, 2, m.Channel.Name, m.Channel.Id);
                                _GUI.Form.Embed_SendActive.Text = "No Perms";
                            }
                        }
                    }
                }
                return Task.CompletedTask;
            };

            _Client.JoinedGuild += (g) =>
            {
                Console.WriteLine($"[Joined Guild] {g.Name} ({g.Id}) - Owner {g.Owner.Username}");
                _GUI.AddGuild(g);
                return Task.CompletedTask;
            };

            _Client.LeftGuild += (g) =>
            {
                _GUI.RemoveGuild(g);
                Console.WriteLine($"[Left Guild] {g.Name} ({g.Id}) - Owner {g.Owner.Username}");
                return Task.CompletedTask;
            };

            _Client.Connected += () =>
            {
                if (_Bot.FirstForm == false)
                {
                    _Bot.FirstForm = true;
                    _GUI.Open();
                }
                Console.Title = "[Discore Selfbot] Online!!";
                Console.WriteLine("[Discore Selfbot] CONNECTED!");
                if (_Bot.Ready == false)
                {
                    _Bot.Ready = true;
                    
                    UptimeTimer.Interval = 60000;
                    UptimeTimer.Elapsed += UptimeTick;
                    UptimeTimer.Start();
                    using (Stream ImageStream = AvatarIconDownload.OpenRead(_Client.CurrentUser.GetAvatarUrl()))
                    {
                        Bitmap b = (Bitmap)System.Drawing.Image.FromStream(ImageStream);
                        IntPtr pIcon = b.GetHicon();
                        Icon i = Icon.FromHandle(pIcon);
                        _GUI.Avatar = i;
                        if (_GUI != null)
                        {
                            if (Settings.Startup == "Show GUI And Console")
                            {
                                _GUI.Form.Text = _Client.CurrentUser.Username;
                                _GUI.Form.Icon = i;
                                _GUI.Form.Guilds_Loading.Maximum = _Client.Guilds.Count;
                            }
                        }
                    }
                }

                return Task.CompletedTask;
            };

            _Client.Disconnected += (e) =>
            {
                if (_GUI.Form != null)
                {
                    _GUI.Form.Guilds_Bar.Items.Clear();
                }
                _GUI.GuildIDCache.Clear();
                Console.Title = "Discore Selfbot - Offline!";
                Console.WriteLine("[Discore Selfbot] DISCONNECTED!");
                return Task.CompletedTask;
            };

            _Client.Ready += () =>
            {
                    if (Settings.Startup == "Hide All")
                    {
                        NotifyIcon.ShowBalloonTip(30, "Connected", "Selfbot is ONLINE!", ToolTipIcon.Info);
                    }
                    string Message = "";
                switch (_Client.CurrentUser.Id)
                {
                    case 190590364871032834:
                        Message = "Hi master Builderb";
                        break;
                    case 213621714909659136:
                        Message = "Bubbie's butt is bubbly";
                        break;
                    case 155490847494897664:
                        Message = "Julia + Novus <3";
                        break;
                    case 107827535479353344:
                        Message = "Julia + Novus <3";
                        break;
                    case 213627387206828032:
                        Message = "Towergay confirmed";
                        break;
                    case 149928344811601920:
                        Message = "Builderb pats Chat the neko";
                        break;
                    case 267007263359631380:
                        Message = "Thanks for testing";
                        break;
                    case 190376235128455168:
                        Message = "Get back in the salt mines!";
                        break;
                    default:
                        Message = $"Hi {_Client.CurrentUser.Username}";
                        break;
                }
                    TimeSpan Startup = DateTime.Now - _Bot.StartupTime;
                    Console.WriteLine($"{Message} | Selfbot ready {_Client.Guilds.Count()} guilds | Loaded fully in {Startup.Seconds} Seconds");
                
                return Task.CompletedTask;
            };

            try
            {
                await _Client.LoginAsync(TokenType.User, _Bot.Token);
                await _Client.StartAsync();
            }
            catch (Exception ex)
            {
                if (Settings.Startup == "Hide All")
                {
                    NotifyIcon.ShowBalloonTip(30, "Error!", "Selfbot could not connect", ToolTipIcon.Error);
                    var handle = GetConsoleWindow();
                    ShowWindow(handle, SW_SHOW);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (ex.Message.Contains("401"))
                {
                    Console.WriteLine("Invalid Token");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            await Task.Delay(-1);
        }

        public async static Task SendAttachment(IUserMessage CommandMessage, string Location)
        {
            try
            {
                if (CommandMessage.Channel is IPrivateChannel)
                {
                    await CommandMessage.DeleteAsync();
                    await CommandMessage.Channel.SendFileAsync(Location);
                }
                else
                {
                    var Channel = CommandMessage.Channel as ITextChannel;
                    IGuildUser GuildUser = CommandMessage.Author as IGuildUser;
                    if (GuildUser.GetPermissions(Channel as ITextChannel).AttachFiles)
                    {

                        await CommandMessage.DeleteAsync();
                        await Channel.SendFileAsync(Location);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not send attachment: " + ex);
            }
        }

        public static void UptimeTick(object sender, ElapsedEventArgs e)
        {
            _Bot.Uptime++;
            Stats.TotalUptime++;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter file = File.CreateText(_Bot.Path + "Stats.json"))
            {
                serializer.Serialize(file, Stats);
            }
        }

        public static Discord.Color GetEmbedColor(ICommandContext CommandMessage)
        {
            Discord.Color Color = new Discord.Color(0);
            Color = _Bot.FavoriteColor;
            if (CommandMessage.Channel is IPrivateChannel)
            {

            }
            else
            {
                IGuildUser GuildUser = CommandMessage.User as IGuildUser;
                if (GuildUser.RoleIds.Count == 1)
                {
                }
                else
                {
                    if (Settings.ForceRoleColor == "Yes")
                    {
                        foreach (var Role in GuildUser.Guild.Roles.OrderBy(x => x.Position))
                        {
                            if (GuildUser.RoleIds.Contains(Role.Id))
                            {
                                Color = Role.Color;
                            }
                        }
                    }
                }
            }
            if (GUI_Form.EmbedColor.RawValue != 0)
            {
                Color = GUI_Form.EmbedColor;
            }
            return Color;
        }

        public async Task InstallCommands()
        {
            _Client.MessageReceived += HandleCommand;
            await _Commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }
        public async Task HandleCommand(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            if (message == null) return;
            if (message.Author.Id == _Client.CurrentUser.Id)
            {
                int argPos = 0;
                if (message.HasStringPrefix("self ", ref argPos))
                {
                    foreach (var Mes in Program.ErrorMessages)
                    {
                        await Mes.DeleteAsync();
                    }
                    await message.ModifyAsync(x =>
                    {
                        x.Content = "`...`";
                    });
                    var context = new CommandContext(_Client, message);
                    var result = await _Commands.ExecuteAsync(context, argPos);
                    if (result.IsSuccess)
                    {
                        Console.WriteLine($"[Command] Executed {message.Content}");
                        return;
                    }
                    else
                    {
                        //if (!File.Exists(SelfbotDir + "Custom\\" + message.Content.Replace("self ", "") + ".json"))
                        //{


                        //}
                        Console.WriteLine($"[Command] Failed {message.Content} | " + result.ErrorReason);
                        await message.DeleteAsync();
                    }
                    //if (File.Exists(SelfbotDir + "Custom\\" + message.Content.Replace("self ", "") + ".json"))
                    //{
                    //await CustomCommands.ParseFileAsync(message.Content.Replace("self ", ""), context);
                    //}
                }
                else
                {
                    var MessageText = "";
                    if (message.Content.Contains("{lenny}") || message.Content.Contains("{fidget}"))
                    {
                        if (MessageText == "")
                        {
                            MessageText = message.Content;
                        }
                        MessageText = MessageText.Replace("{lenny}", "( ͡° ͜ʖ ͡°)");
                        MessageText = MessageText.Replace("{fidget}", "߷");
                        await message.ModifyAsync(x => { x.Content = MessageText; });
                    };
                }
            
            }
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Discord;
using Discord.WebSocket;
using System.Windows.Forms;
using Discord.Commands;
using System.Reflection;
using System.IO;
using System.Net;
using System.Drawing;
using System.Runtime.InteropServices;
using Discord.Net.Providers.WS4Net;
using Discord.Commands;
using System.Diagnostics;
using System.Timers;

namespace Discore_Selfbot
{
    class Program
    {
        private CommandService commands;
        public static DiscordSocketClient client;
        private DependencyMap map;
        public static string SelfbotDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\";
        public static bool DownloadGuilds = false;
        public static List<string> Guilds = new List<string>();
        public static List<ulong> GuildsID = new List<ulong>();
        public static List<string> Channels = new List<string>();
        public static List<ulong> ChannelsID = new List<ulong>();

        public static Discord.Color FavoriteColor;
        public static MainForm MyForm;
        public static System.Timers.Timer AutoNickname_Timer = new System.Timers.Timer();
        public static string CurrentUserName;
        public static ulong CurrentUserID;
        public static bool ConnectedOnce = false;
        public static Random RandomGenerator = new Random();
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (Properties.Settings.Default.ANGuildsList == null)
            {
                Properties.Settings.Default.ANGuildsList = new System.Collections.Specialized.StringCollection();
            }
            Properties.Settings.Default.Save();
            Console.Title = "Discore - Selfbot - User Token Required";
            string Token = "";
            Directory.CreateDirectory(SelfbotDir);
            Directory.CreateDirectory(SelfbotDir + "Tags");
            Directory.CreateDirectory(SelfbotDir + "Nicknames");
            if (File.Exists(SelfbotDir + "Token.txt"))
            {
                Token = File.ReadAllText(SelfbotDir + "Token.txt");
            }
            else
            {
                File.CreateText(SelfbotDir + "Token.txt");
                Console.WriteLine("Insert your User Token into the file Token.txt and restart the bot");
                Console.WriteLine("And no i dont steal tokens you can view the code on github ");
                Process.Start(SelfbotDir);
            }
            while (Token == "")
            {
                Console.WriteLine("Token not found please enter your user token in this file and restart the bot");
                Process.Start(SelfbotDir);
            }
            // Load settings and bot
            Console.Title = "Discore - Selfbot";
            Console.WriteLine("Token found Loading Bot");
            FavoriteColor = new Discord.Color(Properties.Settings.Default.FavoriteColor.R, Properties.Settings.Default.FavoriteColor.G, Properties.Settings.Default.FavoriteColor.B);
            new Program().RunBot().GetAwaiter().GetResult();
        }

        [STAThread]
        public static void OpenGUI()
        {
            MainForm.CheckForIllegalCrossThreadCalls = false;
            MyForm = new MainForm();
            if (Properties.Settings.Default.AutoForm != "No")
            {
                Console.WriteLine("Opening GUI");
                Task mytask = Task.Run(() =>
                    {
                        MyForm.ShowDialog();
                    });
            }
        }

        public async Task RunBot()
        {
            client = new DiscordSocketClient(new DiscordSocketConfig
            {
                WebSocketProvider = WS4NetProvider.Instance
            });
            commands = new CommandService();
            await InstallCommands();
            AutoNickname_Timer.Interval = 60000;
            if (Properties.Settings.Default.ANTimer == "5")
            {
                AutoNickname_Timer.Interval = 300000;
            }
            if (Properties.Settings.Default.ANTimer == "10")
            {
                AutoNickname_Timer.Interval = 600000;
            }
            AutoNickname_Timer.Elapsed += Timer;
                AutoNickname_Timer.Start();
            int Guilds = 0;
            client.GuildUnavailable += (g) =>
            {
                int Index = Program.Guilds.IndexOf(g.Name);
                Program.Guilds.Remove(g.Name);
                Program.GuildsID.Remove(g.Id);
                MyForm.ListGuild.Items.RemoveAt(Index);
                return Task.CompletedTask;
            };
            client.GuildAvailable += (g) =>
            {
                if (!Program.Guilds.Contains(g.Name))
                {
                    Guilds++;
                    Program.Guilds.Add(g.Name);
                    Program.GuildsID.Add(g.Id);
                    WebClient WBC = new WebClient();
                    if (!File.Exists($"{g.Id}.png"))
                    {
                        if (g.IconUrl == null)
                        {
                            WBC.DownloadFile("http://dev.blaze.ml/Letters/" + g.Name.ToUpper().ToCharArray()[0] + ".png", $"{g.Id}.png");
                        }
                        else
                        {
                            WBC.DownloadFile(g.IconUrl, $"{g.Id}.png");
                        }
                        WBC.Dispose();
                    }
                    if (Properties.Settings.Default.AutoForm == "Yes")
                    {
                        MyForm.ListGuild.Items.Add(g.Name, System.Drawing.Image.FromFile($"{g.Id}.png")).DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                }
                if (Guilds == client.Guilds.Count)
                {
                    DownloadGuilds = true;
                }
                return Task.CompletedTask;
            };
            client.JoinedGuild += (g) =>
            {
                WebClient WBC = new WebClient();
                if (!File.Exists($"{g.Id}.png"))
                {
                    if (g.IconUrl == null)
                    {
                        var GuildNameFormat = new String(g.Name.Where(Char.IsLetter).ToArray());
                        WBC.DownloadFile("http://dev.blaze.ml/Letters/" + GuildNameFormat.ToCharArray()[0] + ".png", $"{g.Id}.png");
                    }
                    else
                    {
                        WBC.DownloadFile(g.IconUrl, $"{g.Id}.png");
                    }
                    WBC.Dispose();
                }
                var Item = MyForm.ListGuild.Items.Add(g.Name, System.Drawing.Image.FromFile($"{g.Id}.png")).DisplayStyle = ToolStripItemDisplayStyle.Image;
                Program.Guilds.Add(g.Name);
                Program.GuildsID.Add(g.Id);
                Console.WriteLine($"Joined Guild > {g.Name} ({g.Id}) - Owner {g.Owner.Username}");
                return Task.CompletedTask;
            };
            client.LeftGuild += (g) =>
            {
                int Index = Program.Guilds.IndexOf(g.Name);
                MyForm.ListGuild.Items.RemoveAt(Index);
                Program.Guilds.Remove(g.Name);
                Program.GuildsID.Remove(g.Id);
                Console.WriteLine($"Left Guild > {g.Name} ({g.Id})");
                return Task.CompletedTask;
            };
            client.MessageReceived += async (message) =>
            {    
                if (message.Author.Id == client.CurrentUser.Id)
                {
                    if (message.Channel is IPrivateChannel)
                    {
                        MyForm.ListChannel.Visible = false;
                        MyForm.AGName.Text = "DM";
                        MyForm.AGID.Text = $"(1)";
                        MyForm.ACName.Text = message.Channel.Name;
                        MyForm.ACID.Text = $"({message.Channel.Id})";
                        MyForm.EmbedActive.Text = "Active DM";
                        MainForm.ActiveGuildID = 1;
                        MainForm.ActiveChannelID = message.Channel.Id;

                    }
                    else
                    {
                        var GU = message.Author as IGuildUser;
                        MyForm.AGName.Text = GU.Guild.Name;
                        MyForm.AGID.Text = $"({GU.Guild.Id})";
                        MyForm.ACName.Text = message.Channel.Name;
                        MyForm.ACID.Text = $"({message.Channel.Id})";
                        MyForm.EmbedActive.Text = "Active";
                        MainForm.ActiveGuildID = GU.Guild.Id;
                        MainForm.ActiveChannelID = message.Channel.Id;
                        if (GU.GuildPermissions.EmbedLinks == true)
                        {
                            MyForm.EmbedActive.Text = "Active";
                        }
                        else
                        {
                            if (GU.GetPermissions(message.Channel as ITextChannel).EmbedLinks == true)
                            {
                                MyForm.EmbedActive.Text = "Active";
                            }
                            else
                            {
                                MyForm.EmbedActive.Text = "Active" + Environment.NewLine + "No perms";
                            }
                        }
                    }
                }
            };
            client.Connected += () =>
            {
                Console.Title = "Discore - Selfbot - Online!";
                Console.WriteLine("CONNECTED!");
                if (ConnectedOnce == false)
                {
                    CurrentUserName = client.CurrentUser.Username;
                    CurrentUserID = client.CurrentUser.Id;
                    WebClient myWebClient = new WebClient();
                    if (File.Exists("avatar.png"))
                    {
                        File.Delete("avatar.png");
                    }
                    myWebClient.DownloadFile(client.CurrentUser.GetAvatarUrl(), "avatar.png");
                    Bitmap b = (Bitmap)System.Drawing.Image.FromFile("avatar.png");
                    IntPtr pIcon = b.GetHicon();
                    Icon i = Icon.FromHandle(pIcon);
                    i.Dispose();
                    myWebClient.Dispose();
                    if (Properties.Settings.Default.AutoForm == "Yes")
                    {
                        MyForm.Text = CurrentUserName;
                        MyForm.Icon = i;
                    }
                    if (client.CurrentUser.Id == 190590364871032834)
                    {
                        Console.WriteLine("Hi master");
                    }
                    if (client.CurrentUser.Id == 213621714909659136)
                    {
                        Console.WriteLine("Bubbie's butt is bubbly");
                    }
                    if (client.CurrentUser.Id == 155490847494897664 || client.CurrentUser.Id == 107827535479353344)
                    {
                        Console.WriteLine("Julia + Novus <3");
                    }
                    if (client.CurrentUser.Id == 213627387206828032)
                    {
                        Console.WriteLine("Towergay");
                    }
                    ConnectedOnce = true;
                }
                return Task.CompletedTask;
            };

            client.Disconnected += (e) =>
            {
                Console.Title = "Discore - Selfbot - Offline!";
                Console.WriteLine("DISCONNECTED!");
                return Task.CompletedTask;
            };
            await client.LoginAsync(TokenType.User, File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Token.txt"));
            await client.StartAsync();
            OpenGUI();
            await Task.Delay(-1);
        }
        public async static void SendMessage(ITextChannel Channel, IUserMessage CommandMessage, [Remainder] string Message)
        {
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                await CommandMessage.ModifyAsync(x =>
                {
                    x.Content = $"`Selfbot | {Message}`";
                });
            }
            else
            {
                await CommandMessage.DeleteAsync();
                await Channel.SendMessageAsync($"`Selfbot | {Message}`");
            }
        }
        private async void Timer(object sender, ElapsedEventArgs e)
        {
            if (Properties.Settings.Default.ANGuildsList.Count != 0)
            {
                    List<string> NickList = new List<string>();
                    var NicknamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Nicknames\\";
                    foreach (var Guild in Properties.Settings.Default.ANGuildsList)
                    {
                        NickList.Clear();
                        try
                        {
                            foreach (var Item in Directory.GetFiles(NicknamePath))
                            {
                                if (Item.StartsWith($"{NicknamePath + Guild}-"))
                                {
                                    NickList.Add(Item.Replace($"{NicknamePath + Guild}-", ""));
                                }
                            }
                            if (NickList.Count != 0)
                            {
                                int randomValue = Program.RandomGenerator.Next(0, NickList.Count);
                                var DGuild = client.GetGuild(Convert.ToUInt64(Guild));
                                var GuildUser = DGuild.GetUser(CurrentUserID);
                                string Nickname = NickList[randomValue];
                                await GuildUser.ModifyAsync(x => x.Nickname = Nickname);
                            }
                        }
                        catch
                        {

                        }
                    }
            }
        }
            public async Task InstallCommands()
        {
            client.MessageReceived += HandleCommand;
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }
        public async Task HandleCommand(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            if (message == null) return;
            int argPos = 0;
            if (message.Author.Id == client.CurrentUser.Id)
            {
                if (!(message.HasStringPrefix("self ", ref argPos))) return;
                var context = new CommandContext(client, message);
                var result = await commands.ExecuteAsync(context, argPos, map);
            }
        }
    }
    public class InfoModule : ModuleBase
    {
        [Command("test")]
        public async Task test()
        {
            Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, "Hi " + Program.CurrentUserName);
        }

        [Command("ping")]
        public async Task ping(string IP = "")
        {
            if (IP == "")
            {
                System.Net.NetworkInformation.PingReply PingDiscord = new System.Net.NetworkInformation.Ping().Send("discordapp.com");
                System.Net.NetworkInformation.PingReply PingGoogle = new System.Net.NetworkInformation.Ping().Send("google.com");
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"PING > Discord: {PingDiscord.RoundtripTime} MS Google: {PingGoogle.RoundtripTime} MS Gateway: " + Program.client.Latency + " MS");
            }
            else
            {
                System.Net.NetworkInformation.PingReply Ping = new System.Net.NetworkInformation.Ping().Send("discordapp.com");
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"PING > {IP}: {Ping.RoundtripTime} MS");
            }
        }
        [Command("info")]
        public async Task info()
        {
            var Guilds = await Context.Client.GetGuildsAsync();
            var embed = new EmbedBuilder()
            {
                Author = new EmbedAuthorBuilder()
                {
                    Name = $"Selfbot | {Context.Client.CurrentUser.Username}",
                    IconUrl = Context.Client.CurrentUser.GetAvatarUrl(),
                    Url = Context.Client.CurrentUser.GetAvatarUrl()
                },
                Color = Program.FavoriteColor,
                Description = $"```md" + Environment.NewLine + $"<Guilds {Guilds.Count()}> <Created {Context.Client.CurrentUser.CreatedAt.Date.ToShortDateString()}> <ID {Context.Client.CurrentUser.Id}>```",
            };
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Channel.SendMessageAsync("", false, embed);
            }
        }

        [Command("cleanembed")]
        public async Task cleanembed()
        {
            await Context.Message.DeleteAsync();
            foreach (var Message in await Context.Channel.GetMessagesAsync(100).Flatten())
            {
                if (Message.Author.Id == Context.Client.CurrentUser.Id)
                {
                    if (Message.Embeds.Count == 1)
                    {
                        await Message.DeleteAsync();
                    }
                }
            }
        }

        [Command("form")]
        [Alias("gui")]
        public async Task form()
        {
            await Context.Message.DeleteAsync();
            if (!Program.MyForm.Visible)
            {
                Console.WriteLine("Opening gui");
                MainForm.SelectedGuild = 0;
                MainForm.SelectChannel = 0;
                Program.OpenGUI();
                Program.MyForm.Activate();
            }
            else
            {
                Program.MyForm.Activate();
                Console.WriteLine("Gui already open");
            }
        }

        [Command("embed")]
        public async Task embed([Remainder] string Text)
        {
            var embed = new EmbedBuilder()
            {
                Description = Text,
                Color = MainForm.EmbedColor
            };
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed);
            }
        }

        [Command("botinfo")]
        public async Task botinfo()
        {
            var embed = new EmbedBuilder()
            {
                Title = "Discore Selfbot Info",
                Color = Program.FavoriteColor,
                Description = $"Selfbot made by xXBuilderBXx#9113 [Github](https://github.com/ArchboxDev/Discore-Selfbot)",
            };
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed);
            }
        }

        [Command("lenny")]
        public async Task lenny()
        {
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "( ͡° ͜ʖ ͡°)";
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("( ͡° ͜ʖ ͡°)");
            }
        }

        [Command("st")]
        public async Task st()
        {
            await Context.Message.DeleteAsync();
            var embed = new EmbedBuilder()
            {
                ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRM7wR508Do1SR7I-kJACZtjyb4vCXX_N5ftE4PbSC5ptNheXi1"
            };
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("lewd")]
        public async Task lewd([Remainder] string Text)
        {
            var embed = new EmbedBuilder()
            {
                Title = "",
                Description = "LEWD",
                Color = new Discord.Color(255, 20, 147),
                ThumbnailUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRM7wR508Do1SR7I-kJACZtjyb4vCXX_N5ftE4PbSC5ptNheXi1"
            };
            if (Text.Contains("is") || Text.Contains("are"))
            {
                embed.Description = Text;
                if (Text.EndsWith("is") || Text.EndsWith("are"))
                {
                    embed.Description = Text + " LEWD";
                }
            }
            else
            if (Text.Any())
            {
                embed.Description = "LEWD " + Text;
            }
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed);
            }
        }

        [Command("user")]
        public async Task user(string ID)
        {
            if (Context.IsPrivate)
            {
                await Context.Message.Channel.SendMessageAsync("Cannot use command in private channel");
                return;
            }
            string User = ID;
            if (User.StartsWith("<@"))
            {
                User = User.Replace("<@", "").Replace(">", "");
                if (User.StartsWith("!"))
                {
                    User = User.Replace("!", "");
                }
            }
            try
            {
                var GuildUser = await Context.Guild.GetUserAsync(Convert.ToUInt64(User));
                int Count = 0;
                foreach(var Guild in await Context.Client.GetGuildsAsync())
                {
                    foreach (var Member in await Guild.GetUsersAsync())
                    {
                        if (Member.Id == GuildUser.Id)
                        {
                            Count++;
                        }
                    }
                }
                var embed = new EmbedBuilder()
                {
                    Author = new EmbedAuthorBuilder()
                    {
                        Name = $"{GuildUser.Username}#{GuildUser.Discriminator}",
                        IconUrl = GuildUser.GetAvatarUrl()
                    },
                    Color = Program.FavoriteColor,
                    Description = $"{GuildUser.Mention} - {GuildUser.Id}" + Environment.NewLine + $"Created {GuildUser.CreatedAt.Date.ToShortDateString()} | Joined Guild {GuildUser.JoinedAt.Value.Date.ToShortDateString()}" + Environment.NewLine + $"I am in {Count} Guilds with {Context.Message.Author.Username}",
                    Url = GuildUser.GetAvatarUrl()
                };
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = "";
                        x.Embed = embed.Build();
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync("", false, embed);
                }
            }
            catch
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, "Could not find user");
            }
        }

        [Command("find")]
        public async Task find(string ID)
        {
            int GuildCount = 0;
            Console.WriteLine("----- Guilds Found -----");
            foreach(var Guild in await Context.Client.GetGuildsAsync())
            {
                foreach(var User in await Guild.GetUsersAsync())
                {
                    if (User.Id.ToString() == ID)
                    {
                        Console.WriteLine(Guild.Name);
                        GuildCount++;
                    }
                }
            }
            Console.WriteLine("----- ----- -----");
            Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Found {ID} in {GuildCount} guilds check console for names");
        }

        [Command("tag")]
        public async Task tag(string Tag) 
        {
            var GuildUser = Context.Message.Author as IGuildUser;
            bool AllowedEmbeds = GuildUser.GetPermissions(Context.Channel as ITextChannel).EmbedLinks;
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            if (File.Exists(TagPath + Tag + ".txt"))
            {
                var TagText = File.ReadAllText(TagPath + Tag + ".txt");
                if (AllowedEmbeds == true)
                {
                    var embed = new EmbedBuilder()
                    {
                        Title = $"Selfbot Tag | {Tag}",
                        Color = Program.FavoriteColor,
                        Description = TagText
                    };
                    if (Properties.Settings.Default.SendAction == "Edit")
                    {
                        var M = Context.Message as IUserMessage;
                        await M.ModifyAsync(x =>
                        {
                            x.Content = "";
                            x.Embed = embed.Build();
                        });
                    }
                    else
                    {
                        await Context.Message.DeleteAsync();
                        await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
                    }
                }
                else
                {
                    if (Properties.Settings.Default.SendAction == "Edit")
                    {
                        var M = Context.Message as IUserMessage;
                        await M.ModifyAsync(x =>
                        {
                            x.Content = $"Selfbot Tag | {Tag}" + Environment.NewLine + TagText;
                        });
                    }
                    else
                    {
                        await Context.Message.DeleteAsync();
                        await Context.Message.Channel.SendMessageAsync($"Selfbot Tag | {Tag}" + Environment.NewLine + TagText);
                    }
                }
            }
            else
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Tag {Tag} not found");
            }
        }

        [Command("addtag")]
        public async Task addtag(string Tag = "", string MessageID = "")
        {
            string TagContent = "";
            bool Numeric = MessageID.All(char.IsDigit);
            if (Numeric == true)
            {
                foreach (var Message in await Context.Channel.GetMessagesAsync().Flatten())
                {
                    if (Message.Id.ToString() == MessageID)
                    {
                        TagContent = $"{Message.Author.Username} said \"{Message.Content}\"";
                    }
                }
            }
            else
            {
                TagContent = MessageID;
            }
            if (TagContent == "")
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, "Tag content not set or found");
                return;
            }
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            if (File.Exists(TagPath + Tag + ".txt"))
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Tag {Tag} already exists");
            }
            else
            {
                var TagFile = File.CreateText(TagPath + Tag + ".txt");
                TagFile.Write(TagContent);
                TagFile.Flush();
                TagFile.Close();
                TagFile.Dispose();
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Tag {Tag} created");
            }
        }

        [Command("deltag")]
        public async Task deltag(string Tag)
        {
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            if (File.Exists(TagPath + Tag + ".txt"))
            {
                File.Delete(TagPath + Tag + ".txt");
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Tag {Tag} deleted");

            }
            else
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"Tag {Tag} not found");
            }
        }

        [Command("an bind")]
        public async Task anbind()
        {
            var GuildUser = Context.User as IGuildUser;
            string Message = "";
            if (GuildUser.GuildPermissions.ChangeNickname == false)
            {
                Message = "You do not have perms for change nickname";
            }
            else
            {
                if (Properties.Settings.Default.ANGuildsList.Contains(Context.Guild.Id.ToString()))
                {
                    Message = "Guild removed from auto nickname list";
                    Properties.Settings.Default.ANGuildsList.Remove(Context.Guild.Id.ToString());
                }
                else
                {
                    Message = "Guild added to auto nickname list";
                    Properties.Settings.Default.ANGuildsList.Add(Context.Guild.Id.ToString());
                }
                Properties.Settings.Default.Save();
            }
            Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, Message);
        }

        [Command("an add")]
        public async Task anadd([Remainder]string Nickname)
        {
            var NicknamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Nicknames\\";
            if (File.Exists(NicknamePath + Context.Guild.Id + "-" + Nickname))
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"{Nickname} already exists");
            }
            else
            {
                File.Create(NicknamePath + Context.Guild.Id + "-" + Nickname);
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"{Nickname} added to auto nickname list");
            }
        }

        [Command("an del")]
        public async Task andel(string Nickname)
        {
            var NicknamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Nicknames\\";
            if (File.Exists(NicknamePath + Context.Guild.Id + "-" + Nickname))
            {
                File.Delete(NicknamePath + Context.Guild.Id + "-" + Nickname);
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"{Nickname} deleted");
            }
            else
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, $"{Nickname} does not exists");
            }
        }

        [Command("an list")]
        public async Task anlist()
        {
            List<string> ANList = new List<string>();
            var NicknamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Nicknames\\";
            foreach (var Item in Directory.GetFiles(NicknamePath))
            {
                if (Item.StartsWith($"{NicknamePath + Context.Guild.Id}-"))
                {
                    ANList.Add(Item.Replace($"{NicknamePath + Context.Guild.Id}-", ""));
                }
            }
            if (ANList.Count == 0)
            {
                Program.SendMessage(Context.Channel as ITextChannel, Context.Message as IUserMessage, "This guild does not have any nicknames set");
                return;
            }
            string NicknameList = string.Join(" | ", ANList.ToArray());
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "List of auto nicknames" + Environment.NewLine + NicknameList;
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("List of auto nicknames" + Environment.NewLine + NicknameList);
            }
        }

        [Command("tags")]
        public async Task tags()
        {
            List<string> TagList = new List<string>();
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            foreach (var File in Directory.GetFiles(TagPath))
            {
                TagList.Add(File.Replace(TagPath, "").Replace(".txt", ""));
            }
            string Tags = string.Join(" | ", TagList.ToArray());
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = $"Selfbot Tags" + Environment.NewLine + Tags;
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync($"```--- Selfbot Tags ---" + Environment.NewLine + Tags + "```");
            }
        }
    }
}

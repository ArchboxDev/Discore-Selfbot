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
using Discord.Audio;
using Discord.Commands;
using System.Diagnostics;

namespace Discore_Selfbot
{
    class Program
    {
        private CommandService commands;
        public static DiscordSocketClient client;
        private DependencyMap map;
        public static List<string> GuildLogs = new List<string>();
        public static bool DownloadGuilds = false;
        public static List<string> Guilds = new List<string>();
        public static List<ulong> GuildsID = new List<ulong>();
        public static List<string> Channels = new List<string>();
        public static List<ulong> ChannelsID = new List<ulong>();
        public static MainForm MyForm;
        public static string DiscordUser;
        public static bool IsAfk = false;
        public static string AfkText = "User is currently away atm";
        public static bool ConnectedOnce = false;

        static void Main()
        {
            Console.Title = "Discore - Selfbot - User Token Required";
            string Token = "";
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags");
            var TokenPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Token.txt";
            if (File.Exists(TokenPath))
            {
                Token = File.ReadAllText(TokenPath);
            }
            else
            {
                File.CreateText(TokenPath);
                Console.WriteLine("Insert your User Token into the file Token.txt and restart the bot");
                Console.WriteLine("And no i dont steal tokens you can view the code on github ");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\");
            }
            while (Token == "")
            {
                Console.WriteLine("Token not found please enter your user token in this file and restart the bot");
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\");
            }
            Console.Title = "Discore - Selfbot";
            Console.WriteLine("Token found Loading Bot");
            new Program().RunBot().GetAwaiter().GetResult();
        }
        [STAThread]
        public static void OpenGUI()
        {
            MainForm.CheckForIllegalCrossThreadCalls = false;
            MyForm = new MainForm();
            if (ConnectedOnce == false)
            {
                if (Properties.Settings.Default.AutoForm == "No")
                {
                    return;
                }
            }
            Console.WriteLine("Opening GUI");
            Task mytask = Task.Run(() =>
                {
                    MyForm.ShowDialog();
                });
        }

        public async Task RunBot()
        {
            client = new DiscordSocketClient(new DiscordSocketConfig
            {
                WebSocketProvider = WS4NetProvider.Instance,
                AudioMode = Discord.Audio.AudioMode.Outgoing
            });
            commands = new CommandService();
            map = new DependencyMap();
            await InstallCommands();
            int Guilds = 0;
            client.GuildAvailable += (g) =>
            {
                Guilds++;
                if (DownloadGuilds == false)
                {
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
                        Program.Guilds.Add(g.Name);
                        Program.GuildsID.Add(g.Id);
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
                var Item = MyForm.ListGuild.Items.Add(g.Name, System.Drawing.Image.FromFile($"{g.Id}.png"));
                Item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                Item.ToolTipText = g.Name;
                Program.Guilds.Add(g.Name);
                Program.GuildsID.Add(g.Id);
                Console.WriteLine($"Joined Guild > {g.Name} ({g.Id}) - Owner {g.Owner.Username}");
                return Task.CompletedTask;
            };
            client.LeftGuild += (g) =>
            {
                MyForm.ListGuild.Items.RemoveAt(Program.GuildsID.FindIndex(x => x == g.Id));
                Program.Guilds.Remove(g.Name);
                Program.GuildsID.Remove(g.Id);
                Console.WriteLine($"Left Guild > {g.Name} ({g.Id})");
                return Task.CompletedTask;
            };
            client.MessageReceived += async (message) =>
            {
                var GU = message.Author as IGuildUser;
                if (message.Author.Id != client.CurrentUser.Id)
                {
                    if (message.Channel is IPrivateChannel)
                    {

                    }
                    else
                    {
                        GuildLogs.Add($"{GU.Guild.Name}-{message.Channel}-{message.Author}-{message.Content}");
                    }
                    return;
                }
                if (message.Channel is IPrivateChannel)
                {
                    MyForm.ListChannel.Visible = false;
                    MyForm.AGName.Text = "DM";
                    MyForm.AGID.Text = $"(1)";
                    MyForm.ACName.Text = message.Channel.Name;
                    MyForm.ACID.Text = $"({message.Channel.Id})";
                    MainForm.ActiveGuildID = 1;
                    MainForm.ActiveChannelID = message.Channel.Id;
                }
                else
                {
                    MyForm.AGName.Text = GU.Guild.Name;
                    MyForm.AGID.Text = $"({GU.Guild.Id})";
                    MyForm.ACName.Text = message.Channel.Name;
                    MyForm.ACID.Text = $"({message.Channel.Id})";
                    MainForm.ActiveGuildID = GU.Guild.Id;
                    MainForm.ActiveChannelID = message.Channel.Id;
                }
            };
            client.Connected += () =>
            {
                Console.Title = "Discore - Selfbot - Online!";
                Console.WriteLine("CONNECTED!");
                if (ConnectedOnce == false)
                {
                    DiscordUser = client.CurrentUser.Username;
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(client.CurrentUser.GetAvatarUrl(), "avatar.png");
                    Bitmap b = (Bitmap)System.Drawing.Image.FromFile("avatar.png");
                    IntPtr pIcon = b.GetHicon();
                    Icon i = Icon.FromHandle(pIcon);
                    i.Dispose();
                    myWebClient.Dispose();
                    if (Properties.Settings.Default.AutoForm == "Yes")
                    {
                        MyForm.Text = DiscordUser;
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
                        Console.WriteLine("Julia + Novuse <3");
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
            if (Properties.Settings.Default.SendAction == "Edit")
            {
                var M = Context.Message as IUserMessage;
                await M.ModifyAsync(x =>
                {
                    x.Content = "Selfbot is working";
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Channel.SendMessageAsync("Selfbot is working");
            }
        }

        [Command("info")]
        public async Task info()
        {
            var Guilds = await Context.Client.GetGuildsAsync();
            var embed = new EmbedBuilder()
            {
                Title = "Discore Selfbot Info",
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
        [Command("ut")]
        public async Task ut(IUser User)
        {
            var GU = User as IGuildUser;
            Console.WriteLine(GU.JoinedAt.Value.Date.ToShortDateString());
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
                MainForm.EmbedColor = new Discord.Color(0, 0, 0);
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
                Description = Text
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
                Description = $"Selfbot made by <@190590364871032834> xXBuilderBXx#9113 [Github Project](https://github.com/ArchboxDev/Discore-Selfbot)",
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
                    Description = $"{GuildUser.Mention} - {GuildUser.Id}" + Environment.NewLine + $"Created {GuildUser.CreatedAt.Date.ToShortDateString()} | Joined Guild {GuildUser.JoinedAt.Value.Date.ToShortDateString()}" + Environment.NewLine + $"I am in {Count} Guilds with {Context.Message.Author.Username}",
                    Url = GuildUser.GetAvatarUrl(),
                    Color = new Discord.Color(0, 100, 0)
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
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = "Selfbot - Could not find user";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync("Selfbot - Could not find user");
                }
            }
        }

        [Command("find")]
        public async Task find(string ID)
        {
            await Context.Message.DeleteAsync();
            Console.WriteLine("----- Guilds Found -----");
            foreach(var Guild in await Context.Client.GetGuildsAsync())
            {
                foreach(var User in await Guild.GetUsersAsync())
                {
                    if (User.Id.ToString() == ID)
                    {
                        Console.WriteLine(Guild.Name);
                    }
                }
            }
            Console.WriteLine("----- ----- -----");
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
                        Description = "<@189778832973103104> " + TagText
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
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot Tag `{Tag}` not found";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot Tag `{Tag}` not found");
                }
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
                        TagContent = Message.Content;
                    }
                }
            }
            else
            {
                TagContent = MessageID;
            }
            if (TagContent == "")
            {
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Tag content not set or found";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Tag content not set or found");
                }
                return;
            }
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            if (File.Exists(TagPath + Tag + ".txt"))
            {
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot Tag `{Tag}` already exists";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot Tag `{Tag}` already exists");
                }
            }
            else
            {
                var TagFile = File.CreateText(TagPath + Tag + ".txt");
                TagFile.Write(TagContent);
                TagFile.Flush();
                TagFile.Close();
                TagFile.Dispose();
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot Tag `{Tag}` created" + Environment.NewLine + TagContent;
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot Tag `{Tag}` created" + Environment.NewLine + TagContent);
                }
            }
        }

        [Command("deltag")]
        public async Task deltag(string Tag)
        {
            var TagPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discore-Selfbot\\Tags\\";
            if (File.Exists(TagPath + Tag + ".txt"))
            {
                File.Delete(TagPath + Tag + ".txt");
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot Tag `{Tag}` deleted";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot Tag `{Tag}` deleted");
                }

            }
            else
            {
                if (Properties.Settings.Default.SendAction == "Edit")
                {
                    var M = Context.Message as IUserMessage;
                    await M.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot Tag `{Tag}` not found";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot Tag `{Tag}` not found");
                }
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
            string Tags = string.Join(", ", TagList.ToArray());
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

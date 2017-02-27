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

namespace Discore_Selfbot
{
    class Program
    {
        public static DiscordSocketClient client;
        public static string Token = "";
        public static List<string> GuildLogs = new List<string>();
        public static List<string> Guilds = new List<string>();
        public static List<ulong> GuildsID = new List<ulong>();
        public static List<string> Channels = new List<string>();
        public static List<ulong> ChannelsID = new List<ulong>();
        
        public static WebClient myWebClient = new WebClient();
        public static bool IsAfk = false;
        public static string AfkText = "User is currently away atm";

        static void Main()
        {
            // Get token from txt file
            var TokenPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Token.txt";
            if (File.Exists(TokenPath))
            {
                Token = File.ReadAllText(TokenPath);
            }
            else
            {
                Console.WriteLine("Please create a text file called Token.txt at your documents folder and restart the bot");
                Console.WriteLine("And no i dont steal tokens you can view the code on github");
            }
            while (Token == "")
            {

            }
            // Load token and run bot
            Console.WriteLine("Found token");
            new Program().RunBot().GetAwaiter().GetResult();
        }
        public static MainForm MyForm;
        [STAThread]
        public static void Mainv()
        {
            // Seperate form thread
            MainForm.CheckForIllegalCrossThreadCalls = false;
            MyForm = new MainForm();
            Task mytask = Task.Run(() =>
            {
                MyForm.ShowDialog();
            });
        }
        public async Task RunBot()
        {

            client = new DiscordSocketClient();
            client.GuildAvailable += (g) =>
            {
                WebClient WBC = new WebClient();
                if (g.IconUrl != null)
                {
                    WBC.DownloadFile(g.IconUrl, g.Id + "-icon.jpg");
                    var Item = MyForm.GuildList.Items.Add(g.Name, System.Drawing.Image.FromFile(g.Id + "-icon.jpg"));
                    Item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    Item.ToolTipText = g.Name;
                    Guilds.Add(g.Name);
                    GuildsID.Add(g.Id);
                    myWebClient.Dispose();
                }
                else
                {
                    char[] CharArray = g.Name.ToCharArray();
                    WBC.DownloadFile("http://dev.blaze.ml/Letters/" + CharArray[0] + ".png", $"{CharArray[0]}.png");
                    var Item = MyForm.GuildList.Items.Add(g.Name, System.Drawing.Image.FromFile($"{CharArray[0]}.png"));
                    Item.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    Item.ToolTipText = g.Name;
                    Guilds.Add(g.Name);
                    GuildsID.Add(g.Id);
                }
                return Task.CompletedTask;
            };
            client.MessageReceived += async (message) =>
            {
                var GU = message.Author as IGuildUser;
                if (message.Channel is IPrivateChannel)
                {
                    if (IsAfk == true)
                    {
                        if (message.Author.Id != client.CurrentUser.Id)
                        {
                            await message.Channel.SendMessageAsync(AfkText);
                        }
                    }
                    return;
                }
                GuildLogs.Add($"{GU.Guild.Name}-{message.Channel}-{message.Author}-{message.Content}");
                if (message.Author.Id == client.CurrentUser.Id)
                {
                    MyForm.AGName.Text = GU.Guild.Name;
                    MyForm.AGID.Text = $"({GU.Guild.Id})";
                    MyForm.ACName.Text = message.Channel.Name;
                    MyForm.ACID.Text = $"({message.Channel.Id})";
                    MainForm.ActiveGuildID = GU.Guild.Id;
                    MainForm.ActiveChannelID = message.Channel.Id;
                    if (message.Content.StartsWith("self test"))
                    {
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "Selfbot is working";
                        });

                    }
                    if (message.Content.StartsWith("self info"))
                    {
                        var embed = new EmbedBuilder()
                        {
                            Title = "Discore Selfbot Info",
                            Description = $"```md" + Environment.NewLine + $"<Guilds {client.Guilds.Count}> <Created {client.CurrentUser.CreatedAt.Date.ToShortDateString()}> <ID {client.CurrentUser.Id}>```",
                        };
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "";
                            x.Embed = embed.Build();
                        });
                    }
                    if (message.Content.StartsWith("self embed "))
                    {
                        if (message.Content == "self embed ")
                        {
                            return;
                        }
                        var embed = new EmbedBuilder()
                        {
                            Description = message.Content.Replace("self embed ", "")
                        };
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "";
                            x.Embed = embed.Build();
                        });
                    }
                        if (message.Content.StartsWith("self botinfo"))
                    {
                        var embed = new EmbedBuilder()
                        {
                            Title = "Discore Selfbot Info",
                            Description = $"Selfbot made by <@190590364871032834> xXBuilderBXx#9113 [Github Project](https://github.com/ArchboxDev/Discore-Selfbot)",
                        };
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "";
                            x.Embed = embed.Build();
                        });
                    }
                    if (message.Content.StartsWith("self lewd"))
                    {
                        var embed = new EmbedBuilder()
                        {
                            Title = "",
                            Description = "LEWD",
                            Color = new Discord.Color(255, 20, 147),
                            ThumbnailUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRM7wR508Do1SR7I-kJACZtjyb4vCXX_N5ftE4PbSC5ptNheXi1"
                        };
                        if (message.Content.Contains("is"))
                        {
                            embed.Description = message.Content.Replace("self lewd ", "") + " LEWD";
                        }
                        else
                        if (message.Content.Contains("self lewd "))
                        {
                            embed.Description = "LEWD " + message.Content.Replace("self lewd ", "");
                        }
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "";
                            x.Embed = embed.Build();
                        });
                    }
                    if (message.Content.StartsWith("self cleanembed"))
                    {
                        await message.DeleteAsync();
                        foreach (var Message in await message.Channel.GetMessagesAsync(100).Flatten())
                        {
                            if (Message.Author.Id == client.CurrentUser.Id)
                            {
                                if (Message.Embeds.Count == 1)
                                {
                                    await Message.DeleteAsync();
                                }
                            }
                        }

                    }
                    
                        if (message.Content.StartsWith("self afk"))
                    {
                        if (IsAfk == true)
                        {
                            Console.WriteLine("AFK turned off");
                            await client.SetGameAsync("");
                            await client.SetStatusAsync(UserStatus.Online);
                            IsAfk = false;
                            return;
                        }
                        Console.WriteLine("Afk on");
                        await client.SetGameAsync("AFK - Selfbot");
                        await client.SetStatusAsync(UserStatus.AFK);
                        IsAfk = true;
                        if (message.Content.Contains("self afk "))
                        {
                            AfkText = message.Content.Replace("self afk ", "");
                            
                        }
                    }
                    if (message.Content.StartsWith("self gui") || message.Content.StartsWith("self form)"))
                    {
                        await message.DeleteAsync();
                        if (!MyForm.Visible)
                        {
                            Console.WriteLine("Opening gui");
                            Mainv();
                            MyForm.Activate();
                        }
                        else
                        {
                            MyForm.Activate();
                            Console.WriteLine("Gui already open");
                        }
                    }
                    if (message.Content.StartsWith("self lenny"))
                    {
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "( ͡° ͜ʖ ͡°)";
                        });
                    }
                }
            };
            client.Connected += () =>
            {
                MyForm.Text = $"{client.CurrentUser.Username}";
                Console.WriteLine("Bot has succefully been connected");
                MyForm.Text = $"{client.CurrentUser.Username}";
                myWebClient.DownloadFile(client.CurrentUser.GetAvatarUrl(), "avatar.png");
                Bitmap b = (Bitmap)System.Drawing.Image.FromFile("avatar.png");
                IntPtr pIcon = b.GetHicon();
                Icon i = Icon.FromHandle(pIcon);
                i.Dispose();
                myWebClient.Dispose();
                MyForm.Icon = i;
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
                return Task.CompletedTask;
            };
            // Connect to discord
            Console.WriteLine("Connecting to discord");
            await client.LoginAsync(TokenType.User, Token);
            await client.StartAsync();
            // Load main form
            Mainv();
            await Task.Delay(-1);
        }
    }
    
}

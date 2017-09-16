using Discord;
using Discord.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Discore_Selfbot
{
    public class _Send
    {
        public static async Task Message(ICommandContext Context, string Message)
        {
            if (Context.Guild == null || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = Message;
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync(Message);
            }
        }
        public static async Task Embed(ICommandContext Context, EmbedBuilder Embed)
        {
            if (Context.Guild == null || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = "";
                    x.Embed = Embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, Embed.Build());
            }
        }
    }
    public class _Check
    {
        public static async Task GuildOnly(IUserMessage Message)
        {
            if (Message.Channel is IPrivateChannel)
            {
                await _CommandError.GuildOnly(Message);
            }
        }
        public static async Task DMOnly(IUserMessage Message)
        {
            if (Message.Channel is IGuildChannel)
            {
              await _CommandError.DMOnly(Message);
            }
        }
        public static bool HasEmbedPerms(IUserMessage Message)
        {
            bool EmbedPerms = true;
            if (Message.Channel is IGuildChannel)
            {
                IGuildUser GU = Message.Author as IGuildUser;
                if (!GU.GuildPermissions.EmbedLinks)
                {
                    EmbedPerms = false;
                }
            }
            return EmbedPerms;
        }
        public static async Task EmbedPerms(IUserMessage Message)
        {
            if (Message.Channel is IGuildChannel)
            {
                IGuildUser GU = Message.Author as IGuildUser;
                if (!GU.GuildPermissions.EmbedLinks)
                {
                   await _CommandError.NoEmbedPerms(Message);
                }
            }
        }
    }

    public class _CommandError
    {
        public static async Task GuildOnly(IUserMessage Message)
        {
            await Message.ModifyAsync(x =>
            {
                x.Content = "`Selfbot | Cannot use command in dm channel`";
            });
            throw new ArgumentException("Cannot use command in dm channel");
        }
        public static async Task DMOnly(IUserMessage Message)
        {
            await Message.ModifyAsync(x =>
            {
                x.Content = "`Selfbot | Cannot use command in guild channel`";
            });
            throw new ArgumentException("Cannot use command in guild channel");
        }
        public static async Task NoEmbedPerms(IUserMessage Message)
        {
            await Message.ModifyAsync(x =>
            {
                x.Content = $"`Selfbot | You do not have permission Embed Links`";
            });
            throw new ArgumentException("You do not have permission Embed Links");
        }
        public static async Task Custom(IUserMessage Message, string MessageText)
        {
            await Message.ModifyAsync(x =>
            {
                x.Content = $"`Selfbot | {MessageText}`";
            });
            throw new ArgumentException(MessageText);
        }
    }

    public class InfoCommands : ModuleBase
    {
        #region InfoCommands
        [Command("roles")]
        public async Task Roles()
        {
            await _Check.GuildOnly(Context.Message);
            await _Check.EmbedPerms(Context.Message);

            List<string> RoleList = new List<string>();
            foreach (var Role in Context.Guild.Roles.Where(x => x.Id != Context.Guild.EveryoneRole.Id))
            {
                RoleList.Add($"<@&{Role.Id}>");
            }
            var embed = new EmbedBuilder()
            {
                Description = string.Join(", ", RoleList.ToList()),
                Color = Program.GetEmbedColor(Context)
            };
            await _Send.Embed(Context, embed);
        }

        [Command("getusers")]
        public async Task Getusers()
        {
            IGuild FakeGuild = Program._Client.GetGuild(303724819994771457);
            var FakeGuildUsers = await FakeGuild.GetUsersAsync();
            IGuild Disnode = Program._Client.GetGuild(236338097955143680);
            List<string> Users = new List<string>();
            foreach (var user in FakeGuildUsers)
            {
                if (!user.IsBot)
                {
                    var ThisUser = await Disnode.GetUserAsync(user.Id);
                    if (ThisUser != null)
                    {
                        Users.Add($"{user.Username} <@{user.Id}> | Created {(user.CreatedAt).Day}/{(user.CreatedAt).Month}/{(user.CreatedAt).Year} | Joined {(ThisUser.JoinedAt.Value).Day}/{(ThisUser.JoinedAt.Value).Month}/{(ThisUser.JoinedAt.Value).Year}");
                    }
                    else
                    {
                        Users.Add($"{user.Username} <@{user.Id}> | Created {(user.CreatedAt).Day}/{(user.CreatedAt).Month}/{(user.CreatedAt).Year}");
                    }
                }
            }

            var embed = new EmbedBuilder()
            {
                Description = string.Join(Environment.NewLine, Users)
            };
            await ReplyAsync("", false, embed.Build());
        }

        [Command("region")]
        public async Task Region()
        {
            IVoiceRegion Region = await Context.Client.GetOptimalVoiceRegionAsync();
            var embed = new EmbedBuilder()
            {
                Title = ":globe_with_meridians: Region Info",
                Description = $"Your Region > {Region.Id}",
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Guild != null)
            {
                embed.Description = embed.Description + Environment.NewLine + $"Server Region > {Context.Guild.VoiceRegionId}";
            }
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }

        }

        [Command("help")]
        public async Task Help()
        {
            IGuildUser GuildUser = Context.User as IGuildUser;
            if (!GuildUser.GetPermissions(Context.Channel as IGuildChannel).EmbedLinks)
            {
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | For a list of commands see the GUI `self gui` or visit the website`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | For a list of commands see the GUI `self gui` or visit the website`");
                }
                return;
            }

            var embed = new EmbedBuilder()
            {
                Title = "Selfbot Help",
                Description = $"For a list of commands see the GUI `self gui` or" + Environment.NewLine + "Visit the [Website](https://blaze.ml/discore-selfbot/)",
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }
        
        [Command("guild")]
        public async Task Guild()
        {
            await _Check.GuildOnly(Context.Message);
            await _Check.EmbedPerms(Context.Message);
            int Members = 0;
            int Bots = 0;
            int MembersOnline = 0;
            int BotsOnline = 0;
            IGuildUser Owner = await Context.Guild.GetOwnerAsync();
            foreach (var User in await Context.Guild.GetUsersAsync())
            {
                if (User.IsBot)
                {
                    if (User.Status == UserStatus.Online || User.Status == UserStatus.Idle || User.Status == UserStatus.AFK || User.Status == UserStatus.DoNotDisturb)
                    {
                        BotsOnline++;
                    }
                    else
                    {
                        Bots++;
                    }
                }
                else
                {
                    if (User.Status == UserStatus.Online || User.Status == UserStatus.Idle || User.Status == UserStatus.AFK || User.Status == UserStatus.DoNotDisturb)
                    {
                        MembersOnline++;
                    }
                    else
                    {
                        Members++;
                    }
                }
            }
            int TextChan = 0;
            int VoiceChan = 0;
            foreach (var Channel in await Context.Guild.GetChannelsAsync())
            {
                if (Channel is ITextChannel)
                {
                    TextChan++;
                }
                else
                {
                    VoiceChan++;
                }
            }
            var embed = new EmbedBuilder()
            {
                Author = new EmbedAuthorBuilder()
                {
                    Name = $"{Context.Guild.Name}"
                },
                ThumbnailUrl = Context.Guild.IconUrl,
                Description = $"Owner: {Owner.Mention}```md" + Environment.NewLine + $"[Online](Offline)" + Environment.NewLine + $"<Users> [{MembersOnline}]({Members}) <Bots> [{BotsOnline}]({Bots})" + Environment.NewLine + $"Channels <Text {TextChan}> <Voice {VoiceChan}>" + Environment.NewLine + $"<Roles {Context.Guild.Roles.Count}> <CustomEmojis {Context.Guild.Emotes.Count}> <Region {Context.Guild.VoiceRegionId}>```",
                Footer = new EmbedFooterBuilder()
                {
                    Text = $"Created {Context.Guild.CreatedAt.Date.Day} {Context.Guild.CreatedAt.Date.DayOfWeek} {Context.Guild.CreatedAt.Year}"
                },
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("ping")]
        public async Task Ping(string IP = "")
        {
            if (IP == "")
            {
                System.Net.NetworkInformation.PingReply PingDiscord = new System.Net.NetworkInformation.Ping().Send("discordapp.com");
                System.Net.NetworkInformation.PingReply PingGoogle = new System.Net.NetworkInformation.Ping().Send("google.com");
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | Pong > Discord: {PingDiscord.RoundtripTime} MS Google: {PingGoogle.RoundtripTime} MS Gateway: {Program._Client.Latency} MS`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | Pong > Discord: {PingDiscord.RoundtripTime} MS Google: {PingGoogle.RoundtripTime} MS Gateway: {Program._Client.Latency} MS`");
                }
            }
            else
            {
                System.Net.NetworkInformation.PingReply Ping = new System.Net.NetworkInformation.Ping().Send(IP);
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | PONG > {IP}: {Ping.RoundtripTime} MS`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | PONG > {IP}: {Ping.RoundtripTime} MS`");
                }
            }
        }

        [Command("uptime")]
        public async Task Uptime()
        {
            
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = $"`Selfbot | Hi Uptime {Program._Bot.Uptime} minutes | TotalUptime {Program.Stats.TotalUptime} minutes | TotalRuns {Program.Stats.TotalRuns}`";
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync($"`Selfbot | Uptime {Program._Bot.Uptime} minutes | TotalUptime {Program.Stats.TotalUptime} minutes | TotalRuns {Program.Stats.TotalRuns}`");
            }
        }

        [Command("calc")]
        [Alias("math")]
        public async Task Calc([Remainder] string Math)
        {
            var interpreter = new DynamicExpresso.Interpreter();
            var result = interpreter.Eval(Math);
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = $"`Selfbot | {Math} = {result.ToString()}`";
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync($"`Selfbot | {Math} = {result.ToString()}`");
            }
        }

        [Command("info")]
        public async Task Info()
        {
            if (Context.Guild != null)
            {
                IGuildUser GuildUser = Context.User as IGuildUser;
                if (!GuildUser.GetPermissions(Context.Channel as IGuildChannel).EmbedLinks)
                {
                    if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                    {
                        await Context.Message.ModifyAsync(x =>
                        {
                            x.Content = $"`Selfbot | You do not have permission Embed Links`";
                        });
                    }
                    else
                    {
                        await Context.Message.DeleteAsync();
                        await Context.Message.Channel.SendMessageAsync($"`Selfbot | You do not have permission Embed Links`");
                    }
                    return;
                }
            }
            string OSV = "32 Bit";
            if (System.Environment.Is64BitOperatingSystem)
            {
                OSV = "64 Bit";
            }
            string OS = "Unknown";
            switch (Environment.OSVersion.Version.Minor)
            {
                case 0:
                    if (Environment.OSVersion.Version.Major == 10)
                    {
                        OS = "Windows 10";
                    }
                    break;
                case 1:
                    OS = "Windows 7";
                    break;
                case 2:
                    OS = "Windows 8";
                    break;
                case 3:
                    OS = "Windows 8.1";
                    break;
            }
            var Guilds = await Context.Client.GetGuildsAsync();
            var embed = new EmbedBuilder()
            {
                Author = new EmbedAuthorBuilder()
                {
                    Name = $"Selfbot | {Context.Client.CurrentUser.Username}",
                    IconUrl = Context.Client.CurrentUser.GetAvatarUrl(),
                    Url = Context.Client.CurrentUser.GetAvatarUrl()
                },
                Color = Program.GetEmbedColor(Context),
                Description = $"```md" + Environment.NewLine + $"<Guilds {Guilds.Count()}> <Created {Context.Client.CurrentUser.CreatedAt.Date.ToShortDateString()}> <ID {Context.Client.CurrentUser.Id}>```",
            };
            embed.AddField(x =>
            {
                x.Name = "Computer"; x.Value = $":desktop: {OS} {OSV}"; x.IsInline = true;
            });
            string TimeEmoji = ":clock12:";
            switch (DateTime.Now.TimeOfDay.Hours)
            {
                case 1:
                    TimeEmoji = ":clock1:";
                    break;
                case 2:
                    TimeEmoji = ":clock2:";
                    break;
                case 3:
                    TimeEmoji = ":clock3:";
                    break;
                case 4:
                    TimeEmoji = ":clock4:";
                    break;
                case 5:
                    TimeEmoji = ":clock5:";
                    break;
                case 6:
                    TimeEmoji = ":clock6:";
                    break;
                case 7:
                    TimeEmoji = ":clock7:";
                    break;
                case 8:
                    TimeEmoji = ":clock8:";
                    break;
                case 9:
                    TimeEmoji = ":clock9:";
                    break;
                case 10:
                    TimeEmoji = ":clock10:";
                    break;
                case 11:
                    TimeEmoji = ":clock11:";
                    break;
            }
            embed.AddField(x =>
            {
                x.Name = "My Time"; x.Value = $"{TimeEmoji} {DateTime.Now.TimeOfDay.Hours.ToString().PadLeft(2, '0')}:{DateTime.Now.TimeOfDay.Minutes.ToString().PadLeft(2, '0')}"; x.IsInline = true;
            });

            embed.AddField(x =>
            {
                x.Name = "Uptime"; x.Value = $":hourglass: {Program._Bot.Uptime} minutes"; x.IsInline = true;
            });
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("bot")]
        [Alias("selfbot")]
        public async Task Botinfo()
        {
            if (Context.Guild != null)
            {
                IGuildUser GuildUser = Context.User as IGuildUser;
                if (!GuildUser.GetPermissions(Context.Channel as IGuildChannel).EmbedLinks)
                {
                    if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                    {
                        await Context.Message.ModifyAsync(x =>
                        {
                            x.Content = $"`Selfbot | You do not have permission Embed Links`";
                        });
                    }
                    else
                    {
                        await Context.Message.DeleteAsync();
                        await Context.Message.Channel.SendMessageAsync($"`Selfbot | You do not have permission Embed Links`");
                    }
                    return;
                }
            }
            var embed = new EmbedBuilder()
            {
                Title = "Discore Selfbot Info",
                Description = $"Selfbot made by xXBuilderBXx#9113 [Github](https://github.com/ArchboxDev/Discore-Selfbot)",
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }
        
        [Command("avatar")]
        public async Task Avatar(string ID = "")
        {
            if (Context.Guild != null)
            {
                IGuildUser GuildUser = Context.User as IGuildUser;
                if (!GuildUser.GetPermissions(Context.Channel as IGuildChannel).EmbedLinks)
                {
                    if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                    {
                        await Context.Message.ModifyAsync(x =>
                        {
                            x.Content = $"`Selfbot | You do not have permission Embed Links`";
                        });
                    }
                    else
                    {
                        await Context.Message.DeleteAsync();
                        await Context.Message.Channel.SendMessageAsync($"`Selfbot | You do not have permission Embed Links`");
                    }
                    return;
                }
            }
            string UserID = ID;
            if (ID == "")
            {
                UserID = Context.User.Id.ToString();
            }
            if (UserID.StartsWith("<@"))
            {
                UserID = UserID.Replace("<@", "").Replace(">", "");
                if (UserID.StartsWith("!"))
                {
                    UserID = UserID.Replace("!", "");
                }
            }
            try
            {
                IUser User = await Context.Guild.GetUserAsync(Convert.ToUInt64(UserID));
                if (User == null)
                {
                    await Context.Message.DeleteAsync();
                    Console.WriteLine($"Cannot find user with id {UserID}");
                    return;
                }
                var embed = new EmbedBuilder()
                {
                    Title = $"Selfbot | Avatar for {User.Username}#{User.Discriminator}",
                    ImageUrl = User.GetAvatarUrl(),
                    Url = User.GetAvatarUrl(),
                    Color = Program.GetEmbedColor(Context)
                };
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = " ";
                        x.Embed = embed.Build();
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
            catch (Exception ex)
            {
                await Context.Message.DeleteAsync();
                Console.WriteLine(ex);
            }
        }

        [Command("user")]
        public async Task User(string ID)
        {
            if (Context.Guild == null)
            {
                await Context.Message.Channel.SendMessageAsync("`Selfbot | Cannot use command in private channel`");
                return;
            }
            IGuildUser ThisUser = Context.User as IGuildUser;
            if (!ThisUser.GetPermissions(Context.Channel as IGuildChannel).EmbedLinks)
            {
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | You do not have permission Embed Links`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | You do not have permission Embed Links`");
                }
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
                foreach (var Guild in await Context.Client.GetGuildsAsync())
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
                    Color = Program.GetEmbedColor(Context)
                };
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = " ";
                        x.Embed = embed.Build();
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
            catch
            {
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | Cannot find user`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | Cannot find user`");
                }
            }
        }

        [Command("find")]
        public async Task Find(string ID)
        {
            string UserID = ID;
            if (UserID.StartsWith("<@"))
            {
                UserID = UserID.Replace("<@", "").Replace(">", "");
                if (UserID.StartsWith("!"))
                {
                    UserID = UserID.Replace("!", "");
                }
            }
            int GuildCount = 0;
            Console.WriteLine("----- Guilds Found -----");
            foreach (var Guild in await Context.Client.GetGuildsAsync())
            {
                foreach (var User in await Guild.GetUsersAsync())
                {
                    if (User.Id.ToString() == UserID)
                    {
                        Console.WriteLine(Guild.Name);
                        GuildCount++;
                    }
                }
            }
            Console.WriteLine("----- ----- -----");
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = $"`Selfbot | Found {UserID} in {GuildCount} guilds check console for names`";
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync($"`Selfbot | Found {UserID} in {GuildCount} guilds check console for names`");
            }
        }
#endregion
    }
    public class FunCommands : ModuleBase
    {
        #region FunCommands
        [Command("cat")]
        public async Task Cat()
        {
            await _Check.EmbedPerms(Context.Message);
            WebRequest request = WebRequest.Create("http://random.cat/meow");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.UTF8);
            dynamic Item = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadToEnd());
            var embed = new EmbedBuilder()
            {
                Title = "Selfbot | Random Cat :cat:",
                Url = Item.file,
                ImageUrl = Item.file,
                Color = Program.GetEmbedColor(Context)
            };
            reader.Close();
            response.Close();
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("dog")]
        public async Task Dog()
        {
            await _Check.EmbedPerms(Context.Message);
            WebRequest request = WebRequest.Create("http://random.dog/woof");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.UTF8);
            string Item = reader.ReadToEnd();
            Console.WriteLine(Item);
            var embed = new EmbedBuilder()
            {
                Title = "Selfbot | Random Dag :dog:",
                Url = "http://random.dog/" + Item,
                ImageUrl = "http://random.dog/" + Item,
                Color = Program.GetEmbedColor(Context)
            };
            reader.Close();
            response.Close();
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("bang")]
        public async Task Bang([Remainder] string User = "")
        {
            await Context.Message.ModifyAsync(x =>
            {
                x.Content = $"{User} :open_mouth: :three: :gun:";
            });
            await Task.Delay(1000);
            await Context.Message.ModifyAsync(x =>
            {
                x.Content = $"{User} :frowning: :two: :gun:";
            });
            await Task.Delay(1000);
            await Context.Message.ModifyAsync(x =>
            {
                x.Content = $"{User} :worried: :one: :gun:";
            });
            await Task.Delay(1000);
            await Context.Message.ModifyAsync(x =>
            {
                x.Content = $"{User} :dizzy_face: :boom: :gun:";
            });
        }

        [Command("roulette")]
        public async Task Roulette(string Option = "")
        {
            await _Check.GuildOnly(Context.Message);
            List<IGuildUser> list = new List<IGuildUser>();
            foreach (var User in await Context.Guild.GetUsersAsync())
            {
                if (User.Id != Context.Client.CurrentUser.Id)
                {
                    list.Add(User);
                }
            }
            var RandomValue = Program.RandomGenerator.Next(1, list.Count + 1);
            if (Option.ToLower() == "kick")
            {
                var DM = await list[RandomValue].GetOrCreateDMChannelAsync();
                await DM.SendMessageAsync($"You have been kicked from {Context.Guild.Name} due to a russian roulette game by {Context.User.Username}#{Context.User.Discriminator}");

                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"Selfbot | Russian Roulette {list[RandomValue].Mention} {list[RandomValue].Username}#{list[RandomValue].Discriminator} has been kicked";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"Selfbot | Russian Roulette {list[RandomValue].Mention} {list[RandomValue].Username}#{list[RandomValue].Discriminator} has been kicked");
                }
                await list[RandomValue].KickAsync();
            }
            else
            {
                if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | I choose {list[RandomValue].Username}#{list[RandomValue].Discriminator}`";
                    });
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | I choose {list[RandomValue].Username}#{list[RandomValue].Discriminator}`");
                }
            }
        }

        [Command("neko")]
        public async Task Neko()
        {
            await _Check.EmbedPerms(Context.Message);
            var RandomValue = Program.RandomGenerator.Next(1, 11);
            var embed = new EmbedBuilder()
            {
                Title = "Selfbot | Random Neko :cat:",
                Color = Program.GetEmbedColor(Context)
            };
            switch (RandomValue)
            {
                case 1:
                    embed.ImageUrl = "https://em.wattpad.com/cfe2f4102b9bb5e0e32ad2ef4e6ad0edf906130c/687474703a2f2f666330382e64657669616e746172742e6e65742f667337302f662f323031312f3230322f332f332f615f6769726c5f6e656b6f5f62795f6d6f6b617468656865786769726c2d643431377432772e6a7067?s=fit&h=360&w=360&q=80";
                    break;
                case 2:
                    embed.ImageUrl = "https://68.media.tumblr.com/8dc8675a8d5a5a58fa224d0f13b3edd6/tumblr_oj1dtq9rMk1vwt3qvo1_500.jpg";
                    break;
                case 3:
                    embed.ImageUrl = "https://68.media.tumblr.com/5c472ee7d83552b5f65e9223810223de/tumblr_obgu5eQEEq1qjkxb4o1_500.png";
                    break;
                case 4:
                    embed.ImageUrl = "https://68.media.tumblr.com/4c43df58c426321ca6d5f3c80d76f141/tumblr_olh7x7zeJe1vwt3qvo1_500.jpg";
                    break;
                case 5:
                    embed.ImageUrl = "https://68.media.tumblr.com/d5bc9bb09cd2fac7f39f14c3a9254ab8/tumblr_ogkc06Fv531vbwt78o1_500.png";
                    break;
                case 6:
                    embed.ImageUrl = "https://68.media.tumblr.com/0211be68a458ef95a958918b0972973a/tumblr_o7m6s8GekH1vsna11o1_500.gif";
                    break;
                case 7:
                    embed.ImageUrl = "https://68.media.tumblr.com/2392325783e722994f418fdbfce2051d/tumblr_okym54bfdK1vwt3qvo1_500.png";
                    break;
                case 8:
                    embed.ImageUrl = "https://68.media.tumblr.com/37c749b7fcf43c33d7ed3e4f69c3e56a/tumblr_o80parZMmX1v61aw6o1_500.jpg";
                    break;
                case 9:
                    embed.ImageUrl = "https://68.media.tumblr.com/89854b3b3d572aa6380e0e811f8453a8/tumblr_okkhgbxPQ31vwt3qvo1_500.jpg";
                    break;
                case 10:
                    embed.ImageUrl = "https://68.media.tumblr.com/bdb7ad6e1b981ef67310402b0a107f8f/tumblr_o2ugsiwXDB1uwflhdo1_500.jpg";
                    break;
            }
            embed.Url = embed.ImageUrl;
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("embed")]
        public async Task Embed([Remainder] string Text)
        {
            await _Check.EmbedPerms(Context.Message);
            var embed = new EmbedBuilder()
            {
                Description = Text,
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("tembed")]
        public async Task Tembed(string Title, [Remainder] string Text = "")
        {
            await _Check.EmbedPerms(Context.Message);
            var embed = new EmbedBuilder()
            {
                Title = Title,
                Description = Text,
                Color = Program.GetEmbedColor(Context)
            };
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
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

        [Command("lenny")]
        public async Task Lenny()
        {
            var CommandMessage = Context.Message as IUserMessage;
            if (Program.Settings.MessageAction == "Edit")
            {
                await CommandMessage.ModifyAsync(x =>
                {
                    x.Content = "( ͡° ͜ʖ ͡°)";
                });
            }
            else
            {
                await CommandMessage.DeleteAsync();
                await Context.Channel.SendMessageAsync("( ͡° ͜ʖ ͡°)");
            }
        }

        [Command("lewd")]
        public async Task Lewd([Remainder] string Text = "")
        {
            await _Check.EmbedPerms(Context.Message);
            var embed = new EmbedBuilder()
            {
                Description = "LEWD",
                Color = new Discord.Color(255, 20, 147),
                ThumbnailUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRM7wR508Do1SR7I-kJACZtjyb4vCXX_N5ftE4PbSC5ptNheXi1"
            };
            if (Text.Contains("is") || Text.Contains("are") || Text.Contains("is lewd") || Text.Contains("are lewd"))
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
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }
        #endregion
    }
    public class MiscCommands : ModuleBase
    {
        #region MiscCommands
        [Command("form")]
        [Alias("gui")]
        public async Task Form()
        {
            await Context.Message.DeleteAsync();
            
            if (Program._GUI.Form == null)
            {
                Program._GUI.Open();
            }
            else
            {
                Program._GUI.Form.Activate();
            }
        }

        [Command("clean")]
        public async Task Clean(int Ammount = 0)
        {
            if (Ammount == 0)
            {
                await Context.Message.DeleteAsync();
                throw new Exception("Specify an ammount > self clean (ammount)");
            }
            if (Ammount < 1)
            {
                await Context.Message.DeleteAsync();
                throw new Exception("Clean ammount cannot be less than 0");
            }
            if (Ammount > 30)
            {
                await Context.Message.DeleteAsync();
                throw new Exception("Clean ammount cannot be more than 30");
            }

            int Count = Ammount + 1;
                var Messages = await Context.Channel.GetMessagesAsync(100).Flatten();
              foreach(var Message in Messages)
                {
                    if (Count == 0)
                    {
                        break;
                    }
                    
                    if (Message.Author.Id == Context.Client.CurrentUser.Id)
                    {
                        Count--;
                        await Message.DeleteAsync();
                    }
                }
        }

        [Command("cleanembed")]
        [Alias("cleanembeds")]
        public async Task Cleanembed()
        {
            await Context.Message.DeleteAsync();
            var Messages = await Context.Channel.GetMessagesAsync().Flatten();
            foreach (var Message in Messages)
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

        [Command("test")]
        public async Task Test()
        {

            //dynamic Item = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadToEnd());
            //var Mention = Context.Guild.GetRole().Mention;
            //var WebHook = new Discord.Webhook.DiscordWebhookClient(, "");
            //await WebHook.SendMessageAsync(Mention + Text, false, null, "Discore-Selfbot");
            //await WebHook.SendMessageAsync("Test", false, null, "Test user");
            await _Send.Message(Context, $"`Selfbot | Hi {Context.Client.CurrentUser.Username}#{Context.Client.CurrentUser.Discriminator}`");
           
        }

        [Command("snip")]
        public async Task Snip()
        {
            if (!Environment.Is64BitProcess)
            {
                Process.Start("C:\\Windows\\sysnative\\SnippingTool.exe");
            }
            else
            {
                Process.Start("C:\\Windows\\system32\\SnippingTool.exe");
            }
            await Context.Message.DeleteAsync();
        }

        [Command("hex")]
        public async Task Color(string Text)
        {
            await _Check.EmbedPerms(Context.Message);
            if (!Text.Contains("#"))
            {
                Text = "#" + Text;
            }
            var color = ColorTranslator.FromHtml(Text);
            var embed = new EmbedBuilder()
            {
                Description = $"Selfbot | Hex Color {Text}",
                Color = new Discord.Color(color.R, color.G, color.B)
            };

            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                await Context.Message.ModifyAsync(x =>
                {
                    x.Content = " ";
                    x.Embed = embed.Build();
                });
            }
            else
            {
                await Context.Message.DeleteAsync();
                await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("roll")]
        public async Task Roll()
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var randomValue = random.Next(1, 7);
            var embed = new EmbedBuilder()
            {
                Title = "Selfbot | Dice",
                Description = $"You rolled a {randomValue}",
                ThumbnailUrl = "http://bestanimations.com/Games/Dice/dice-animated-gif-2.gif"
            };
            bool Embed = _Check.HasEmbedPerms(Context.Message);
            if (Context.Message.Channel is IPrivateChannel || Program.Settings.MessageAction == "Edit")
            {
                if (Embed == true)
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = "";
                        x.Embed = embed.Build();
                    });
                }
                else
                {
                    await Context.Message.ModifyAsync(x =>
                    {
                        x.Content = $"`Selfbot | You rolled a {randomValue}`";
                    });
                }
            }
            else
            {
                if (Embed == true)
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await Context.Message.Channel.SendMessageAsync($"`Selfbot | You rolled a {randomValue}`");
                }
            }
        }
        #endregion
    }
    public class TagCommands : ModuleBase
    {
        #region TagCommands
        [Command("tag")]
        public async Task Tag(string TagName = "")
        {
            if (TagName == "")
            {
                await Context.Message.ModifyAsync(x => x.Content = "`self tag (TagName) | for a list of tags do | self tags`");
            }
            else
            {
                await _Check.EmbedPerms(Context.Message);
                if (Program.TagList.Exists(x => x.TagName.ToLower() == TagName.ToLower()))
                {
                    _TagClass Tag = Program.TagList.First(x => x.TagName.ToLower() == TagName.ToLower());
                    var embed = new EmbedBuilder()
                    {
                        Author = new EmbedAuthorBuilder()
                        {
                            Name = Tag.TagName,
                            Url = Tag.Url
                        },
                        Description = Tag.Message,
                        Footer = new EmbedFooterBuilder()
                        {
                            Text = Tag.UserName,
                            IconUrl = Tag.UserIcon
                        },
                        ThumbnailUrl = Tag.Thumbnail,
                        ImageUrl = Tag.MainImage,
                        Color = Program.GetEmbedColor(Context)
                    };
                    await Context.Message.ModifyAsync(x => x.Embed = embed.Build());
                }
                else
                {
                    await _CommandError.Custom(Context.Message, $"Tag {TagName} not found");
                }
            }
        }

        [Command("tags")]
        public async Task Tags(string Option = "", ulong UserID = 0)
        {
            List<string> ListOfTags = new List<string>();
            if (Context.Channel is IPrivateChannel || Option == "")
            {
                foreach (var Item in Program.TagList)
                {
                    ListOfTags.Add(Item.TagName);
                }
            }
            else
            {
                if (Option.ToLower() == "guild")
                {
                    foreach (var Item in Program.TagList.Where(x => x.GuildID == Context.Guild.Id))
                    {
                        ListOfTags.Add(Item.TagName);
                    }
                }
                if (Option.ToLower() == "channel")
                {
                    foreach (var Item in Program.TagList.Where(x => x.ChannelID == Context.Channel.Id))
                    {
                        ListOfTags.Add(Item.TagName);
                    }
                }
            }
            if (Option.ToLower() == "user")
            {
                if (UserID == 0)
                {
                    await _CommandError.Custom(Context.Message, $"User ID not found");
                }
                foreach (var Item in Program.TagList.Where(x => x.UserID == UserID))
                {
                    ListOfTags.Add(Item.TagName);
                }
            }
            string Tags = string.Join(" | ", ListOfTags);
            if (_Check.HasEmbedPerms(Context.Message))
            {
                var embed = new EmbedBuilder()
                {
                    Title = "List Of Tags",
                    Color = Program.GetEmbedColor(Context),
                    Description = "```" + Environment.NewLine + Tags + "```"
                };
               await ReplyAsync("", false, embed.Build());
            }
            else
            {
                await Context.Message.ModifyAsync(x => x.Content = "**List Of Tags**```md" + Environment.NewLine + $"{Tags}```");
            }
        }

        [Command("addtag")]
        [Alias("createtag")]
        public async Task Addtag(string TagName = "", ulong MessageID = 0)
        {
            if (TagName == "" | MessageID == 0)
            {
                await Context.Message.ModifyAsync(x => x.Content = $"`Use | self addtag (TagName) (MessageID)`");
                return;
            }
            if (Program.TagList.Exists(x => x.TagName.ToLower() == TagName.ToLower()))
            {
                await Context.Message.ModifyAsync(x => x.Content = $"`Tag {TagName} already exists`");
                return;
            }
            IMessage TagMessage = null;
            var Messages = await Context.Channel.GetMessagesAsync(50).Flatten();
            foreach (var Message in Messages)
            {
                if (Message.Id == MessageID)
                {
                    TagMessage = Message;
                }
            }
            if (TagMessage == null)
            {
                await Context.Message.ModifyAsync(x => x.Content = $"`Cannot find message by ID`");
                return;
            }
            _TagClass Tag = new _TagClass();
            if (TagMessage.Attachments.Count != 0)
            {
                if (TagMessage.Attachments.First().Url.Contains(".png") || TagMessage.Attachments.First().Url.Contains(".jpg"))
                {
                    Tag.MainImage = TagMessage.Attachments.First().Url;
                    Tag.Url = TagMessage.Attachments.First().Url;
                }
            }
            Tag.TagName = TagName;
            Tag.ChannelID = Context.Channel.Id;
            Tag.Color = new Discord.Color(0, 0, 0);
            Tag.GuildID = Context.Guild.Id;
            Tag.Message = TagMessage.Content;
            Tag.UserIcon = TagMessage.Author.GetAvatarUrl();
            Tag.UserID = TagMessage.Author.Id;
            Tag.UserName = TagMessage.Author.Username + "#" + TagMessage.Author.Discriminator;
            using (StreamWriter file = File.CreateText(Program._Bot.PathTags + TagName.ToLower() + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Tag);
            }
            Program.TagList.Add(Tag);
            if (TagMessage.Attachments.Count == 0)
            {
                await Context.Message.ModifyAsync(x => x.Content = $"`Created tag {TagName} to edit it use | self edittag`");
            }
            else
            {
                await Context.Message.ModifyAsync(x => x.Content = $"`Created tag {TagName} with an image to edit it use | self edittag`");
            }
        }

        [Command("deltag")]
        [Alias("removetag")]
        public async Task Deltag(string TagName = "")
        {
            if (TagName == "")
            {
                await _CommandError.Custom(Context.Message, "Self deltag (Name)");
            }
            if (Program.TagList.Exists(x => x.TagName.ToLower() == TagName.ToLower()))
            {
                File.Delete(Program._Bot.PathTags + TagName.ToLower() + ".json");
                Program.TagList.RemoveAll(x => x.TagName.ToLower() == TagName.ToLower());
                await Context.Message.ModifyAsync(x => x.Content = $"`Deleted tag {TagName}`");
                return;
            }
            else
            {
                await _CommandError.Custom(Context.Message, "Tag {TagName} does not exists");
            }
        }

        [Command("edittag")]
        public async Task Edittag()
        {
            await _CommandError.Custom(Context.Message, "Edittag command coming soon ;)");
        }
        #endregion
    }
}

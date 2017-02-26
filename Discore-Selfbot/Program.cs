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

namespace Discore_Selfbot
{
    class Program
    {
        private DiscordSocketClient client;
        public static string Token = "";
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
            client.MessageReceived += async (message) =>
            {

                if (message.Author.Id == client.CurrentUser.Id)
                {
                    if (message.Content == "selftest")
                    {
                        var M = message as IUserMessage;
                        await M.ModifyAsync(x => {
                            x.Content = "Command test done";
                        });

                    }
                }
            };
            client.Connected += () =>
            {
                Console.WriteLine("Bot has succefully been connected");
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

using System;
using System.Collections.Generic;
using System.Linq;
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
using Discord.Net.Providers.WS4Net;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Timers;

namespace Discore_Selfbot
{
    public class CustomTextFormat
    {
        public string Type { get; set; }
    }
    public class CustomEmbedFormat
    {
        public string Type { get; set; }
    }
    public class CustomGalleryFormat
    {
        public string Type { get; set; }
    }
    class CustomCommands
    {
        public static async Task ParseFileAsync(string File, ICommandContext Context)
        {
            using (StreamReader read = new StreamReader(Program.SelfbotDir + "Custom\\" + File + ".json"))
            {
                var Req = read.ReadToEnd();
                dynamic json = Newtonsoft.Json.Linq.JObject.Parse(Req);
                if (json.Type == "Text")
                {
                    await CustomText(Program.SelfbotDir + "Custom\\" + File + ".txt", Context);
                }
            }
        }
        public static async Task CustomText(string File, ICommandContext Context)
        {
            
                    //using (Stream stream2 = File.Open(SelfbotDir + "Custom\\" + message.Content.Replace("self ", "") + ".message.txt", FileMode.Open))
                    //{
                        //using (StreamReader reader2 = new StreamReader(stream2))
                        //{
                            //await Program.SendMessage(message as IUserMessage, reader2.ReadToEnd().Replace("%G%", client.Guilds.Count.ToString()));
                        //}
                    //}
            
        }
        public async Task CustomEmbed()
        {
            //string Title = reader.ReadLine();
            //string Thumbnail = reader.ReadLine();
            //string Image = reader.ReadLine();
            if (File.Exists("tese"))
                {
                using (Stream stream2 = File.Open("Custom\\", FileMode.Open))
                {
                    using (StreamReader reader2 = new StreamReader(stream2))
                    {
                        var embed = new EmbedBuilder()
                        {
                            //Title = Title,
                            //ThumbnailUrl = Thumbnail,
                            //ImageUrl = Image,
                            //Description = reader2.ReadToEnd().Replace("%G%", client.Guilds.Count.ToString())
                        }.Build();
                        //if (context.Message.Channel is IPrivateChannel || Properties.Settings.Default.SendAction == "Edit")
                        //{
                        //await context.Message.ModifyAsync(x =>
                        //{
                        //x.Content = " ";
                        //x.Embed = embed;
                        //});
                        //}
                        //else
                        //{
                        //await context.Message.DeleteAsync();
                        //await context.Message.Channel.SendMessageAsync("", false, embed);
                        //}
                    }
                }
            }
        
        }
        public async Task CustomGallery()
        {
                //string Location = reader.ReadLine();
                List<string> ImageList = new List<string>();
                //foreach (var File in Directory.GetFiles(Location))
                //{
                    //if (File.ToLower().Contains(".png") || File.ToLower().Contains(".jpg") || File.ToLower().Contains(".gif"))
                    //{
                        //ImageList.Add(File);
                    //}
                //}
                if (ImageList.Count == 0)
                {
                    //await Program.SendMessage(message as IUserMessage, "No images found in command gallery");
                }
                else
                {
                    var RandomValue = Program.RandomGenerator.Next(1, ImageList.Count);
                    var RandomImage = ImageList[RandomValue];
                    //await Program.SendAttachment(message, RandomImage);
                }
            }
        
    }
}

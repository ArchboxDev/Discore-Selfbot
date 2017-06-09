using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using System.IO;

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

        }
        public async Task CustomEmbed()
        {
        
        }
        public async Task CustomGallery()
        {
        }
        
    }
}

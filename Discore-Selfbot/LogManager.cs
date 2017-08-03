using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discore_Selfbot
{
    class _Log
    {
        public static List<IMessage> ErrorCache = new List<IMessage>();
        public static void Selfbot(string Message)
        {
            Console.WriteLine($"[Selfbot] {Message}");
        }
        public static void Custom(string Message, ConsoleColor Color = ConsoleColor.White)
        {
            if (Color != ConsoleColor.White)
            {
                Console.ForegroundColor = Color;
            }
            Console.WriteLine(Message);
            if (Color != ConsoleColor.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Error(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error] {Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Warning(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Selfbot] {Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Guild(string Message)
        {
            Console.WriteLine($"[Guild] {Message}");
        }
        public static void GUI(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[GUI] {Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Command(string Message, bool Error = false)
        {
            if (Error == false)
            {
                Console.WriteLine($"[Command] {Message}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[Command Error] {Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

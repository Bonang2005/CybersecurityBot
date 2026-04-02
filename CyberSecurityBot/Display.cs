using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CyberSecurityBot
{
    public static class Display
    {
        public static void ShowLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("  ____                   ____      _               ____        _   \r\n | __ )  ___  ___       / ___|   _| |__   ___ _ __| __ )  ___ | |_ \r\n |  _ \\ / _ \\/ _ \\_____| |  | | | | '_ \\ / _ \\ '__|  _ \\ / _ \\| __|\r\n | |_) |  __/  __/_____| |__| |_| | |_) |  __/ |  | |_) | (_) | |_ \r\n |____/ \\___|\\___|      \\____\\__, |_.__/ \\___|_|  |____/ \\___/ \\__|\r\n                             |___/                                 ");
            Console.WriteLine("Keeping you safe online");
            Console.WriteLine("CyberSecurity Awareness Bot");
            Console.ResetColor();

        }
        public static void ShowWelcome(string name)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" =================================================");
            Console.WriteLine(" Welcome," + name + "!");
            Console.WriteLine(" I ma your Cybersecurity Awareness Bot.");
            Console.WriteLine(" Type 'help' to see what i can help you with,");
            Console.WriteLine(" Type 'exit' to exit");
            Console.WriteLine(" =================================================");
            Console.ResetColor();

        }
        public static void Chat(string message, ConsoleColor colour = ConsoleColor.White)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(" [CyberBot]" );
            Console.ForegroundColor = colour; 
            foreach (char c in massage)// for the typing effect
            {
                Console.Write(c);
                Thread.Sleep(15);// is the milliseconf between each charecter its a pause between each

            }
            Console.WriteLine();
            Console.ResetColor();

        }
        //
        }
    }


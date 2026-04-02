using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}

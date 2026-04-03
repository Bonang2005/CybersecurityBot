using CyberSecurityBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Speech.Synthesis;


AudioPlayer.PlayGreeting();
    Display.ShowLogo();
    Console.WriteLine("Enter you name:");
    string name = Console.ReadLine();

while (string.IsNullOrEmpty(name))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter your name.");
    Console.ResetColor();
    Console.Write("Enter You name:");
    name = Console.ReadLine();
}
    

name  = char.ToUpper(name[0]) + name.Substring(1).ToLower();

//Show the welcome message
Display.ShowWelcome(name);
Chatbot.Start(name);//To sart the Chatbot

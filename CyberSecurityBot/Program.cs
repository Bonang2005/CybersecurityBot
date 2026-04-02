using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CyberSecurityBot;


    AudioPlayer.PlayGreeting();
    Display.ShowLogo();
    Console.writeLine("Enter you name:");
    string name = Console.ReadLine();
    
    while(string.IsNull(name))
        {
        Console.ForegroundColor = ConsoleColor.red;
        Console.writeLine("Please enter your name.");
        Console.ResetColor();
        Console.Write("Enter You name:");
        name = Console.ReadLine();
    

name of = char.ToUpper(nameof[0]) + nameof.Substring(1).ToLower();

//Show the welcome message
Display.ShowWelcome(name);
Chatbot.Start(name);//To sart the Chatbot

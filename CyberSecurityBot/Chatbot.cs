using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CyberSecurityBot
{
    public static class  Chatbot
    {
        public static void Start(string name)
        {
            UserProfile user = new UserProfile(name);
            bool running = true;

            while (!running) {
                Display.ShowDivider();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(user.Name);
                Console.ResetColor();

                string input = Console.ReadLine();

                //Validation
                if (string.IsNullOrEmpty(input))

                {
                    Display.ShowError("Please enter a message. ");
                    continue;
                }
                if(input .Trim().Length > 200)
                {
                    Display. ShowError("Message is too long. Please keep it under 200 charecters.");
                    continue;


                }
                user.MessageCount++;
                string lowerInput = input.ToLower();
                //Exiting code
                if (lowerInput == "exit")
                {
                    Display.Chat("Goodbye, " + user, name + ". Stay Safe Online", ConsoleColor.DarkYellow);
                    Display.ShowExit(user); ;
                    running = false;
                }

                else if (lowerInput.Contains("how are you"))
                {
                    Display.Chat(" I am running at full security capacity! How can I help you ?", ConsoleColor.White);
                
                }
                else if(lowerInput.Contains("pusrpose")) || lowerInput.Contains("what do you do"))

                }
            Display.Chat("I am Cybersecurity Awareness Bot! I help learn about safety, safe browsing and privacy." , ConsoleColor.White);

         else if (lowerInput.Contains("purpose") || lowerInput.Contains("what do you do"))
            {
                Display.Chat("I am a Cybersecurity Awareness Bot! I help you learn about password safety, phishing, safe browsing and privacy.", ConsoleColor.White);
            }

            // Help menu
            else if (lowerInput.Contains("help") || lowerInput.Contains("topics") || lowerInput.Contains("what can i ask"))
            {
                Display.Chat("Here are the topics I can help with:\n\n  password  - Strong passwords and 2FA\n  phishing  - Spotting fake emails\n  browsing  - Safe browsing and VPNs\n  privacy   - Protecting your personal data", ConsoleColor.Green);
            }

            // Password
            else if (lowerInput.Contains("password") || lowerInput.Contains("2fa"))
            {
                user.LastTopic = "Passwords";
                Display.Chat("PASSWORD TIPS:\n\n  - Use at least 12 characters.\n  - Never reuse passwords.\n  - Use a password manager.\n  - Enable 2FA where possible.", ConsoleColor.Blue);
            }
            else if (lowerInput.Contains("phish") || lowerInput.Contains("scam") || lowerInput.Contains("spam"))
            {
                user.LastTopic = "Phishing";
                Display.Chat("PHISHING TIPS:\n\n  - Check the sender email address.\n  - Do not click suspicious links.\n  - Legitimate companies never ask for your password by email.", ConsoleColor.Blue);
            }
            else if (lowerInput.Contains("brows") || lowerInput.Contains("vpn") || lowerInput.Contains("virus"))
            {
                user.LastTopic = "Safe Browsing";
                Display.Chat("SAFE BROWSING TIPS:\n\n  - Always look for HTTPS.\n  - Use a VPN on public Wi-Fi.\n  - Keep your browser updated.", ConsoleColor.Blue);
            }
            else if (lowerInput.Contains("privacy") || lowerInput.Contains("personal data"))
            {
                user.LastTopic = "Privacy";
                Display.Chat("PRIVACY TIPS:\n\n  - Limit personal info on social media.\n  - Check app permissions.\n  - Use a separate email for sign ups.", ConsoleColor.Blue);
            }
            else
            {
                Display.Chat("I didn't quite understand that. Could you rephrase? Type 'help' to see available topics.", ConsoleColor.DarkYellow);
            }
        }
    }
}



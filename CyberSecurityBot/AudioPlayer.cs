using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Speech.Synthesis;
namespace CyberSecurityBot
{
    public static class AudioPlayer

    {
public static void playgreeting()
    {
		try

     {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            // for setting the volume
            synthesizer.Volume = 100;
            // The welcoming voice over
            synthesizer.Speak("Hello ! Welcome to the Cybersecurity Awereness Bot. I am here to help you stay safe online.");
}
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" Audio coluld not play the welcoming " + ex.Message);
            Console.ResetColor();
        }
  }
}

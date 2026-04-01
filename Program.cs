using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{// start of namespace
    internal class Program
    {// start of class
        static void Main(string[] args)
        {// start of main method

            Console.Title = "Cyber Guardian Bot";

            PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.StartChat();
        }// end of main method

        static void PlayGreeting()
        {// start of PlayGreeting method

            try
            {// Attempt to play the greeting sound
                string paths = AppDomain.CurrentDomain.BaseDirectory;
                string fullpath = paths.Replace(@"bin\Debug\", "greeting.wav");
                SoundPlayer player = new SoundPlayer(fullpath);
                player.PlaySync();
            }// If the file is not found or cannot be played, catch the exception and display a warning message
            catch
            {// Display a warning message if the greeting file is not found or cannot be played
                Console.WriteLine("Voice greeting file not found.");
            }// end of PlayGreeting method

        }// end of class
    }// end of namespace
}// end of file

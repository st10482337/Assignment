using System;
using System.Threading;

namespace Assignment
{// start of namespace
    public static class UIHelper
    {// start of UIHelper class


        public static void TypeEffect(string message, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void ShowLoading()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nLoading");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝ ╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║       ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║        ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗    ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝    ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

         CYBER GUARDIAN BOT 
");

            Console.ResetColor();
            Console.WriteLine("==========================================");
        }

        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\n You can ask me about:");
            Console.WriteLine("• Password safety");
            Console.WriteLine("• Phishing scams");
            Console.WriteLine("• Safe browsing");
            Console.WriteLine("• Ask 'What is your purpose?'");
            Console.WriteLine("• Type 'exit' to quit");

            Console.ResetColor();
        }

        public static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bot:  I didn’t understand that. Try asking about passwords, phishing, or browsing.");
            Console.ResetColor();
        }

        public static void ShowExit()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect("Bot: Stay safe online. Goodbye ");
            Console.ResetColor();
        }


    }// end of UIHelper class
}// end of namespace
using System;

namespace Assignment
{// start of namespace
    public class Chatbot
    {// start of Chatbot class

        public void StartChat()
        {//start of StartChat method
            UIHelper.ShowLogo();
            UIHelper.ShowLoading();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nEnter your name: ");
            Console.ResetColor();

            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {//start of while loop to check if the name is empty or whitespace
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Try again: ");
                Console.ResetColor();
                name = Console.ReadLine();
            }//end of while loop

            UIHelper.TypeEffect($"\nHello {name}!  Welcome to the Cyber Guardian.");
            UIHelper.TypeEffect("I am here to protect you from online threats.\n");

            UIHelper.ShowMenu();

            ChatLoop();
        }// end of StartChat method

        public void ChatLoop()
        {//start of ChatLoop method
            while (true)
            {//start of infinite loop for chatting
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {// If the user input is empty or whitespace, show an error message and continue to the next iteration of the loop
                    UIHelper.ShowError();
                    continue;
                }// If the user input contains the word "exit", show the exit message and break out of the loop to end the chat

                if (input.Contains("exit"))
                {// If the user input contains the word "exit", show the exit message and break out of the loop to end the chat
                    UIHelper.ShowExit();
                    break;
                }// Otherwise, respond to the user input

                Respond(input);
            }//end of infinite loop
        }// end of ChatLoop method

        public void Respond(string input)
        {//start of Respond method
            if (input.Contains("how are you"))
            {// If the user input contains the phrase "how are you", respond with a message indicating that the bot is running perfectly and ready to protect the user
                UIHelper.TypeEffect("Bot: I'm running perfectly and ready to protect you 😄");
            }// If the user input contains the word "help", show the menu again to provide options for the user
            else if (input.Contains("help"))
            {// If the user input contains the word "help", show the menu again to provide options for the user
                UIHelper.ShowMenu();
            }// If the user input contains the word "purpose", respond with a message explaining the bot's purpose of educating the user about cybersecurity and keeping them safe online
            else if (input.Contains("purpose"))
            {// If the user input contains the word "purpose", respond with a message explaining the bot's purpose of educating the user about cybersecurity and keeping them safe online
                UIHelper.TypeEffect("Bot: My purpose is to educate you about cybersecurity and keep you safe online.");
            }
            else if (input.Contains("password"))
            {// If the user input contains the word "password", respond with tips for creating strong passwords, such as using a mix of characters and avoiding common words
                UIHelper.TypeEffect("Bot:  Think of your password as a lock.");
                UIHelper.TypeEffect("Bot: Use uppercase, lowercase, numbers, and symbols.");
            }// If the user input contains the word "phishing", respond with a message warning about phishing scams and advising the user to avoid clicking on suspicious links or emails
            else if (input.Contains("phishing"))
            {// If the user input contains the word "phishing", respond with a message warning about phishing scams and advising the user to avoid clicking on suspicious links or emails
                UIHelper.TypeEffect("Bot:  Phishing scams try to trick you into giving personal info.");
                UIHelper.TypeEffect("Bot: Never click suspicious links or emails.");
            }// If the user input contains the word "browsing", respond with tips for safe browsing, such as checking for HTTPS and avoiding unsafe websites
            else if (input.Contains("browsing"))
            {// If the user input contains the word "browsing", respond with tips for safe browsing, such as checking for HTTPS and avoiding unsafe websites
                UIHelper.TypeEffect("Bot:  Always check for HTTPS when browsing.");
                UIHelper.TypeEffect("Bot: Avoid unsafe or unknown websites.");
            }// If the user input does not match any of the predefined responses, show an error message indicating that the bot did not understand the input

            else
            {// If the user input does not match any of the predefined responses, show an error message indicating that the bot did not understand the input
                UIHelper.ShowError();
            }// If the user input does not match any of the predefined responses, show an error message indicating that the bot did not understand the input
        }// end of Respond method


    }// end of Chatbot class
}// end of namespace
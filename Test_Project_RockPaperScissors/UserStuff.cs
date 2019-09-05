using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_RockPaperScissors
{
    class UserStuff
    {
        public string Name { get; set; }

        public string GetUserChoice()
        {
            Console.WriteLine("\nEnter 'r' to use 'Rock',\nEnter 'p' to use 'Paper',\nEenter 's' to use 'Scissors.\n" +
                "To leave the game press 'q'");
            string userChoice = "";
            bool check = false;
            while (!check)
            {
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "r" || userChoice == "p" || userChoice == "s") check = true;
                else
                {
                    if (userChoice == "q")
                    {
                        return userChoice;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Try again, you should type 'r', 'p' or 's'.\n If you want quit - press 'q'");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        check = false;
                    }
                } 
            }
            return userChoice;
        }
    }
}

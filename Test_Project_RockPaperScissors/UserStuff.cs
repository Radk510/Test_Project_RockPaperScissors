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
            Console.WriteLine("Enter 'r' to use 'Rock', enter 'p' to use 'Paper', enter 's' to use 'Scissors." +
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
                        return "End of the game, see you later.";
                    }
                    else
                    {
                        Console.WriteLine("Try again, you should type 'r', 'p' or 's'");
                        check = false;
                    }
                } 
            }
            return userChoice;
        }
    }
}

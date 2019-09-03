using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_RockPaperScissors
{
    class GameProcess
    {
        public UserStuff User { get; set; }
        public ComputerStuff Computer { get; set; } 
        public int UserPoints { get; set; }
        public int ComputerPoints { get; set; }


        public GameProcess(ComputerStuff computer, UserStuff user)
        {
            Computer = computer;
            User = user;
            UserPoints = 0;
            ComputerPoints = 0;
        }

        private void RoundResults(string userChoice, string computerChoice)
        {
            
            Console.WriteLine("User has " + userChoice + ". Computer has " + computerChoice);
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's draw");
            }
            else if (userChoice == "Rock" && computerChoice == "Paper")
            {
                Console.WriteLine("Computer win");
                ComputerPoints++;
            }
            else if (userChoice == "Paper" && computerChoice == "Rock")
            {
                Console.WriteLine("User win");
                UserPoints++;
            }
            else if (userChoice == "Paper" && computerChoice == "Scissors")
            {
                Console.WriteLine("Computer win");
                ComputerPoints++;
            }
            else if (userChoice == "Scissors" && computerChoice == "Paper")
            {
                Console.WriteLine("User win");
                UserPoints++;
            }
            else if (userChoice == "Scissors" && computerChoice == "Rock")
            {
                Console.WriteLine("Computer win");
                ComputerPoints++;
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors")
            {
                Console.WriteLine("User win");
                UserPoints++;
            }

            Console.WriteLine("User points: " + UserPoints + ". Computer points: " + ComputerPoints);
        }

        public void LetsPlayGame()
        {
            bool playOrQuit = false;
            int roundNum = 1;                     
            while (!playOrQuit)
            {
                string UserTool = "";
                Console.WriteLine("Round № " + roundNum);
                string ComputerTool = Computer.ComputerChoice();
                switch (User.GetUserChoice())
                {
                    case "r":
                        UserTool = "Rock";
                        break;
                    case "p":
                        UserTool = "Paper";
                        break;
                    case "s":
                        UserTool = "Scissors";
                        break;
                    case "q":
                        playOrQuit = true;
                        Console.WriteLine("End of the game");
                        break;
                    default:
                        break;
                }
                if (playOrQuit != true)
                {
                    RoundResults(UserTool, ComputerTool);
                }
                else
                {
                    Console.WriteLine("User points: " + UserPoints + ". Computer points: " + ComputerPoints);
                    if (UserPoints > ComputerPoints)
                    {
                        Console.WriteLine("User win");
                    }
                    else if (UserPoints == ComputerPoints)
                    {
                        Console.WriteLine("It's draw game");
                    }
                    else
                    {
                        Console.WriteLine("Computer win");
                    }
                }
                roundNum++;
            }
            
             
        }


    }
}

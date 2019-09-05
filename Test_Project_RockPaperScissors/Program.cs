using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a popular game in console view called \"Rock, Paper & Scissors\". " +
                "Created by Rodion Kl");
            UserStuff user = new UserStuff();           
            ComputerStuff computer = new ComputerStuff();            
            GameProcess game = new GameProcess(computer, user);
            
            game.LetsPlayGame();

            Console.WriteLine("\n\n\nPress any key to leave the console window...");
            Console.ReadLine();
        }
    }
}

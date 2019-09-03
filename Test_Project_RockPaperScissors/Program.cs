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
            UserStuff user = new UserStuff();
            Console.WriteLine(user.GetUserChoice());
            ComputerStuff computer = new ComputerStuff();
            Console.WriteLine(computer.ComputerChoice());


            Console.ReadLine();
        }
    }
}

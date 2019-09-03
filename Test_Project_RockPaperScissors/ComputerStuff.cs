using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_RockPaperScissors
{
    class ComputerStuff
    {


        public string ComputerChoice()
        {
            string[] toolToCompUse = { "Rock", "Paper", "Scissors" };
            Random rd = new Random();
            return toolToCompUse[rd.Next(3)];
        }
    }
}

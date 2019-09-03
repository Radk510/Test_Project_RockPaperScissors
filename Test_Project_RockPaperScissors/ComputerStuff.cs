using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_RockPaperScissors
{
    class ComputerStuff
    {
        string[] toolToCompUse = { "Rock", "Paper", "Scissors" };

        Random rd = new Random();

        public string ComputerChoice()
        {
            return toolToCompUse[rd.Next(3)];
        }
    }
}

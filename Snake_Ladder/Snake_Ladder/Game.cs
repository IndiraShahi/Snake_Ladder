using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder
{
    class Game
    {
        public void SnakeLadder()
        {
            int start = 0;
            Console.WriteLine("Start position of player is : " + start);
            Random dice = new Random();
            int diceRoll = dice.Next(1, 7);
            Console.WriteLine("Player dice number is  : " + diceRoll);

        }
    }
}
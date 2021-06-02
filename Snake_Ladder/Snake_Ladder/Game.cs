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
            const int For_Ladder = 1;
            const int For_Snake = 2;
            int TotalDiceRoll = 0;

            Console.WriteLine("Start position of player is : " + start);
            Random dice = new Random();
            while (start != 100)
            {
                int diceRoll = dice.Next(1, 7);
                Console.WriteLine("Player dice number is  : " + diceRoll);
                int SnakeOrLadder = dice.Next(0, 3);
                switch (SnakeOrLadder)

                {
                    case For_Ladder:
                        Console.WriteLine("Player moves forward");
                        if (start + diceRoll <= 100)
                            start += diceRoll;
                        else
                            start = start + 0;
                        break;

                    case For_Snake:
                        Console.WriteLine("Player moves back");
                        start -= diceRoll;
                        if (start < 0)
                            start = 0;
                        break;

                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("Present point :" + start);
                TotalDiceRoll += 1;

            }
            Console.WriteLine("Total number of dice rolled :" + TotalDiceRoll);
            Console.WriteLine("Winning point :" + start);
        }
    }
}


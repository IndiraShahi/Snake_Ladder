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
                        start += diceRoll;
                        Console.WriteLine("Player moves forward");
                        break;

                    case For_Snake:
                        start -= diceRoll;
                        Console.WriteLine("Player moves back");
                        break;

                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("Present point :" + start);

            }
            Console.WriteLine("Winning point :" + start);
        }
    }
}
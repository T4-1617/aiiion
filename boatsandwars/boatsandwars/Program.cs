using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boatsandwars
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] BattleField = new bool[7, 7];

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    BattleField[x, y] = false;
                }
            }
            //skapar spelplanen

            Random roll = new Random();
            int ships = 4;
            while (ships > 0)
            {
                int x = roll.Next(0, 7);
                int y = roll.Next(0, 7);
                BattleField[x, y] = true;
                ships--;

            }

            //sätter ut skepp slumpmässigt på spelplanen
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string place;
                    if (BattleField[x, y] == true)
                    {
                        place = "X";
                        
                    }
                    else
                    {
                        
                        place = "O";
                        
                    }
                    Console.Write(place);
                }
                Console.WriteLine();
            }
            //skriver spelplanen i consolen
        }
    }
}

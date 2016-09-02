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
                        place = " X ";
                        
                    }
                    else
                    {
                        
                        place = " O ";
                        
                    }
                    Console.Write(place);
                }
                Console.WriteLine();
            }
            //skriver ut spelplanen i consolen

            Console.WriteLine("Skjut mot skeppen genom att ange kordinater till kanonen!");

            int shotcount = 0;
            int shipcount = 4;
            while (shipcount > 0)
            {
                Console.Write("X kordinat:");
                int strikeX = int.Parse(Console.ReadLine())+1;
                Console.Write("y kordinat:");
                int strikeY = int.Parse(Console.ReadLine())+1;

                if (BattleField[strikeX, strikeY] == true)
                {
                    Console.WriteLine("Hit! Ship down");
                    BattleField[strikeX, strikeY] = false;
                    shotcount++;
                    shipcount--;
                    Console.WriteLine("Ships left: " + shipcount);
                }
                else
                {
                    Console.WriteLine("Miss, try again!");
                    shotcount++;
                }
            }
            Console.WriteLine("YOU WON! You only had to fire {0} shots!", shotcount);
            Console.ReadLine();
        }
    }
}

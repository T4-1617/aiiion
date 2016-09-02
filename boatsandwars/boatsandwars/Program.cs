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
            bool[,] BattleField = new bool[7, 5];

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    BattleField[x, y] = false;
                }
            }
            //skapar spelplanen (7x5 rutor)

            Random roll = new Random();
            int ships = 4;
            while (ships > 0)
            {
                int x = roll.Next(0, 7);
                int y = roll.Next(0, 5);
                BattleField[x, y] = true;
                ships--;

            }//sätter ut 4 skepp slumpmässigt på planen

            Console.WriteLine("Skjut mot skeppen genom att ange kordinater till kanonen!");

            int shotcount = 0;
            int shipcount = 4;
            int strikeX = -1;
            int strikeY = -1;
            while (shipcount > 0)//låter en gissa tills man sänkt alla skepp
            {
                Console.Write("X kordinat:");
                strikeX = int.Parse(Console.ReadLine()) - 1;
                while (strikeX > 6 || strikeX < 0)//kontrollerar att man angett en tillåten int mellan 1-7
                {
                    if (strikeX > 6 || strikeY < 0)//om man inte angett tillåten int får man skriva in ett tal igen
                    {
                        Console.WriteLine("ej ett giltigt tal värdet måste vara mellan 1-7, prova igen:");
                        strikeX = int.Parse(Console.ReadLine()) - 1;
                    }

                }
                Console.Write("Y kordinat:");
                strikeY = int.Parse(Console.ReadLine()) - 1;
                while (strikeY > 4 || strikeY < 0)//kontrollerar att man angett en tillåten int mellan 1-5
                {
                    if (strikeY > 4 || strikeY < 0)//om man inte angett tillåten int får man skriva in ett tal igen
                    {
                        Console.WriteLine("ej ett giltigt tal värdet måste vara mellan 1-5, prova igen:");
                        strikeY = int.Parse(Console.ReadLine()) - 1;
                    }
                }

                if (BattleField[strikeX, strikeY] == true) //om man gissat rätt tas skeppet bort ur spelet och den räknar försöket
                {                                       
                    Console.WriteLine("Hit! Ship down");
                    BattleField[strikeX, strikeY] = false;
                    shotcount++;
                    shipcount--;
                    Console.WriteLine("Ships left: " + shipcount);
                }
                else //gissar man fel så får man föröska igen, försöket räknas även
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

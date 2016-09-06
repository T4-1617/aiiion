using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] CardGame = new bool[13, 4];
            for (int y = 0; y < 4; y++) {

                for (int x = 0; x < 13; x++) {
                    CardGame[x, y] = false;
                }
            } //Skapar kortleken om 13 valöreroch 4 färjer
            Random roll = new Random();
            int cards = 52;
            int score = 0;
            while (cards > 0) { //lägger ut 52 kort
                int x = roll.Next(0, 13);
                int y = roll.Next(0, 4);
                if (CardGame[x, y] != true) //ser till att alla kort endast läggs en gång
                {
                    Console.WriteLine("tryck på enter för ett kort");
                    Console.ReadLine();
                    Console.Write("du fick kortet ");
                    switch (y)
                    {//skriver ut vilken färg man fått
                        case 0:
                            Console.Write("hjärter ");
                            break;
                        case 1:
                            Console.Write("spader ");
                            break;
                        case 2:
                            Console.Write("ruter ");
                            break;
                        case 3:
                            Console.Write("klöver ");
                            break;
                        

                    }
                    switch (x) //skriver ut vilken valör på kortet man fått (höga kort skrivs ut som ess, knäckt etc)
                    {
                        case 0:
                            Console.WriteLine("ess");
                                break;
                        case 10:
                            Console.WriteLine("knäckt");
                            break;
                        case 11:
                            Console.WriteLine("dam");
                            break;
                        case 12:
                            Console.WriteLine("kung");
                            break;
                        default:
                            Console.WriteLine(x + 1);
                            break;
                    }

                    
                    score =score + x + 1; //räknar poängen
                    CardGame[x, y] = true; //sätter kortet som true så det inte kan visas igen
                    cards--; //håller koll p hur många kort är kvar i kortleken
                    Console.WriteLine("du har {0} poäng ",score);
                    Console.WriteLine("och det finns {0} kort kvar i leken", cards);

                }
                
                
            }
        }
    }
}

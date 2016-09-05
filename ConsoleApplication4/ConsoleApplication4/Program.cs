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
            }
            Random roll = new Random();
            int cards = 52;
            while (cards > 0) {
                int x = roll.Next(0, 13);
                int y = roll.Next(0, 4);
                if (CardGame[x, y] != true)
                {
                    Console.WriteLine("tryck på enter för ett kort");
                    Console.ReadLine();
                    switch (y)
                    {
                        case 0:
                            Console.Write("ditt kortnummer är hjärter ");
                            break;
                        case 1:
                            Console.Write("ditt kortnummer är spader ");
                            break;
                        case 2:
                            Console.Write("ditt kortnummer är ruter ");
                            break;
                        case 3:
                            Console.Write("ditt kortnummer är klöver ");
                            break;
                        

                    }
                    switch (x)
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
                    
                    CardGame[x, y] = true;
                    cards--;
                }
            
                
            }
        }
    }
}

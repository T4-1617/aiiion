using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] deckCards = new bool[13, 4];
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    deckCards[x, y] = false;
                }
            }
            Random roll = new Random();
            int cardsLeft = 104;
            int score = 0;
            while (cardsLeft > 0)
            {
                Console.WriteLine("vill du ha ett kort? Y / N");
                string hitme = Console.ReadLine();
                switch (hitme)
                {
                    case "y":
                        int x = roll.Next();
                        int y = roll.Next();
                        if (deckCards[x, y] != true)
                        {
                            Console.Write("Du fick kortet ");
                            switch (y)
                            {
                                case 0:
                                case 4:
                                    Console.Write("hjärter ");
                                    break;
                                case 1:
                                case 5:
                                    Console.Write("spader ");
                                    break;
                                case 2:
                                case 6:
                                    Console.Write("ruter ");
                                    break;
                                case 3:
                                case 7:
                                    Console.Write("klöver ");
                                    break;
                            }
                        }
                        break;

                }
            }
        }
    }
}

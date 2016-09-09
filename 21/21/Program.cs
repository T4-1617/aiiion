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
            int x = 0;
            int y = 0;
            bool[,] deckCards = new bool[13, 16];
            for (y = 0; y < 16; y++)
            {
                for (x = 0; x < 13; x++)
                {
                    deckCards[x, y] = false;
                }
            }
            Random roll = new Random();
            int cardsLeft = 208;
            int score = 0;
            int opposition = 0;
            Boolean cont = false;
            Boolean finished = false;
            int opponentpoints = 0;
            int urpoints = 0;
            while (cardsLeft > 0)
            {
                while (cont == false)
                {
                    x = roll.Next(0, 13);
                    y = roll.Next(0, 16);
                    if (deckCards[x, y] != true)
                    {
                        Console.Write("Dealern fick  ");
                        switch (y)
                        {
                            case 0:
                            case 4:
                            case 8:
                            case 12:
                                Console.Write("hjärter ");
                                break;
                            case 1:
                            case 5:
                            case 9:
                            case 13:
                                Console.Write("spader ");
                                break;
                            case 2:
                            case 6:
                            case 10:
                            case 14:
                                Console.Write("ruter ");
                                break;
                            case 3:
                            case 7:
                            case 11:
                            case 15:
                                Console.Write("klöver ");
                                break;
                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        switch (x)
                        {
                            case 0:
                                Console.Write("ess");
                                x = 10;
                                break;
                            case 10:
                                Console.Write("kneckt");
                                x = 10;
                                break;
                            case 11:
                                Console.Write("dam");
                                x = 10;
                                break;
                            case 12:
                                Console.Write("kung");
                                x = 10;
                                break;
                            default:
                                Console.Write(x + 1);
                                break;
                        }
                        opposition = opposition + x + 1;
                        deckCards[x, y] = true;
                        cardsLeft--;
                        Console.WriteLine(" Dealern har " + opposition);
                        cont = true;
                    }
                }

                        Console.WriteLine("vill du ha ett kort? J / N");
                        string hitme = Console.ReadLine();
                        switch (hitme)
                        {
                            case "j":
                            case "J":
                                int done = 1;
                                while (done == 1)
                                {
                                    x = roll.Next(0, 13);
                                    y = roll.Next(0, 16);
                                    if (deckCards[x, y] != true)
                                    {
                                        Console.Write("Du fick kortet ");
                                        switch (y)
                                        {
                                            case 0:
                                            case 4:
                                            case 8:
                                            case 12:
                                                Console.Write("hjärter ");
                                                break;
                                            case 1:
                                            case 5:
                                            case 9:
                                            case 13:
                                                Console.Write("spader ");
                                                break;
                                            case 2:
                                            case 6:
                                            case 10:
                                            case 14:
                                                Console.Write("ruter ");
                                                break;
                                            case 3:
                                            case 7:
                                            case 11:
                                            case 15:
                                                Console.Write("klöver ");
                                                break;
                                            default:
                                                Console.WriteLine("ERROR");
                                                break;
                                        }
                                        switch (x)
                                        {
                                            case 0:
                                                Console.Write("ess");
                                                x = 9;
                                                break;
                                            case 10:
                                                Console.Write("kneckt");
                                                x = 9;
                                                break;
                                            case 11:
                                                Console.Write("dam");
                                                x = 9;
                                                break;
                                            case 12:
                                                Console.Write("kung");
                                                x = 9;
                                                break;
                                            default:
                                                Console.Write(x + 1);
                                                break;
                                        }
                                        score = score + x + 1;
                                        deckCards[x, y] = true;
                                        cardsLeft--;
                                        Console.WriteLine(" du ligger på " + score);
                                        done = 0;
                                        
                                    }


                                }
                                break;
                            case "n":
                            case "N":
                                finished = true;
                                
                                break;

                            default:
                                Console.WriteLine("Du måste svara med antingen n eller j");
                                break;

                        }
                        if (score > 21)
                        {
                            Console.WriteLine("DU SPRACK! Din total blev {0} Bättre lycka nästa gång!", score);
                            score = 0;
                            Console.WriteLine("Tryck på enter för att spela igen");
                            Console.ReadLine();
                            cont = false;
                            opposition = 0;

                        }
                        else if (score == 21)
                        {
                            Console.WriteLine("DU VANN! Grattis!");
                            score = 0;
                            Console.WriteLine("Tryck på enter för att spela igen");
                            Console.ReadLine();
                            cont = false;
                            opposition = 0;
                        }
                    if (score > opposition && score < 21)
                    {
                        cont = false;
                    }
                    else
                    {
                        cont = true;
                    }
                if (finished == true && cont == true)
                {
                    if (opposition >= score)
                    {
                        Console.WriteLine( "Dealern winner på {0}, och du förlorar med {1}" ,opponentpoints,urpoints );
                        opponentpoints = opponentpoints + 3;
                        
                    }
                    Console.WriteLine("Du slutade på {0} och dealern {1}", score, opposition);
                    score = 0;
                    opposition = 0;
                    Console.WriteLine("Tryck på enter för att spela igen");
                    Console.ReadLine();
                }

            }
                    Console.WriteLine("Tvärr finns det inga fler kort, spelet avslutas");
                

            }
        }
    }


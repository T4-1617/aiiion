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

        }
    }
}

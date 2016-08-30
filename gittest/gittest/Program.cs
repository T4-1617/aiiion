using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt namn:");

            string name1 = Console.ReadLine();

            Console.WriteLine("Skriv in ditt efternamn:");

            string name2 = Console.ReadLine();

            System.Console.WriteLine("hej " +name2);
        }
    }
}

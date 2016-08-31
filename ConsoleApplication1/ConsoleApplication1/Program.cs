using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value:");
            double val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            double val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("For addition enter 1");
            Console.WriteLine("For subtracktion enter 2");
            Console.WriteLine("For multiplication enter 3");
            Console.WriteLine("For division enter 4:");
            double ans = 0;
            int calc = int.Parse(Console.ReadLine());
            
            if (calc == 1)
            {
                ans = val1 + val2;
            }
            else if (calc == 2)
            {
                ans = val1 - val2;
            }
            else if (calc == 3)
            {
                 ans = val1 * val2;
            }
            else if (calc == 4)
            {
                ans = val1 / val2;
            }

            Console.WriteLine("The answer is: " + ans);

            Console.WriteLine("press enter to exit");

            Console.ReadLine();
        }
    }
}

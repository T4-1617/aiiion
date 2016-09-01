using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "lil boat";
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine(name.Trim().Length);
            Console.WriteLine(name.Replace(" ", string.Empty).Length);

            var names = name.Split(' ');
            string firstname = names[0];
            string lastname = names[1];

            Console.WriteLine("Your firstname is: " + firstname + 
            " and consists of " + firstname.Trim().Length + " letters");

            Console.WriteLine(lastname + lastname.Trim().Length);

            foreach (char item in firstname)
            {
                Console.WriteLine("---->"+item);
            }
            foreach (char item in lastname) {
                Console.WriteLine("----->" + item);
            }

            char[] arrayname = name.ToCharArray();

            for (int i = (name.Trim().Length-1); i >= 0; i--)
            {
                Console.WriteLine(arrayname[i]);
            }

            for (int i = 0; i < (name.Trim().Length); i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(name[i].ToString().ToUpper());
                }
                else {
                    Console.Write(name[i].ToString().ToLower());
                }
                
            }
            for (int i = 0; i < (name.Trim().Length); i++) {
                switch(arrayname[i]){
                    case 'e':
                        Console.Write("3");
                        break;
                    case 'a':
                        Console.Write("4");
                        break;
                    case 'l':
                        Console.Write("1");
                        break;
                    case 't':
                        Console.Write("7");
                        break;
                    default:
                        Console.Write(arrayname[i]);
                        break;
                }
            }


                Console.ReadLine();
            
        }
    }
}

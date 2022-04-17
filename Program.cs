using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tasks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter gross income: ");
            string g = Console.ReadLine();
            double gross = double.Parse(g), net = 0.0;


            if (gross <= 1000)
            {
                Console.WriteLine("Your net salary is: $" + gross);
            }
            if (gross > 1000)
            {
                if (gross > 1000 && gross <= 3000)
                {
                    net = gross - ((gross - 1000) * 0.1) - ((gross - 1000) * 0.15);
                    Console.WriteLine("Your net salary is: $" + net);
                }else
                {
                    net = gross - ((gross - 1000) * 0.1) - 300;
                    Console.WriteLine("Your net salary is: $" + net);
                }
            }
            Console.ReadKey();
        }
    }
}

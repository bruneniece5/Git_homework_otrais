using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Hello world!\n Press any key to exit!");
            int x, y, c = 0;

            for (int i = 0; i == c; i++)
            {
                try
                {
                    Console.Write("\n Ievadiet vienu skaitli:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Ievadiet otru skaitli: ");
                    y = Int32.Parse(Console.ReadLine());

                }
                catch (Exception error)
                {
                    Console.WriteLine("\n " + error.Message);
                    c++;
                }
            }

            Console.ReadKey();

            Console.ReadKey();

        }
    }
}

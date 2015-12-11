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
            Console.WriteLine("\n Hello world!\n");
            int x, y, c = 0;

            for (int i = 0; i == c; i++)
            {
                try
                {
                    Console.Write("\n Ievadiet vienu skaitli:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Ievadiet otru skaitli: ");
                    y = Int32.Parse(Console.ReadLine());
                  int  z = x * y;

                    Console.WriteLine("\n x * y = " + z);

                    if (z <= 0) Console.WriteLine(" Nav izskaitlots z!");
                    else
                    {
                        for (int r = 1; r <= z; r++)
                        {
                            Console.WriteLine(" " + r + ". *");
                        }
                    }



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

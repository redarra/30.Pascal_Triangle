using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Pascal_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows you wish to see in pascal triangle:");

            //Freeze console
            int var = int.Parse(Console.ReadLine());
            int rows = var, val = 1;
            
            for (int i = 0; i < rows; i++)
            {
                for (int blank = 1; blank <= rows - i; blank++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
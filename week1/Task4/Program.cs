using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4

{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int n = int.Parse(line1);
            string[,] array = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i)
                        array[i, j] = "[*]";
                    else array[i, j] = " ";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}

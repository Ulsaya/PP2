using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string s = Console.ReadLine();
                int n = int.Parse(s);
                string k = Console.ReadLine();
                string[] arr = k.Split();
                int[] numbers = new int[n * 2];
                int cnt = -1;
                for (int i = 0; i < n; i++)
                {
                    cnt++;
                    numbers[cnt] = int.Parse(arr[i]);
                    cnt++;
                    numbers[cnt] = int.Parse(arr[i]);
                }
                foreach (int num in numbers)
                {
                    Console.Write(num);
                    Console.Write(' ');
                }
            
        }
    }
}

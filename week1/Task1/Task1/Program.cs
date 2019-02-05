using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool prime(int n)
        {
        
                if (n == 1)
                    return false;
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;

                return true;
            }
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int d = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split();
            int cnt = 0;
            List<int> array = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {

                int num = int.Parse(arr[i]);

                if (prime(num) == true)
                {
                    cnt++;
                    array.Add(num);
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }


        }
         
        
    }
}

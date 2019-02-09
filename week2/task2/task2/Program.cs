using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool prime(int d)
        {
            for (int i = 2; i < d; i++)
            {
                if (d % i == 0)
                    return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\text.txt"); 
            string k = sr.ReadToEnd();
            string[] arr = k.Split(' ');
            sr.Close();


            StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\Desktop\text1.txt");
            string res = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int number = int.Parse(arr[i]);
                if (prime(number))
                {
                    res = res + number + ' ';
                }

            }
            sw.Write(res);
            sw.Close();
        }
    }
}

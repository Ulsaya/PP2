using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static bool polindrome(string k)
        {
            int n = k.Length; //ababa n= 5
            for (int i=0; i<k.Length; i++) //k[0]!= k[5-0-1]
            {
                if (k[i] != k[n -i -1])
                {
                    return false;
                }
            }
              return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\key.txt");// читает текстовые файлы
            string k = sr.ReadToEnd();//читает все входные данные до конца потока
            if (polindrome(k) == true)
            {
                Console.WriteLine("Yes");
            
            }
            else
            {
                Console.WriteLine("No");
            }
            sr.Close();

        }
    }
}

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
            
                string s = Console.ReadLine(); //read the first line 
                int n = int.Parse(s);//convert it to integer
                string k = Console.ReadLine();//read the second line
                string[] arr = k.Split();//separate the elements of an array by ' '
                int[] numbers = new int[n * 2];//double all elements of an array 
                int cnt = -1; //variable cnt = -1 to make cnt=0 during the cycle 
                for (int i = 0; i < n; i++)
                {
                    cnt++; //add +1 to cnt each time it goes through a cycle
                    numbers[cnt] = int.Parse(arr[i]); //convert numbers in integer
                    cnt++;
                    numbers[cnt] = int.Parse(arr[i]);
                }
                foreach (int num in numbers) //foreach executes a block of code on each element in an array
            {
                    Console.Write(num); //output doubled numbers 
                    Console.Write(' '); //output it with spaces between elements
                }
            
        }
    }
}

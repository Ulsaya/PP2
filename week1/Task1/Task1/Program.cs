using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program //class definition that contains bool
  
    {
        static bool prime(int n)
        {
        
                if (n == 1) //enter the condition (by task1, number "1" won't lead with remaining prime numbers)
                    return false;
                for (int i = 2; i < n; i++)//enter the cycle
                    if (n % i == 0)// Condition: if n divide by i and remaider = 0, then the number is not prime 
                        return false;// so it's false

                return true; //else it's true
            }
        static void Main(string[] args) // Another class definition that contains Main, the program entry point.
        {

            string s = Console.ReadLine(); //we enter some string s and read it
            int d = int.Parse(s); //int.Parse() is responsible for converting from  string to int
            string k = Console.ReadLine();//we enter the second string k and read it
            string[] arr = k.Split('_'); //Split is responsible for separation of elements of an array by ' '
            int cnt = 0; //enter some variable,it's empty for now
            List<int> array = new List<int>(); //we create some container to store the data
            for (int i = 0; i < arr.Length; i++) //enter the cycle
            {

                int num = int.Parse(arr[i]); // convert "num" to the integer 

                if (prime(num) == true)
                {
                    cnt++; //it counts the number of prime numbers 
                    array.Add(num); //and add them to the array
                }
            }
            Console.WriteLine(cnt); //we output on the first line the amount of prime numbers excluding 1 
            for (int i = 0; i < array.Count; i++) //cycle
            {
                Console.Write(array[i]); //output on the second line all prime numbers 
                Console.Write(' ');// spaces between prime numbers
            }


        }
         
        
    }
}

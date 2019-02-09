using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{ 
    class Student
    {
        public string name;
        public string id;
        public int yearofstudy;

        public Student(string name, string id) //method "student" with 2 string type variables 
        {
            this.name = name; //this.variable is responcible for access to the currnt class
            this.id = id;
            yearofstudy = 0;
        }

        public string getName()//returns the name of member
        {
            return this.name;
        }
        public string getID();
        {
            return this.id;
        }

        public int Increment()
        {
           return ++yearofstudy;
        }
    }
}


    


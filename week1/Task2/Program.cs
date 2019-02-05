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

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            yearofstudy = 0;
        }

        public string getName()
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


    


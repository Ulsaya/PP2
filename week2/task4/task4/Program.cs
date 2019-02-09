using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void CreateCopyDelete(string path, string path1)
        {
            string newpath = Path.Combine(path, "text.txt");//комбинирует 2 стринга и сохрнаяет в newpath string
            File.Create(newpath); //perdaem to new path 
            File.Copy(newpath, path1);//sozdaem kopiyu po zadaniyu
            File.Delete(newpath);//udalyaet original "newpath"
        }
        static void Main(string[] args)
        {
            CreateCopyDelete(@"C:\Users\ASUS\Desktop\example1", @"C:\Users\ASUS\Desktop\example2"); //"nazvanie metoda"(nazvanie papki v kotoroi original, nazvanie v kotoroi budet kopiya)

        }
    }
}

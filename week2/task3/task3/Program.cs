using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void printing(DirectoryInfo d)
        {
            DirectoryInfo[] directoryInfos = d.GetDirectories();
            FileInfo[] fileInfos = f.GetFiles();

           static void Main(string[] args)
            { 
            string path = @"C:\Users\ASUS\Desktop\pp2";
            DirectoryInfo dInfo = new DirectoryInfo(path); // directory info - информация о папке
            FileInfo[] fileInfos = dInfo.GetFiles(); // создаем массив о файлах
            DirectoryInfo[] directoryInfos = dInfo.GetDirectories();//создаем массив о папках
            Console.WriteLine("Files:");

            foreach (FileInfo f in fileInfos)//цикл о файлах
            {
                Console.WriteLine(f.Name);//выводит все названия файлов 
            }
            Console.WriteLine("Directories:");
            foreach (DirectoryInfo d in directoryInfos)//цикл о папках
            {
                Console.WriteLine(d.Name);//выводит названия папок
            }
            
        }
    }
}

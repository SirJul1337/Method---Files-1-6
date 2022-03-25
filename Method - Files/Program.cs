using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Method___Files
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string file = @".\StarWars.txt";
            string path = @".\";
            string folder = @".\Droids";


            //Opgave 1
            Console.WriteLine("Opgave 1 \n");
            Writetofile(file);
            Console.WriteLine(file + " Has been created");

            //Opgave 2
            Console.WriteLine("\nOpgave 2 \n");
            string content = ReadFile(file);
         
            Console.WriteLine("Read "+content+ " From");


            //Opgave 3
            Console.WriteLine("\nOpgave 3 \n");
            DeleteFile(file);
            Console.WriteLine(file + " Has been deleted");


            //Opgave 4
            Console.WriteLine("\nOpgave 4 \n");
            CreateFolder(folder);
            Console.WriteLine(folder +" Has been created");

            //Opgave 5
            Console.WriteLine("\nOpgave 5 \n");
            DeleteFolder(folder);
            Console.WriteLine(folder+ " Has been deleted");


            //Opgave 6
            Console.WriteLine("\nOpgave 6 \n");
            GetFiles(path);



            Console.ReadLine();
        }
        public static void Writetofile(string file)
        {
            File.WriteAllText(file, "Han shot first");
        }

        public static string ReadFile(string file)
        {
            string content = File.ReadAllText(file);
            return content;
        }

        public static void DeleteFile(string file)
        {
            File.Delete(file);
        }
        public static void GetFiles(string path)
        {
            foreach(string file in Directory.GetFiles(path))
            {
               Console.WriteLine(file);
            }
        }
        public static void CreateFolder(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
        }
        public static void DeleteFolder(string folderPath)
        {
            Directory.Delete(folderPath, true);
        }
        
        
    }
}

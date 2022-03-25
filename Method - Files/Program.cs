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
            string folder = @".\Droids";
            string path = "";
            string text = "";
            string[] actors = new string[] { "Mark Hamill", "Harrison Ford", "Carrie Fisher" };



            //Opgave 1

            Console.WriteLine("Opgave 1 \n");
            text = "Han shot first";
            WriteToFile(file, text);
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
            path = @".\Droids\R2D2";
            text = "beep bop";

            WriteToFile(path, text);
            Console.WriteLine(folder +" Has been created");

            //Opgave 5
            Console.WriteLine("\nOpgave 5 \n");
            DeleteFolder(folder);
            Console.WriteLine(folder+ " Has been deleted");


            //Opgave 6
            Console.WriteLine("\nOpgave 6 \n");

            //Creating the folders for the assignment
            CreateFolder(folder);
            folder = @".\Droids\Astromech";
            CreateFolder(folder);
            folder = @".\Droids\Protocol";
            CreateFolder(folder);

            //Creating files for the assignment
            path = @".\Droids\Astromech\R2D2.txt";
            text = "beep bop";
            WriteToFile(path, text);

            path = @".\Droids\Protocol\C3P0.txt";
            text = "sir!";
            WriteToFile(path, text);

            path = @".\Droids";
            Enumeratiton(path);



            //Opgave 5 #StreamWriter
            Console.WriteLine("\nOpgave 5 Streamline\n");
            path = @".\Movies.txt";
            text = "Star Wars\nThe Empire, Strikes Back\nReturn Of The Jedi\n";
            WriteToFile(path, text);

            ReadFromFileStream(path);


            //Opgave 6 #Streamwriter
            Console.WriteLine("\nOpgave 6 Streamline\n");
            path = @".\Actors.txt";
            text = "";
            WriteToFile(path, text);
            WriteToFileStream(actors, path);
            ReadFromFileStream(path);



            Console.ReadLine();
        }
        public static void WriteToFile(string file, string text)
        {
            File.WriteAllText(file, text);
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
        public static string [] Enumeratiton(string path)
        {
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

            for (int i = 0; i< files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            return files;
        }
        public static void CreateFolder(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
        }
        public static void DeleteFolder(string folderPath)
        {
            Directory.Delete(folderPath, true);
        }
        public static void ReadFromFileStream(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            file.Close();
        }
        public static void WriteToFileStream(string [] actors, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            foreach (string actor in actors)
            {
                writer.WriteLine(actor);
            }
            writer.Close();
        }
        
        
    }
}

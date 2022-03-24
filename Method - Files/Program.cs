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
            string newFolder = @".\Droids";
            string deleteFolder = @".\Droids";
            string deleteFile = @".\StarWars.txt";
            string searchPatteren = "*.jpg";
            SearchOption searchOption = SearchOption.TopDirectoryOnly;
            int menu = 0;
            Console.WriteLine
            (
                "============================================\n" +
                "                H1 Queue Operation Menu     \n" +
                "============================================\n"+
                "1. Add File \n2. Delete file \n3. Display files\n4. Add folder \n5. Search for file in folder \n6. Exit\n"+
                "\nEnter your choice"

            );
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("File "+file+" Has been created");
                    CreateFile(file);
                    break;
                case 2:
                    DeleteFile(file);
                    break;
                case 3:
                    string getFiles=GetFiles(newFolder, searchPatteren, searchOption);
                    Console.WriteLine(getFiles);
                    break;
                case 4:
                    CreateFolder(newFolder);
                    break;
                case 5:
                    break;
                case 6:
                    break;

            }
            //Writetofile(file);
            //string content = ReadFile(file);
            //Console.WriteLine(content);
            //DeleteFolder(deleteFolder);
            Console.ReadLine();
        }
        public static void Writetofile(string file)
        {
            using (StreamWriter sw = new StreamWriter(
                new FileStream(file, FileMode.Create)))
            {
                sw.Write("");
            }
            File.WriteAllText(file, "Han shot first");
        }

        public static string ReadFile(string file)
        {
            string content = File.ReadAllText(file);
            return content;
        }
        public static void CreateFile(string file)
        {
            File.Delete(file);

        }
        public static void DeleteFile(string file)
        {
            File.Delete(file);
        }
        //public static void GetFiles(string path)
        //{
        //    foreach(string file in Directory.GetFiles(path))
        //    {
        //        Console.WriteLine(file);
        //    }
        //}
        public static string GetFiles(string path, string searchPatteren, SearchOption searchOption)
        {
            string output = "";
            string [] files = Directory.GetFiles(path, "*.txt", searchOption);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
                output += files[i]+"\n";
            }
            return output;
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

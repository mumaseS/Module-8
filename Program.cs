using System;
using System.IO;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
            
        }

        
        static void GetCatalogs()
        {
            string dirName = "E:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach (string d in dirs)
                    Console.WriteLine(d);
                Console.WriteLine();

                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);

                foreach (string s in files) 
                    Console.WriteLine(s);

                try
                {
                    DirectoryInfo newDirectory = new DirectoryInfo(@"C:\Users\greed\Desktop\testFolder");
                    if (!newDirectory.Exists)
                        newDirectory.Create();
                                       
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\greed\Desktop\testFolder");
                    string trashPath = @"C:\$RECYCLE.Bin\testFolder";
                                       
                        dirInfo.MoveTo(trashPath);

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
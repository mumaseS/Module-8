using System;
using System.IO;

namespace DirectoryManager
{
   
 class FileManager
    {
        public static void Main(string[] args)
        {
            var fileInfo = new FileInfo(@"C:\Users\greed\Documents\TrainingVS22\Module 8\Program.cs");

           using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }
            
            
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }

         
        }
    }



}
// Время запуска: 24.07.2022 12:44:34

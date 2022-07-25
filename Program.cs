using System;
using System.IO;

namespace DirectoryManager
{
   
 class BinaryDomain
    {
        const string SettingsFileName = @"C:\Users\greed\Desktop\BinaryFile.bin";

        public static void Main(string[] args)
        {
            WriteData();
            ReadData();
        }

        static void WriteData()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                bw.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
            }
        }
        static void ReadData()
        {
            string dataOfCreation;
            

            if (File.Exists(SettingsFileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    dataOfCreation = reader.ReadString();
                    
                }

                Console.WriteLine( "Изменение " + dataOfCreation);
             
            }
        }
    }



}


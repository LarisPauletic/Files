using System;
using System.IO;
namespace FileKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite Vaše ime: ");
            string ime = Console.ReadLine();
            string datoteka = "ime.txt";
            
            if (File.Exists(datoteka))
            {
                
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                File.Copy(datoteka, "backup\\ime_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt");
               
                File.Delete(datoteka);
            }
           
            File.WriteAllText(datoteka, ime);
        }
    }
}
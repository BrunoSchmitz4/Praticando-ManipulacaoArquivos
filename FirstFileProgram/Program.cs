using System;

using System.IO;
// Inclusão do namespace necessário

namespace FirstFileProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\OS0050\Documents\file1.txt";
            string sourcePath = @"C:\Users\OS0050\Documents\file1.txt";
            string targetPath = @"C:\Users\OS0050\Documents\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}catch (IOException ex)
            //{
            //    Console.WriteLine("An error occurred! " + ex.Message);
            //}


            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.Write("An error occurred!: " + ex.Message);
            //}
        }
    }
}
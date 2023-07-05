﻿using System;

using System.IO;
// Inclusão do namespace necessário

namespace FirstFileProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\OS0050\Documents\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.Write("An error occurred!: " + ex.Message);
            }
        }
    }
}
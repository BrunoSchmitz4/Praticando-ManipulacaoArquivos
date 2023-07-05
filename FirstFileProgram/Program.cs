using System;

using System.IO;
using System.Collections.Generic;
// Inclusão do namespace necessário

namespace FirstFileProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Classes Directory e DirectoryInfo
            // Também fazem parte do namespace system.IO
            // Contém operações com pastas, como: create, enumerate, get files etc...

            // As mesmas regras de Files (membros estáticos, verificação de segurança etc)
            // valem para Directory. E as mesmas regras de FileInfo valem para DirectoryInfo
            
            string path = @"C:\Users\OS0050\Documents\myFolder\file1.txt";
            string sourcePath = @"C:\Users\OS0050\Documents\file1.txt";
            string targetPath = @"C:\Users\OS0050\Documents\file2.txt";


            //try
            //{
            //    IEnumerable<String> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Folders: ");
            //    foreach (String folderItem in folders)
            //    {
            //        Console.WriteLine(folderItem);
            //    }
            //    Console.WriteLine("Files: ");
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    foreach (String filesItem in files)
            //    {
            //        Console.WriteLine(filesItem);
            //    }

            //    Directory.CreateDirectory(path + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            // Classe Path
            // Realiza operações com strins que contém informãções de arquivos ou pastas.

            Console.WriteLine("Método GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("Método DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Método PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("Método GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("Método GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Método GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("Método GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("Método GetTempPath: " + Path.GetTempPath());
        }
    }
}
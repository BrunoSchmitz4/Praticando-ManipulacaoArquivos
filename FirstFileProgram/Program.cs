using System;

using System.IO;
// Inclusão do namespace necessário

namespace FirstFileProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criamos uma variável com um caminho para file1.txt
            string path1 = @"C:\Users\OS0050\Documents\file1.txt";
            // Então, criamos variáveis nulas, sendo uma 
            // do tipo superclasse FileStream, a outra,
            // do tipo superclasse StreamReader.
            StreamReader sr = null;

            // O try cria um objeto do tipo Filestream que
            // recebe de parâmetro o path1 e instrução do que fazer.
            // No caso, abrir file1.txt.

            // Aberto, sr cria um objeto StreamReader,
            // recebendo os valores do filestream.
            // Então, criasse uma variável que lê as linhas da
            // variável streamreader com os dados de filestream.

            // Obs: versão mais enxuta e prática
            try
            {
                sr = File.OpenText(path1);
                
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    Console.WriteLine(lines);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }
            // Contudo, as streams são recursos externos, pra interagirmos
            // com o sistema operacional. Acima pedimos pra abrir um arquivo.
            // Este recurso não é gerenciado pelo CLR do .NET.
            // Por isso, deve ser fechado manualmente com finally.
            // Ex: forma explícita e funcional.
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
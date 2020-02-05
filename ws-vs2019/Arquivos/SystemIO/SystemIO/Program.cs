using System;
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\EDUARDO\Desktop\Curso de C# - Udemy\ws-vs2019\Arquivos\SystemIO\file1.txt";
            string targetPath = @"C:\Users\EDUARDO\Desktop\Curso de C# - Udemy\ws-vs2019\Arquivos\SystemIO\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Le o caminho do arquivo
                fileInfo.CopyTo(targetPath); // Faz uam cópia do arquivo para o target
                string[] lines = File.ReadAllLines(sourcePath); // Guarda todas as linhas do arquivo num vetor
                
                foreach(string line in lines)// Imprime as linhas do vetor na tela
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}

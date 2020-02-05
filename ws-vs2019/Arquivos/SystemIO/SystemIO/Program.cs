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
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            }
            catch(IOException e)
            {
                Console.WriteLine("ERRO! ");
                Console.WriteLine(e.Message);
            }


        }
    }
}



// ================== STREAM READER ================
/*
string path = @"C:\Users\EDUARDO\Desktop\Curso de C# - Udemy\ws-vs2019\Arquivos\SystemIO\file1.txt";

try
{
    //using (FileStream fs = new FileStream(path, FileMode.Open)) - Substituido pelo File.OpenText
    //{
    // utilizando a forma masi simples de isntanciação para não precisar usar 2 blocos Using.
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream) // estrutura pra ler todas as linhas do arquivo até chegar no final
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
    //}
}
catch (IOException e)
{
    Console.WriteLine("ERRO: ");
    Console.WriteLine(e.Message);
}






/*
// ================= FILE STREAM / STREAM READER =================
try
    { 
// estes recursos são externos e não são processados no .NET
// É preciso fechar os recursos manualmente de forma explicita e manual

//fs = new FileStream(path, FileMode.Open); // instancia o file stream 

// utilizar a classe file e file info para ajudar a instanciar streaming

// sr = new StreamReader(fs);

 // FileStream fs = null;
//StreamReader sr = null;

sr = File.OpenText(path);
while (!sr.EndOfStream) // estrutura pra ler todas as linhas do arquivo até chegar no final
{
    string line = sr.ReadLine();
    Console.WriteLine(line);
}

}
catch(IOException e)
{
Console.WriteLine("Ocorreu um erro: ");
Console.WriteLine(e.Message);
}
finally
{
if(sr != null) sr.Close();
// if (fs != null) fs.Close();
}






// ================ FILE INFO / FILE =================
/*
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
*/

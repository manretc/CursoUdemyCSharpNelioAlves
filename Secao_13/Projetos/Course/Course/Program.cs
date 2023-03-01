using System;
using System.IO;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            //Aula 186
            /*
            string sourcePath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file1.txt";
            string targetPath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            */

            //Aula 187
            /*
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);

                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {

                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
                //if (fs!=null) fs.Close();
            }
            */

            //Aula 188
            /*string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file1.txt";
            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                //using (StreamReader sr = new StreamReader(fs))
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            */
            //Aula 189
            /*string sourcePath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file1.txt";
            string targetPath = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            */
            //Aula 190
            /*string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                foreach (string s in files) {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }*/

            //Aula 191
            string path = @"C:\D2Ponto\GoogleDrive\Udemy\C# Completo\Secao_13\Projetos\Arquivos\file1.txt";
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            

            Console.ReadKey();

        }
    }
}

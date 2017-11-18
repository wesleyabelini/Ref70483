using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\teste\";
            string file = @"C:\teste\teste.txt";
            string pathDest = @"C:\";

            ListAllFiles(path);
            DeletingFile(file);

            MovingFile(file, pathDest);
            CopyFile(file, pathDest);
        }

        public static void ListAllFiles(string directory)
        {
            /* 
             * Lista all files in a path
             * */

            foreach (string file in Directory.GetFiles(directory))
            {
                Console.WriteLine(file);
            }
        }

        public static void DeletingFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            else
            {
                //codigo funcional para o exemplo

                File.Create(file).Close(); // cria o arquivo fecha a utilização para disponibilizar para outro processo
            }

            FileInfo fileInfo = new FileInfo(file);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }

        public static void MovingFile(string file, string destPath)
        {
            File.CreateText(file).Close();
            File.Move(file, destPath);

            //again

            FileInfo fileInfo = new FileInfo(file);
            fileInfo.MoveTo(destPath);
        }

        public static void CopyFile(string file, string destPath)
        {
            File.CreateText(file).Close();
            File.Copy(file, destPath);

            FileInfo info = new FileInfo(file);
            info.CopyTo(destPath);
        }
    }
}

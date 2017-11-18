using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorio = @"C:\Temp\ProgrammingInCSharp\Directory";
            string diretorioInfo = @"C:\Temp\ProgrammingInCSharp\DirectoryInfo";

            CreateDirectory(diretorio, diretorioInfo);
            DeleteDirectory(diretorio, diretorioInfo);

            ListAllFiles(@"C:\");

            MovingDirectory();

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Program Files");
            ListDirectories(directoryInfo, "*a*", 5, 0);
        }

        public static void CreateDirectory(string diretorio, string diretorioInfo)
        {
            //Creating a directory

            var directory = Directory.CreateDirectory(diretorio);
            var directoryInfo = new DirectoryInfo(diretorioInfo);
        }

        public static void DeleteDirectory(string diretorio, string diretorioInfo)
        {
            //Deleting a directory

            if (Directory.Exists(diretorio))
            {
                Directory.Delete(diretorio);
            }

            var directoryInfo = new DirectoryInfo(diretorioInfo);
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }

        public static void SettingAccesscontrol()
        {
            DirectoryInfo info = new DirectoryInfo("TestDirectory");
            info.Create();
            DirectorySecurity directorySecurity = info.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule("everyone", FileSystemRights.ReadAndExecute, 
                AccessControlType.Allow));

            info.SetAccessControl(directorySecurity);
        }

        private static void ListDirectories(DirectoryInfo info, string searchPattern, int maxLevel, int currentLevel)
        {
            //List Directories Tree

            if(currentLevel >= maxLevel)
            {
                return;
            }

            string indend = new string('-', currentLevel);

            try
            {
                DirectoryInfo[] subDirectories = info.GetDirectories(searchPattern);

                foreach(DirectoryInfo subDirectory in subDirectories)
                {
                    Console.WriteLine(indend + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine(indend + "Can't access: " + info.Name);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(indend + " Can't find: " + info.Name);
                return;
            }
        }

        public static void MovingDirectory()
        {
            //Moving directory -- ERROR

            Directory.Move(@"C:\source", @"C:\destination");

            DirectoryInfo info = new DirectoryInfo(@"C:\Source");
            info.MoveTo(@"C:\destination");
        }
    }
}

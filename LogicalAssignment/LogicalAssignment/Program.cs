using System;
using System.IO;

namespace LogicalAssignment
{
    class Program
    {
        public static void DisplayFolderFiles(DirectoryInfo path)
        {
            try
            {
                var subFolders = path.GetDirectories();
                foreach (var subFolder in subFolders)
                {
                    Console.WriteLine("\t-" + subFolder.FullName);
                    DisplayFolderFiles(subFolder);

                    var files = path.GetFiles();
                    foreach (var file in files)
                        Console.WriteLine("\t\t~" + file.FullName);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Drive Name: ");
                DriveInfo driveName = new DriveInfo(Console.ReadLine());
                if (Directory.Exists(Convert.ToString(driveName)))
                {
                    var folders = (driveName.RootDirectory).GetDirectories();
                    foreach (var folder in folders)
                    {
                        Console.WriteLine(folder.FullName);
                        DisplayFolderFiles(folder);
                    }

                    var files = (driveName.RootDirectory).GetFiles();
                    foreach (var file in files)
                        Console.WriteLine("\t\t~" + file.FullName);
                }
                else
                    Console.WriteLine("Invalid Drive Name");
            }

            catch
            {
                Console.WriteLine("Drive Name Should Be Character");
            }

        }

    }
}

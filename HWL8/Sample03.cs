using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWL8
{
    internal class Sample03
    {
        static void Main(string[] args)
        {
            // Directory, File, FileInfo, DirectoryInfo

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\source\Lesson8\Seminar");

            Console.WriteLine("FullName: {0}", directoryInfo.FullName);
            Console.WriteLine("Name: {0}", directoryInfo.Name);
            Console.WriteLine("Creation: {0}", directoryInfo.CreationTime);
            Console.WriteLine("Root: {0}", directoryInfo.Root);

            Console.WriteLine("\n***\n");

            PrintDir(new DirectoryInfo(@"D:\source\Lesson8"), "", true);

            Console.ReadKey(true);
        }

        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            if (lastDirectory)
            {
                Console.Write("└─");
                indent += "  "; // indent = indent + "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│ ";
            }

            Console.WriteLine(dir.Name);

            //dir.GetFiles

            DirectoryInfo[] subDirs = dir.GetDirectories();

            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
            }

        }
    }
}

using Roman.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWL8
{
    internal class Sample01
    {
        static void Main(string[] args)
        {

            Console.Title = Properties.Settings.Default.ApplicationName;

            Utils.PrintInfo(8, "Коровкин Роман Александрович");

            Console.WriteLine(Properties.Settings.Default.UserSettings1);
            Console.WriteLine(Properties.Settings.Default.UserSettings2);

            Properties.Settings.Default.UserSettings1 = "Hello, GeekBrains!";
            Properties.Settings.Default.UserSettings2 += 10;
            //Properties.Settings.Default.Save();

            Console.WriteLine(Properties.Settings.Default.UserSettings1);
            Console.WriteLine(Properties.Settings.Default.UserSettings2);

            // %USERPROFILE%\AppData\Local\

            //Console.ReadLine();
            Console.ReadKey(true);
        }
    }
}

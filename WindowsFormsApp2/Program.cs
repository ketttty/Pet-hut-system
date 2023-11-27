using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public struct chongwu1
    {
        public static string type;
        public static string name;
        public static string color;
        public static string weight;
        public static string food;
    }
    public struct chongwu2
    {
        public static string type;
        public static string name;
        public static string color;
        public static string weight;
        public static string food;
    }

    public struct chongwu3
    {
        public static string type;
        public static string name;
        public static string color;
        public static string weight;
        public static string food;
    }
    public struct chongwu4
    {
        public static string type;
        public static string name;
        public static string color;
        public static string weight;
        public static string food;
    }
    public struct user
    {
        public static string name;
        public static string password;
    }


    internal static class Program
    {
       

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log());
        }
    }
  
}

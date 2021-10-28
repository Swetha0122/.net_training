using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate string call_print(string value);
    class Program
    {
        public static string print(string name)
        {
            return "Welcome " + name;
        }
        static void Main(string[] args)
        {
            call_print cp = new call_print(print);
            Console.WriteLine(cp("Swetha"));
            Console.ReadLine();
        }
    }
}

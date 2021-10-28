using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_method
{
    class Test
    {
        public static void Display<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.Display("Swetha");
            Test.Display(11);
            Console.ReadLine();
        }
    }
}

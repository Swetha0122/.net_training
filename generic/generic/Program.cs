using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Generic<T>
    {
        public T genericVariable;
        public void Display()
        {
            Console.WriteLine(this.genericVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> generic_int = new Generic<int>();
            generic_int.genericVariable = 11;
            Generic<string> generic_string = new Generic<string>();
            generic_string.genericVariable = "Swetha";
            generic_string.Display();
            generic_int.Display();
            Console.ReadLine();
        }
    }
}

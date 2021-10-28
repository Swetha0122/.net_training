using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_add
{
    class Genericadd<T>
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
            Genericadd<int> generic_int = new Genericadd<int>();
            generic_int.genericVariable = 11;
            Genericadd<string> generic_string = new Genericadd<string>();
       }
    }
}

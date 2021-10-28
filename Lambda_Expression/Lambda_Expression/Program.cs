using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> evennumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evennumbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

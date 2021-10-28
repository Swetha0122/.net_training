using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class Person
    {
        private string name;//field
        public string Name //property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
    }
    class Program
    {
            static void Main(string[] args)
            {
                Person myObj = new Person();
                myObj.Name = "Swetha";
                Console.WriteLine(myObj.Name);
                Console.ReadLine();

            }

    }
}

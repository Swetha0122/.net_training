using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    public class student
    {
        public int rollno;
        public string name;
        public void display_detail()
        {
            Console.WriteLine("The roll no is {0}", rollno);
            Console.WriteLine("The name is {0}", name);
        }
        public void display_detail(string name1)
        {
            Console.WriteLine("The roll no is {0}", rollno);
            Console.WriteLine("The name is {0}", name1);
        }
        //default constructor
        public student()
        {
            rollno = 12;
            name = "Abi";
        }
        //constructor overloading
        public student(int rollno1,string name1)
        {
            rollno = rollno1;
            name = name1;

        }


    }
}

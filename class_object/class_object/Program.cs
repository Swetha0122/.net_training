using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    class Program
    {
        static void Main(string[] args)
        {
            amrita_student studentinfo = new amrita_student();
            //student studentinfo = new student();
            studentinfo.name = "Balaswetha";
            studentinfo.rollno = 11;
            studentinfo.display_detail();
            Console.ReadLine();
             
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_details
{
    class amrita_college
    {
        public string College_name;
        public int College_code;
        public string Address;
        public int No_of_faculties;
        public int No_of_Students;

        public void display_detail()
        {
            Console.WriteLine("College name is {0}", College_name);
            Console.WriteLine("College code is {0}", College_code);
            Console.WriteLine("Address of the college {0}", Address);
            Console.WriteLine("No of faculties {0}", No_of_faculties);
            Console.WriteLine("No of students {0}", No_of_Students);
        }
        
    }
}

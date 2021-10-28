using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_details
{
    class Program
    {
        static void Main(string[] args)
        {
            amrita_college CollegeDetails = new amrita_college();
            CollegeDetails.College_name = "Amrita College of Engineering and Technology";
            CollegeDetails.College_code = 4972;
            CollegeDetails.Address = "Erachakulam, Nagercoil, Kanniyakumari";
            CollegeDetails.No_of_faculties = 150;
            CollegeDetails.No_of_Students = 500;

            CollegeDetails.display_detail();
            Console.ReadLine();

        }
    }
}

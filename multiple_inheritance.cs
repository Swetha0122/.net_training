using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public interface student
    {
        void studying()
       
    }
    public interface employee
    {
        void working()
       
    }
    public class swetha_student : student,employee
    {
        public void studying()
        {
            Console.WriteLine("Playing");
        }
        public void working()
        {
            Console.WriteLine("Working");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            swetha_student stud = new swetha_student();
            stud.playing();
            stud.studying();
            Console.ReadLine();
        }
    }
}

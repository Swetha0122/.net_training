using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public interface student
    {
        void studying();
      
         void playing();
    }
    public class swetha_student : student
    {
        public void playing()
        {
            Console.WriteLine("Playing");
        }
        public void studying();
        {
            Console.WriteLine("Playing");
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

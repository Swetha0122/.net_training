using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int no1 = 20;
                int no2 = 0;
                int divide = no1 / no2;
                Console.WriteLine(divide);
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }
    }
}

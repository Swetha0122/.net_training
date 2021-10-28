using System;

namespace employees_vote
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 20;
            if(age>=18)
            {
                Console.WriteLine("The employee is eligible for voting");
                
            }
            else
            {
                Console.WriteLine("The employee is not eligible for voting");
            }
            Console.ReadLine();
        }
    }
}

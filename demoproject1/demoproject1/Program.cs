using System;

namespace demoproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            short no1;
            int no2;
            double no3;

            //actual initialization
            no1 = 10;
            no2 = 20;
            no3 = no1 + no2;
            Console.WriteLine("a={0},b={1},c={2}",no1,no2,no3);
            Console.ReadKey();
                    }
    }
}

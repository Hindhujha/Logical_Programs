using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGICAL PROGRAMS");
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.FIBONACCI SERIES");
                Console.WriteLine("ENTER YOUR OPTION");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                   FibonacciSeries.Fibonacci_Series fibo=new FibonacciSeries.Fibonacci_Series();
                        fibo.Fibonacci();
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION: ");
                        break;
                }
            }
        }
    }
}

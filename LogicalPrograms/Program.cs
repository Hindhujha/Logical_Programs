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
                Console.WriteLine("2.PRIME NUMBER");
                Console.WriteLine("3.PERFECT NUMBER");
                Console.WriteLine("4.REVERSAL OF NUMBER");
                Console.WriteLine("5.STOPWATCH PROGRAM");
                Console.WriteLine("6.COUPON RANDOM NUMBERS");
                Console.WriteLine("ENTER YOUR OPTION");
              
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                   FibonacciSeries.Fibonacci_Series fibo=new FibonacciSeries.Fibonacci_Series();
                        fibo.Fibonacci();
                        break;
                    case 2:
                        Prime_Number.PrimeNumber prime=new Prime_Number.PrimeNumber();
                        prime.prime();
                        break;
                    case 3:
                        PerfectNumber.Perfect_Number num=new PerfectNumber.Perfect_Number();
                        num.perfect();
                        break;
                    case 4:
                        ReverseNumber.Reverse_Number reverse = new ReverseNumber.Reverse_Number();
                        reverse.Reverse();
                        break;
                    case 5:
                        StopWatch.Stop_Watch watch=new StopWatch.Stop_Watch();
                        watch.watch();
                        break;
                    case 6:
                        CouponNumber.Coupon_Number coupon = new CouponNumber.Coupon_Number();
                        coupon.coupon();
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION: ");
                        break;
                }
            }
        }
    }
}

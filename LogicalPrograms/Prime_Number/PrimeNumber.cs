using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.Prime_Number
{
    internal class PrimeNumber
    {
        public void prime()
        {
            int temp = 0;
            Console.WriteLine("ENTER A NUMBER");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N == 0 && N == 1)
            {
                Console.WriteLine(N + "is not a Prime Number");
            }
            else
            {
                for (int i = 2; i <= N/2 ; i++)
                {
                    if (N % i == 0)
                    {
                        Console.WriteLine(N + " is not a Prime Number");
                        temp = 1;
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(N + "is a Prime Number");
            }

        }
    }
}
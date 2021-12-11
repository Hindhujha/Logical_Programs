using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.PerfectNumber
{
    internal class Perfect_Number
    {
        public void perfect()
        {
            int sum = 0;
            Console.WriteLine("ENTER A NUMBER");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("IT IS A PERFECT NUMBER");
            }
            else
            {
                Console.WriteLine("NOT A PERFECT NUMBER");
            }

        }
    }
}
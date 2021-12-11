using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.ReverseNumber
{
    internal class Reverse_Number
    {
        public void Reverse()
        {
            int  n1, temp = 0;
            Console.WriteLine("ENTER A NUMBER");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                n1 = n % 10;
                temp = temp * 10 + n1;
                n /= 10;
            }
            Console.WriteLine("AFTER REVERSAL OF A NUMBER: " + temp);
        }
    }
}

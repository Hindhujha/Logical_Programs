using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.FibonacciSeries
{
    internal class Fibonacci_Series
    {
        public void Fibonacci()
        {

            int num1=0, num2=1, temp,number;
            Console.WriteLine("ENTER NUMBER OF ELEMENTS");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "" + num1 ,"" + num2);
            for(int i=2;i<=number;i++)
            {
                temp = num1 + num2;
                Console.WriteLine(temp);
                num1 = num2;
                num2= temp;
            }
        }
    }
}

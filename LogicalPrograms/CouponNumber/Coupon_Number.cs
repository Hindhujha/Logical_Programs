using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.CouponNumber
{
    internal class Coupon_Number
    {
        public void coupon()
        {
            int temp1,temp2;
          
            Console.WriteLine("HOW MANY DISTINCT COUPON NUMBERS");
            int N=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=N;i++)
            {
                Random rand=new Random();
                temp1=rand.Next(1,100);
                Console.WriteLine("RANDOM NUMBER IS:" + temp1);
                again:
                Random rand2 = new Random();
                temp2 = rand2.Next(1, 100);
                Console.WriteLine("RANDOM NUMBER IS:" + temp2);
               
                if (temp1 == temp2)
                {
                    goto again;
                }

            }
           
            Console.WriteLine("ALL ARE DISTINCT NUMBERS");
            }
    }
}


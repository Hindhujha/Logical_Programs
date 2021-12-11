using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.StopWatch
{
    internal class Stop_Watch
    {

        public void watch()
        {
            float elapsed_time = 0;
            Console.WriteLine("ENTER A START TIME BY CLICK 1");
            int start = Convert.ToInt32(Console.ReadLine());

            while (start == 1)
            {
                elapsed_time += 1;
                Console.WriteLine("IF STOP THE WATCH ENTER 0 OTHERWISE ENTER 2 TO CONTINUE WATCH");
                int stop = Convert.ToInt32(Console.ReadLine());
               
                if (stop == 0)
                {
                    break;
                }

            }
            Console.Write("ELAPSED TIME IN SECONDS : " + elapsed_time);
        }



    }
    
    
    
    }


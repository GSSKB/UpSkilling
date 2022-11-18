using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number_or_Not
{
    public class Prime
    {
        int n, i, m = 0, flag = 0;


        public void Display()
        {
            Console.Write("Enter the number to check whether it is Prime or not-----");

            n = int.Parse(Console.ReadLine());

            m = n / 2;

            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {

                    Console.Write("Entered number is not prime");
                    flag = 1;
                    break;
                }
            }

                if (flag == 0)
                    Console.Write("Entered number is prime");
            
        }
    }
}




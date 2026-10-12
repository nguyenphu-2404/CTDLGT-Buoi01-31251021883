using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace Bai_1
{
    public class Bai_1
    {
        public static void Main1()
        {
            //Bai1(-1000, -777777, -1000);
           
        }
        static void Bai1(int a, int b, int c)
        {
            int max = a;
            int min = a;
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    max = a;
                    min = c;
                }
                else
                {
                    max = a;
                    min = b;
                }
            }
            else if (a >= b && a <= c)
            {
                min = b;
                max = c;
            }
            else if (a <= b && a <= c)
            {
                if (b >= c)
                {
                    max = b;
                    min = a;
                }
                else
                {
                    max = c;
                    min = a;
                }
            }
            else if (a <= b && a >= c)
            {
                max = b;
                min = c;

            }
            float avg = (a + b + c) / 3f;
            Console.WriteLine($"Max is: {max}");
            Console.WriteLine($"Min is: {min}");
            Console.WriteLine($"Sum is: {a + b + c}");
            Console.WriteLine($"Average is: {avg:F2}");

        }
        

    }
}
    

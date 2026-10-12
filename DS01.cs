using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace DS01
{
    public class DS01
    {
        public static void Main()
        {
            //Bai1(-1000, -777777, -1000);
            Bai2(4);
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
        static void Bai2(int n)
        {
            if (2 <= n && n <= 100000)
            {
                int max = 0;
                int premax = 0;
                int[] array = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Nhap phan tu thu {j + 1}: ");
                    array[j] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (array[i] >= max && array[i] >= premax)
                    {
                        premax = max;
                        max = array[i];
                    }
                    if (array[i] < max && array[i] >= premax)
                    {
                        premax = array[i];
                        max = max;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (max == premax)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine($"{premax}, {max}");
                }

            }
        }
        static void bai3a(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());

            }
            int maxsum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sum1 = 0;
                for (int j = i; j < n; j++)
                {
                    sum1 += a[j];
                    if (sum1 > maxsum) maxsum = sum1;
                }
            }
        }
        static void bai3b(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());

            }
            int maxsum = a[0];
            int currentsum = a[0];
            for (int i = 1; i < n; i++)
            {
                currentsum = Math.Max(a[i], currentsum + a[i]);
                maxsum = Math.Max(maxsum, currentsum);
            }
        }


    }
}
    

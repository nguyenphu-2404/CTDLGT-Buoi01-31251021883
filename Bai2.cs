using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2
{
    public class Bai_2
    {
        public static void Main2()
        {
            Bai2(4);
            //55,8,9,5
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
    }
}

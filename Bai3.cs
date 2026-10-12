using System;
using System.Collections.Generic;
using System.Text;

namespace Cấu_trúc_dữ_liệu
{
    internal class Bai_3
    {
        public static void Main()
        {
            Bai3a(5);
            Bai3b(77);
        }
        static void Bai3a(int n)
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
        static void Bai3b(int n)
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

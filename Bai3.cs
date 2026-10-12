using System;
using System.Diagnostics; // Thêm thư viện này để dùng Stopwatch

namespace BaiTapThucHanh01
{
    class Program
    {
        public static void Main3()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            //-2 1 - 3 4 - 1 2 1 - 5 4


            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Bai3a(a);
            Bai3b(a);
        }

        static void Bai3a(int[] a)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int maxsum = int.MinValue;
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int sum1 = 0;
                for (int j = i; j < n; j++)
                {
                    sum1 += a[j];
                    if (sum1 > maxsum) maxsum = sum1;
                }
            }

            sw.Stop();

            Console.WriteLine($"[Bai 3a - Θ(n²)] Max Sum: {maxsum} | Thoi gian: {sw.Elapsed.TotalMilliseconds} ms");
        }

        static void Bai3b(int[] a)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int maxsum = a[0];
            int currentsum = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                currentsum = Math.Max(a[i], currentsum + a[i]);
                maxsum = Math.Max(maxsum, currentsum);
            }
            sw.Stop();

            Console.WriteLine($"[Bai 3b - Θ(n)]  Max Sum: {maxsum} | Thoi gian: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
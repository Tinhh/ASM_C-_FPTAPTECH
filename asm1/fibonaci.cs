using System;

namespace ConsoleApplication1
{
    public class fibonaci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 so n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int tongn = 1;
            for (int i = 0; i < n; i++)
            {
                tongn =fibonacci(i);
            }
            Console.WriteLine(tongn);
        }
        public static int fibonacci(int n) {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;

            if (n < 0) {
                return -1;
            } else if (n == 0 || n == 1) {
                return n;
            } else {
                for (int i = 2; i < n; i++) {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
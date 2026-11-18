using System;

class Program
{
    static long FiboLap(int n)
    {
        if (n <= 2) return 1;
        long f1 = 1, f2 = 1, fn = 1;
        for (int i = 3; i <= n; i++)
        {
            fn = f1 + f2;
            f1 = f2;
            f2 = fn;
        }
        return fn;
    }

    static void Main()
    {
        Console.Write("Nhap vi tri n cua so Fibonacci can tim: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"So Fibonacci thu {n} la: {FiboLap(n)}");
    }
}

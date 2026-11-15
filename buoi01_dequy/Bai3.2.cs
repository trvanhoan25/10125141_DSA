using System;

class Program
{
    static int TinhS2(int n)
    {
        if (n == 1) return 1;
        return TinhS2(n - 1) + n * n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS2(n)}");
    }
}

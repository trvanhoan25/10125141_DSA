using System;

class Program
{
    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS1(n)}");
    }
}

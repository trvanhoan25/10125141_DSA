using System;

class Program
{
    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }
}

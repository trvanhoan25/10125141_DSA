using System;

class Program
{
    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Uoc so le lon nhat cua {n} la: {UocLeMax(n)}");
    }
}

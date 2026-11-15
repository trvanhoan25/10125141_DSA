using System;

class Program
{
    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double TinhS4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

    static void Main()
    {
        Console.Write("Nhap co so x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{x}^{n} = {TinhS4(x, n)}");
    }
}

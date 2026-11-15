using System;

class Program
{
    static bool IsPerfect(int n)
    {
        if (n < 2) return false;
        int sum = 1;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i * i != n) sum += n / i;
            }
        }
        return sum == n;
    }

    static void Main()
    {
        Console.Write("Nhap n de liet ke so hoan hao nho hon n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write($"Cac so hoan hao nho hon {n}: ");
        for (int i = 1; i < n; i++)
            if (IsPerfect(i)) Console.Write(i + " ");
        Console.WriteLine();
    }
}

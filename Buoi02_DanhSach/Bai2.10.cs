using System;
using System.Text;

class Bai2_10
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập cấp của ma trận vuông n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] a = new int[n, n];

        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        bool laDonVi = true;
        bool laDoiXung = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j && a[i, j] != 1) laDonVi = false;
                if (i != j && a[i, j] != 0) laDonVi = false;
                if (a[i, j] != a[j, i]) laDoiXung = false;
            }
        }

        Console.WriteLine($"\nMa trận {(laDonVi ? "là" : "không phải là")} ma trận đơn vị.");
        Console.WriteLine($"Ma trận {(laDoiXung ? "là" : "không phải là")} ma trận đối xứng.");
    }
}
using System;
using System.Collections.Generic;
using System.Text;

class Bai2_8
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử của dãy: ");
        int m = int.Parse(Console.ReadLine());
        int[] daySo = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            daySo[i] = int.Parse(Console.ReadLine());
        }

        List<int> soNguyenTo = new List<int>();
        List<int> soChan = new List<int>();
        List<int> soHoanHao = new List<int>();

        foreach (int so in daySo)
        {
            if (LaSoNguyenTo(so)) soNguyenTo.Add(so);
            if (so % 2 == 0) soChan.Add(so);
            if (LaSoHoanHao(so)) soHoanHao.Add(so);
        }

        Console.WriteLine($"Các số nguyên tố: {(soNguyenTo.Count > 0 ? string.Join(", ", soNguyenTo) : "Không có")}");
        Console.WriteLine($"Các số chẵn: {(soChan.Count > 0 ? string.Join(", ", soChan) : "Không có")}");
        Console.WriteLine($"Các số hoàn hảo: {(soHoanHao.Count > 0 ? string.Join(", ", soHoanHao) : "Không có")}");
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool LaSoHoanHao(int n)
    {
        if (n <= 1) return false;
        int sum = 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i != n / i) sum += n / i;
            }
        }
        return sum == n;
    }
}
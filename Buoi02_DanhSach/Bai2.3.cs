using System;
using System.Text;

class Bai2_3
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n;
        do
        {
            Console.Write("Nhập cấp của ma trận vuông n (0 < n < 100): ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0 || n >= 100);

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

        Console.WriteLine("\nMa trận vừa nhập:");
        XuatMatRan(a, n);

        int tongTatCa = TinhTongTatCa(a, n);
        Console.WriteLine($"\na. Tổng tất cả các phần tử của ma trận: {tongTatCa}");

        int minDuong = TimGiaTriDuongNhoNhat(a, n);
        Console.WriteLine($"\nb. Giá trị dương nhỏ nhất của ma trận: {(minDuong != -1 ? minDuong.ToString() : "Không có số dương nào")}");

        int tongCheoPhu = TinhTongDuongCheoPhu(a, n);
        Console.WriteLine($"\nc. Tổng các phần tử nằm trên đường chéo phụ: {tongCheoPhu}");

        bool tangDanCheoChinh = KiemTraDuongCheoChinhTangDan(a, n);
        Console.WriteLine($"\nd. Các phần tử trên đường chéo chính {(tangDanCheoChinh ? "có" : "không")} tăng dần theo chiều từ góc trên bên trái xuống góc dưới bên phải.");
    }

    static void XuatMatRan(int[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int TinhTongTatCa(int[,] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tong += a[i, j];
            }
        }
        return tong;
    }

    static int TimGiaTriDuongNhoNhat(int[,] a, int n)
    {
        int min = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0)
                {
                    if (min == -1 || a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
        }
        return min;
    }

    static int TinhTongDuongCheoPhu(int[,] a, int n)
    {
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += a[i, n - 1 - i];
        }
        return tong;
    }

    static bool KiemTraDuongCheoChinhTangDan(int[,] a, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (a[i + 1, i + 1] <= a[i, i])
            {
                return false;
            }
        }
        return true;
    }
}
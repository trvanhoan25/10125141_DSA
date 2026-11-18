using System;
using System.Diagnostics.Tracing;
using System.Text;
class Bai2_1
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[100];

        Console.Write("Nhập phần tử:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\na[{i}]=");
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nCác phần tử trong mảng là: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + "\t");
        }
        Console.WriteLine();
        Console.Write("Nhập giá trị cần chèn:");
        int x = int.Parse(Console.ReadLine());
        int k;
        do
        {
            Console.Write("Nhập vị trí cần chèn:");
            k = int.Parse(Console.ReadLine());
        } while (k < 0 || k > n);
        for (int i = n; i > k; i--)
        {
            a[i] = a[i - 1];
        }
        a[k] = x;
        n++;
        Console.Write("Mảng sau khi chèn:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + "\t");
        }
        Console.WriteLine();

    }
}
using System;
using System.Text;

class Bai2_9
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số dòng m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] a = new int[m, n];
        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMa trận theo thứ tự xoắn ốc:");
        int top = 0, bottom = m - 1, left = 0, right = n - 1;
        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
                Console.Write(a[top, j] + " ");
            top++;

            for (int i = top; i <= bottom; i++)
                Console.Write(a[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    Console.Write(a[bottom, j] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(a[i, left] + " ");
                left++;
            }
        }
        Console.WriteLine();
    }
}
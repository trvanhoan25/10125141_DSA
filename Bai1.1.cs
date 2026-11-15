using System;

class BaiTap1
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int n = 1000;
        int[] arr = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 100001);
        }

        int maxVal = arr[0];
        int minVal = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
            }
            if (arr[i] < minVal)
            {
                minVal = arr[i];
            }
        }

        Console.WriteLine($"a. Số lớn nhất trong mảng là: {maxVal}");
        Console.WriteLine($"b. Số nhỏ nhất trong mảng là: {minVal}");
    }
}
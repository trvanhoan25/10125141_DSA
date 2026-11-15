using System;

class BaiTap4
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int n = 1000;
        int[] arr = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(0, 10000);
        }

        Console.WriteLine("a. Mảng ban đầu:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n");

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("b. Mảng sau khi sắp xếp tăng dần:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
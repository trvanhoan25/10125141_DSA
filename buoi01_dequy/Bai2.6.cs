using System;

class Program
{
    static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void Main()
    {
        double[] arr = { 3.5, 1.2, 9.8, 5.4, 2.1 };
        BubbleSort(arr);
        Console.WriteLine("Day sau khi sap xep:");
        foreach (var x in arr) Console.Write(x + "  ");
        Console.WriteLine();
    }
}

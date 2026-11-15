using System;
using System.Diagnostics;

class Program
{
    static int BinarySearchDeQuy(int[] arr, int left, int right, int key)
    {
        if (left > right) return -1;
        int mid = left + (right - left) / 2;
        if (arr[mid] == key) return mid;
        if (arr[mid] > key) return BinarySearchDeQuy(arr, left, mid - 1, key);
        return BinarySearchDeQuy(arr, mid + 1, right, key);
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int key = 15;
        int result = BinarySearchDeQuy(arr, 0, arr.Length - 1, key);
        Console.WriteLine(result != -1 ? $"Tim thay tai vi tri: {result}" : "Khong tim thay");
    }
}

using System;

class BaiTap5
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào số nguyên dương n (n >= 1): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            long result = 0;

            if (n == 1)
            {
                result = 0;
            }
            else if (n == 2)
            {
                result = 1;
            }
            else
            {
                long f1 = 0;
                long f2 = 1;
                for (int i = 3; i <= n; i++)
                {
                    result = f1 + f2;
                    f1 = f2;
                    f2 = result;
                }
            }

            Console.WriteLine($"Số Fibonacci thứ {n} là: {result}");
        }
        else
        {
            Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập số nguyên dương!");
        }
    }
}
using System;

class BaiTap3
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào một chuỗi: ");
        string input = Console.ReadLine() ?? "";

        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine($"Chuỗi đảo ngược: {reversed}");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Bai2_7
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập một chuỗi văn bản: ");
        string vanBan = Console.ReadLine();

        string chuanHoa = vanBan.ToLower();
        chuanHoa = Regex.Replace(chuanHoa, @"[^\w\s]", "");
        string[] cacTu = chuanHoa.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> tanSuat = new Dictionary<string, int>();
        foreach (string tu in cacTu)
        {
            if (tanSuat.ContainsKey(tu))
            {
                tanSuat[tu]++;
            }
            else
            {
                tanSuat[tu] = 1;
            }
        }

        Console.WriteLine("Số lần xuất hiện của mỗi từ:");
        foreach (KeyValuePair<string, int> pair in tanSuat.OrderBy(p => p.Key))
        {
            Console.WriteLine($"- '{pair.Key}': {pair.Value} lần");
        }
    }
}
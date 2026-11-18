using System;
using System.Text;

class Bai2_6
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng ngày (n): ");
        int n = int.Parse(Console.ReadLine());
        double[] nhietDo = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập nhiệt độ ngày {i + 1}: ");
            nhietDo[i] = double.Parse(Console.ReadLine());
        }

        double maxNhietDo = nhietDo[0];
        double minNhietDo = nhietDo[0];
        int ngayMax = 1;
        int ngayMin = 1;
        double tongNhietDo = nhietDo[0];

        for (int i = 1; i < n; i++)
        {
            tongNhietDo += nhietDo[i];
            if (nhietDo[i] > maxNhietDo)
            {
                maxNhietDo = nhietDo[i];
                ngayMax = i + 1;
            }
            if (nhietDo[i] < minNhietDo)
            {
                minNhietDo = nhietDo[i];
                ngayMin = i + 1;
            }
        }

        double trungBinh = tongNhietDo / n;
        Console.WriteLine($"Ngày có nhiệt độ cao nhất là ngày {ngayMax} với {maxNhietDo}°C");
        Console.WriteLine($"Ngày có nhiệt độ thấp nhất là ngày {ngayMin} với {minNhietDo}°C");
        Console.WriteLine($"Nhiệt độ trung bình tuần: {trungBinh:F2}°C");
    }
}
// Bài 1 
static long TinhTong1DenN(int n)
{
    if (n <= 1) return n;
    return n + TinhTong1DenN(n - 1);
}

static void Bai1CS()
{
    Console.Write("Nhập số nguyên dương n: ");
    if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
    {
        Console.WriteLine($"S({n}) = {TinhTong1DenN(n)}");
    }
    else
    {
        Console.WriteLine("Vui lòng nhập n >= 1!");
    }
}

// Bài 2
static string DaoNguocChuoi(string s)
{
    if (string.IsNullOrEmpty(s) || s.Length == 1)
        return s;
    return DaoNguocChuoi(s.Substring(1)) + s[0];
}

static void Bai2CS()
{
    Console.Write("Nhập chuỗi cần đảo ngược: ");
    string s = Console.ReadLine() ?? "";
    Console.WriteLine($"Chuỗi đảo ngược: \"{DaoNguocChuoi(s)}\"");
}

// Bài 3
static double TinhLuyThua(double x, int n)
{
    if (n == 0) return 1;
    if (n < 0) return 1.0 / TinhLuyThua(x, -n);
    return x * TinhLuyThua(x, n - 1);
}

static void Bai3CS()
{
    Console.Write("Nhập cơ sở x: ");
    if (double.TryParse(Console.ReadLine(), out double x))
    {
        Console.Write("Nhập số mũ nguyên n: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine($"{x}^{n} = {TinhLuyThua(x, n)}");
        }
    }
}

// Bài 4
static int TimMaxDeQuy(int[] arr, int n)
{
    if (n == 1) return arr[0];
    int maxConLai = TimMaxDeQuy(arr, n - 1);
    return arr[n - 1] > maxConLai ? arr[n - 1] : maxConLai;
}

static void Bai4CS()
{
    int[] arr = { 12, 45, 7, 89, 23, 89, 14 };
    Console.WriteLine("Mảng: " + string.Join(", ", arr));
    Console.WriteLine($"Phần tử lớn nhất: {TimMaxDeQuy(arr, arr.Length)}");
}

// Bài 5 
static int DemChuSo(int n)
{
    if (n < 10) return 1;
    return 1 + DemChuSo(n / 10);
}

static void Bai5CS()
{
    Console.Write("Nhập số nguyên dương n: ");
    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    {
        Console.WriteLine($"Số chữ số của {n} là: {DemChuSo(n)}");
    }
    else
    {
        Console.WriteLine("Vui lòng nhập số nguyên dương!");
    }
}

// Bài 6
static void ChuyenThapHaNoi(int n, char cotA, char cotB, char cotC)
{
    if (n == 1)
    {
        Console.WriteLine($"Chuyển 1 đĩa từ {cotA} -> {cotC}");
        return;
    }
    ChuyenThapHaNoi(n - 1, cotA, cotC, cotB);
    Console.WriteLine($"Chuyển 1 đĩa từ {cotA} -> {cotC}");
    ChuyenThapHaNoi(n - 1, cotB, cotA, cotC);
}
static void Bai6CS()
{
    Console.Write("Nhập số đĩa n: ");
    if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
    {
        ChuyenThapHaNoi(n, 'A', 'B', 'C');
    }
    else
    {
        Console.WriteLine("Vui lòng nhập số đĩa >= 1!");
    }
}

// Bài 7
static void SinhNhiPhan(int[] a, int i, int n)
{
    if (i == n)
    {
        Console.WriteLine(string.Join("", a));
        return;
    }

    a[i] = 0;
    SinhNhiPhan(a, i + 1, n);

    a[i] = 1;
    SinhNhiPhan(a, i + 1, n);
}

static void Bai7CS()
{
    Console.Write("Nhập độ dài dãy nhị phân n: ");
    if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
    {
        int[] a = new int[n];
        Console.WriteLine($"Các dãy nhị phân độ dài {n}:");
        SinhNhiPhan(a, 0, n);
    }
    else
    {
        Console.WriteLine("Vui lòng nhập n >= 1!");
    }
}

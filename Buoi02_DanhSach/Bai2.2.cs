using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string PhongBan { get; set; }
    public int LuongCoBan { get; set; }
    public int Thuong { get; set; }
    public int ThucLinh => LuongCoBan + Thuong;

    public void Nhap()
    {
        Console.Write("  - Nhập mã nhân viên: ");
        MaNV = Console.ReadLine();
        Console.Write("  - Nhập họ và tên: ");
        HoTen = Console.ReadLine();
        Console.Write("  - Nhập năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("  - Nhập phòng ban: ");
        PhongBan = Console.ReadLine();
        Console.Write("  - Nhập lương cơ bản: ");
        LuongCoBan = int.Parse(Console.ReadLine());
        Console.Write("  - Nhập thưởng: ");
        Thuong = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine($"Mã: {MaNV} | Họ tên: {HoTen,-15} | Năm sinh: {NamSinh} | Phòng: {PhongBan,-10} | Lương CB: {LuongCoBan} | Thưởng: {Thuong} | Thực lĩnh: {ThucLinh}");
    }
}

class Bai2_2
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng nhân viên trong công ty: ");
        int n = int.Parse(Console.ReadLine());

        List<NhanVien> danhSach = new List<NhanVien>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho nhân viên thứ {i + 1}:");
            NhanVien nv = new NhanVien();
            nv.Nhap();
            danhSach.Add(nv);
        }

        int tongThucLinh = danhSach.Sum(nv => nv.ThucLinh);
        Console.WriteLine($"Tổng thực lĩnh tháng của tất cả nhân viên: {tongThucLinh}");
        if (danhSach.Count > 0)
        {
            int minLuongCB = danhSach.Min(nv => nv.LuongCoBan);
            var nvThapNhat = danhSach.Where(nv => nv.LuongCoBan == minLuongCB).ToList();
            Console.WriteLine($"Danh sách nhân viên có lương cơ bản thấp nhất ({minLuongCB}):");
            foreach (var nv in nvThapNhat)
            {
                nv.Xuat();
            }
        }

        int demThuong = danhSach.Count(nv => nv.Thuong >= 1200000);
        Console.WriteLine($"Số lượng nhân viên có mức thưởng >= 1.200.000 là: {demThuong}");
        Console.WriteLine("Danh sách sau khi sắp xếp (Phòng ban tăng dần, Mã NV giảm dần):");
        var dsSapXep = danhSach
            .OrderBy(nv => nv.PhongBan)
            .ThenByDescending(nv => nv.MaNV)
            .ToList();

        foreach (var nv in dsSapXep)
        {
            nv.Xuat();
        }
        foreach (var nv in danhSach)
        {
            nv.LuongCoBan = (int)(nv.LuongCoBan * 1.05);
        }
        Console.WriteLine("Đã cập nhật tăng lương cơ bản thêm 5% cho tất cả nhân viên. Danh sách mới:");
        foreach (var nv in danhSach)
        {
            nv.Xuat();
        }
    }
}
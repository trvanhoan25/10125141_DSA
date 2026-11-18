using System;
using System.Text;

class Nut
{
    public int Data;
    public Nut Next;
    public Nut(int data)
    {
        Data = data;
        Next = null;
    }
}

class Bai5
{
    static Nut pHead = null;

    static void ThemCuoi(int x)
    {
        Nut newNode = new Nut(x);
        if (pHead == null)
        {
            pHead = newNode;
        }
        else
        {
            Nut current = pHead;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    static void Xuat()
    {
        Nut current = pHead;
        while (current != null)
        {
            Console.Write(current.Data + "\t");
            current = current.Next;
        }
        Console.WriteLine();
    }

    static int TimMax()
    {
        if (pHead == null) throw new Exception("Danh sách rỗng");
        int max = pHead.Data;
        Nut current = pHead.Next;
        while (current != null)
        {
            if (current.Data > max)
            {
                max = current.Data;
            }
            current = current.Next;
        }
        return max;
    }

    static int TinhTong()
    {
        int tong = 0;
        Nut current = pHead;
        while (current != null)
        {
            tong += current.Data;
            current = current.Next;
        }
        return tong;
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static int DemSoNguyenTo()
    {
        int count = 0;
        Nut current = pHead;
        while (current != null)
        {
            if (LaSoNguyenTo(current.Data))
            {
                count++;
            }
            current = current.Next;
        }
        return count;
    }

    static int DemSoAm()
    {
        int count = 0;
        Nut current = pHead;
        while (current != null)
        {
            if (current.Data < 0)
            {
                count++;
            }
            current = current.Next;
        }
        return count;
    }

    static int DemSoDuong()
    {
        int count = 0;
        Nut current = pHead;
        while (current != null)
        {
            if (current.Data > 0)
            {
                count++;
            }
            current = current.Next;
        }
        return count;
    }

    static int DemSoBangX(int x)
    {
        int count = 0;
        Nut current = pHead;
        while (current != null)
        {
            if (current.Data == x)
            {
                count++;
            }
            current = current.Next;
        }
        return count;
    }

    static int TimDuongNhoNhat()
    {
        Nut current = pHead;
        int min = -1;
        while (current != null)
        {
            if (current.Data > 0)
            {
                if (min == -1 || current.Data < min)
                {
                    min = current.Data;
                }
            }
            current = current.Next;
        }
        return min;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử của danh sách liên kết: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int val = int.Parse(Console.ReadLine());
            ThemCuoi(val);
        }

        Console.Write("\nDanh sách liên kết hiện tại: ");
        Xuat();

        if (pHead != null)
        {
            Console.WriteLine($"\na. Phần tử lớn nhất trong danh sách: {TimMax()}");
            Console.WriteLine($"b. Tổng các phần tử của danh sách: {TinhTong()}");
            Console.WriteLine($"c. Số lượng số nguyên tố trong danh sách: {DemSoNguyenTo()}");
            Console.WriteLine($"d. Số lượng số âm: {DemSoAm()}, Số lượng số dương: {DemSoDuong()}");

            Console.Write("Nhập số x để đếm số lượng phần tử bằng x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"e. Số lượng phần tử bằng {x}: {DemSoBangX(x)}");

            int minDuong = TimDuongNhoNhat();
            Console.WriteLine($"f. Phần tử dương nhỏ nhất trong danh sách: {(minDuong != -1 ? minDuong.ToString() : "Không có số dương nào")}");
        }
    }
}
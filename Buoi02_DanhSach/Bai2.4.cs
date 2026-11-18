using System;
using System.Text;

class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Program
{
    static Node pHead = null;

    static void ThemCuoi(int x)
    {
        Node newNode = new Node(x);
        if (pHead == null)
        {
            pHead = newNode;
        }
        else
        {
            Node current = pHead;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    static void Xuat()
    {
        Node current = pHead;
        while (current != null)
        {
            Console.Write(current.Data + "\t");
            current = current.Next;
        }
        Console.WriteLine();
    }

    static int DemX(int x)
    {
        int count = 0;
        Node current = pHead;
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
        Node current = pHead;
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

    static void XoaDauX(int x)
    {
        if (pHead == null) return;

        if (pHead.Data == x)
        {
            pHead = pHead.Next;
            return;
        }

        Node current = pHead;
        while (current.Next != null && current.Next.Data != x)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử của danh sách liên kết: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int val;
            do
            {
                Console.Write($"Nhập phần tử thứ {i + 1} (số nguyên dương): ");
                val = int.Parse(Console.ReadLine());
            } while (val <= 0);
            ThemCuoi(val);
        }

        Console.Write("\nDanh sách liên kết hiện tại: ");
        Xuat();

        Console.Write("\nNhập số x cần đếm: ");
        int xCount = int.Parse(Console.ReadLine());
        int soLuong = DemX(xCount);
        Console.WriteLine($"Số lượng phần tử bằng {xCount}: {soLuong}");

        int minVal = TimDuongNhoNhat();
        Console.WriteLine($"\nPhần tử dương nhỏ nhất trong danh sách: {(minVal != -1 ? minVal.ToString() : "Không có")}");

        Console.Write("\nNhập số x cần xóa (xuất hiện đầu tiên): ");
        int xDel = int.Parse(Console.ReadLine());
        XoaDauX(xDel);

        Console.Write("Danh sách sau khi xóa: ");
        Xuat();
    }
}

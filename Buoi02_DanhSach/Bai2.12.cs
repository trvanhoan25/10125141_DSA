using System;
using System.Text;

class Node12
{
    public int Data;
    public Node12 Next;
    public Node12(int data)
    {
        Data = data;
        Next = null;
    }
}

class Bai2_12
{
    static Node12 pHead = null;

    static void ThemCuoi(int x)
    {
        Node12 newNode = new Node12(x);
        if (pHead == null)
        {
            pHead = newNode;
        }
        else
        {
            Node12 current = pHead;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    static void Xuat()
    {
        Node12 current = pHead;
        while (current != null)
        {
            Console.Write(current.Data + "\t");
            current = current.Next;
        }
        Console.WriteLine();
    }

    static void DaoNguoc()
    {
        Node12 prev = null;
        Node12 current = pHead;
        Node12 next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        pHead = prev;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử của danh sách: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int val = int.Parse(Console.ReadLine());
            ThemCuoi(val);
        }

        Console.Write("\nDanh sách ban đầu: ");
        Xuat();

        DaoNguoc();

        Console.Write("Danh sách sau khi đảo ngược: ");
        Xuat();
    }
}
using System;
using System.Text;

class Node14
{
    public int Data;
    public Node14 Next;
    public Node14(int data)
    {
        Data = data;
        Next = null;
    }
}

class Bai2_13
{
    static Node14 TaoDanhSach()
    {
        Node14 head = null;
        Console.Write("Nhập số lượng phần tử (đã sắp xếp tăng dần): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int val = int.Parse(Console.ReadLine());
            Node14 newNode = new Node14(val);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node14 current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        return head;
    }

    static void Xuat(Node14 head)
    {
        Node14 current = head;
        while (current != null)
        {
            Console.Write(current.Data + "\t");
            current = current.Next;
        }
        Console.WriteLine();
    }

    static Node14 GopDanhSach(Node14 l1, Node14 l2)
    {
        Node14 dummyHead = new Node14(0);
        Node14 tail = dummyHead;

        while (l1 != null && l2 != null)
        {
            if (l1.Data <= l2.Data)
            {
                tail.Next = l1;
                l1 = l1.Next;
            }
            else
            {
                tail.Next = l2;
                l2 = l2.Next;
            }
            tail = tail.Next;
        }

        if (l1 != null)
        {
            tail.Next = l1;
        }
        else
        {
            tail.Next = l2;
        }

        return dummyHead.Next;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- Nhập danh sách thứ nhất ---");
        Node14 l1 = TaoDanhSach();

        Console.WriteLine("\n--- Nhập danh sách thứ hai ---");
        Node14 l2 = TaoDanhSach();

        Console.Write("\nDanh sách 1: ");
        Xuat(l1);

        Console.Write("Danh sách 2: ");
        Xuat(l2);

        Node14 l3 = GopDanhSach(l1, l2);

        Console.Write("Danh sách sau khi gộp: ");
        Xuat(l3);
    }
}
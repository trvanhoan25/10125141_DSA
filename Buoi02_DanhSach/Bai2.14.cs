using System;
using System.Text;

class Node15
{
    public int Data;
    public Node15 Next;
    public Node15(int data)
    {
        Data = data;
        Next = null;
    }
}

class Bai15
{
    static bool KiemTraChuTrinh(Node15 head)
    {
        if (head == null) return false;

        Node15 rua = head;
        Node15 tho = head;

        while (tho != null && tho.Next != null)
        {
            rua = rua.Next;
            tho = tho.Next.Next;

            if (rua == tho)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Node15 head = new Node15(1);
        head.Next = new Node15(2);
        head.Next.Next = new Node15(3);
        head.Next.Next.Next = new Node15(4);
        head.Next.Next.Next.Next = new Node15(5);

        head.Next.Next.Next.Next.Next = head.Next;

        bool coChuTrinh = KiemTraChuTrinh(head);
        Console.WriteLine($"Danh sách liên kết {(coChuTrinh ? "có" : "không có")} chứa chu trình.");
    }
}
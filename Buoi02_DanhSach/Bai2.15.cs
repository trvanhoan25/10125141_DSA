using System;
using System.Text;

class WebNode
{
    public string Url;
    public WebNode Prev;
    public WebNode Next;
    public WebNode(string url)
    {
        Url = url;
        Prev = null;
        Next = null;
    }
}

class BrowserHistory
{
    private WebNode current;

    public BrowserHistory(string homepage)
    {
        current = new WebNode(homepage);
    }

    public void Visit(string url)
    {
        WebNode newNode = new WebNode(url);
        current.Next = newNode;
        newNode.Prev = current;
        current = newNode;
        Console.WriteLine($"Đang truy cập: {current.Url}");
    }

    public void Back(int steps)
    {
        while (steps > 0 && current.Prev != null)
        {
            current = current.Prev;
            steps--;
        }
        Console.WriteLine($"Quay lại: {current.Url}");
    }

    public void Forward(int steps)
    {
        while (steps > 0 && current.Next != null)
        {
            current = current.Next;
            steps--;
        }
        Console.WriteLine($"Tiến tới: {current.Url}");
    }
}

class Bai16
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        BrowserHistory browser = new BrowserHistory("google.com");
        browser.Visit("github.com");
        browser.Visit("stackoverflow.com");

        browser.Back(1);
        browser.Back(1);
        browser.Forward(1);
        browser.Visit("youtube.com");
    }
}
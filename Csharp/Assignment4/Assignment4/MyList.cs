using System.Xml;

namespace Assignment4;

public class Node<T>
{
    private T _val;
    private Node<T>? _next;

    public Node()
    {
    }

    public Node(T val)
    {
        _val = val;
    }

    public T Val
    {
        set { _val = value; }
        get { return _val; }
    }

    public Node<T> Next
    {
        set { _next = value; }
        get { return _next; }
    }
}

public class MyList<T> where T : struct
{
    private Node<T> dummy = new Node<T>();
    private int size = 0;

    public void Add(T element)
    {
        Node<T> dum = dummy;
        while (dum.Next != null)
        {
            dum = dum.Next;
        }

        dum.Next = new Node<T>(element);
        size += 1;
    }

    public T Remove(int index)
    {
        Node<T> dum = dummy;
        Node<T> pre = new Node<T>();
        Node<T> res;
        pre.Next = dum;
        while (index >= 0)
        {
            dum = dum.Next;
            pre = pre.Next;
            index--;
        }

        res = dum;
        pre.Next = dum.Next;

        size--;
        return res.Val;
    }

    public bool Contains(T element)
    {
        Node<T> dum = dummy;
        while (dum.Next != null)
        {
            dum = dum.Next;
            if (dum.Val.Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        dummy.Next = null;
    }

    public void InsertAt(T element, int index)
    {
        Node<T> dum = dummy;
        Node<T> pre = new Node<T>();
        pre.Next = dum;
        while (index >= 0)
        {
            dum = dum.Next;
            pre = pre.Next;
        }

        pre.Next = new Node<T>(element);
        pre.Next.Next = dum;
    }

    public void DeleteAt(int index)
    {
        Remove(index);
    }

    public T Find(int index)
    {
        Node<T> dum = dummy;


        while (index >= 0)
        {
            dum = dum.Next;
        }

        return dum.Val;
    }

    public void Show()
    {
        Console.Write("List contains: ");
        Node<T> dum = dummy;
        while (dum.Next != null)
        {
            dum = dum.Next;
            Console.Write($"{dum.Val}, ");
        }

        Console.WriteLine("");
    }

    public static void Main()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Show();
        Console.WriteLine($"check mylist contains 3: {myList.Contains(3)}");
        myList.Remove(0);
        myList.Show();
        myList.Add(4);
        Console.WriteLine($"check mylist contains 1: {myList.Contains(1)}");
        myList.Clear();
        myList.Show();
    }
}
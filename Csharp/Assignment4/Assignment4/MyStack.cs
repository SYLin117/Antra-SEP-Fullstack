namespace Assignment4;

public class MyStack<T>
{
    private List<T> _hiddenList;

    public MyStack()
    {
        _hiddenList = new List<T>();
    }

    public int Count()
    {
        return _hiddenList.Count;
    }

    public T Pop()
    {
        T tmp = _hiddenList[_hiddenList.Count - 1];
        _hiddenList.RemoveAt(_hiddenList.Count - 1);
        return tmp;
    }

    public void Push(T obj)
    {
        _hiddenList.Add(obj);
    }

    public static void Main()
    {
        MyStack<string> myStack = new MyStack<string>();
        myStack.Push("apple");
        myStack.Push("Pear");
        myStack.Push("Strawberry");
        myStack.Push("grape");
        Console.WriteLine($"There are {myStack.Count()} element(s) in stack");
        Console.WriteLine($"Pop last element from stack: {myStack.Pop()}");
        Console.WriteLine($"There are {myStack.Count()} element(s) in stack");
        Console.WriteLine($"Pop last element from stack: {myStack.Pop()}");
        Console.WriteLine($"There are {myStack.Count()} element(s) in stack");
    }
}
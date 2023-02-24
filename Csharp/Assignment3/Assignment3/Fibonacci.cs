using System.Runtime.CompilerServices;

namespace Assignment3;

public class Fibonacci
{
    private int _first = 0;
    private int _second = 1;
    private int _size;

    public static void Main()
    {
        Fibonacci fibonacci = new Fibonacci(10);
        foreach (var number in fibonacci.Fib())
        {
            Write($"{number} ");
        }
    }

    public Fibonacci(int size)
    {
        _size = size;
    }

    private int[] Fib()
    {
        int[] nums = new int[_size];
        nums[0] = _first;
        nums[1] = _second;
        for (int i = 2; i < _size; i++)
        {
            nums[i] = nums[i - 1] + nums[i - 2];
        }

        return nums;
    }
}
namespace Assignment3.ColorBall;

public class Ball
{
    private Color _color;
    private int _size = 0;
    private int _throw = 0;

    public Ball(Color color, int size)
    {
        _color = color;
        _size = size;
    }

    public void Pop()
    {
        _size = 0;
    }

    public void Throw()
    {
        if (_size > 0)
        {
            _throw += 1;
        }
        else
        {
            WriteLine("This ball is popped, you can't throw it.");
        }
    }

    public int GetThrowTimes()
    {
        return _throw;
    }

    public static void Main()
    {
        Ball ball1 = new Ball(new Color(12, 233, 123, 125), 3);
        ball1.Throw();
        ball1.Throw();
        ball1.Throw();
        WriteLine($"ball have been thrown: {ball1.GetThrowTimes()} times");
        ball1.Pop();
        ball1.Throw();
    }
}
namespace Assignment3.ColorBall;

public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    public int Red
    {
        get { return _red; }
        set { _red = value; }
    }

    public int Green
    {
        get { return _green; }
        set { _green = value; }
    }

    public int Blue
    {
        get { return _blue; }
        set { _blue = value; }
    }

    public int Alpha
    {
        get { return _alpha; }
        set { _alpha = value; }
    }

    public Color(int red, int green, int blue, int alpha)
    {
        _red = red;
        _green = green;
        _blue = blue;
        _alpha = alpha;
    }

    public int GetGrayScale()
    {
        return (_red + _green + _blue) / 3;
    }
}
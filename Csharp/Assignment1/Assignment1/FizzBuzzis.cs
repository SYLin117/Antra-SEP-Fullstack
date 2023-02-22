namespace Assignment1;

public static class FizzBuzzis
{
    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                WriteLine("/FizzBuzz/");
            }
            else if (i % 3 == 0)
            {
                WriteLine("/fizz/");
            }
            else if (i % 5 == 0)
            {
                WriteLine("/buzz/");
            }
        }
    }
}
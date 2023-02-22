namespace Assignment1;

public static class CountingProgram
{
    public static void Count()
    {
        for (int i = 1; i <= 4; i++)
        {
            Write("0");
            for (int j = 0 + i; j <= 24; j += i)
            {
                Write($",{j}");
            }

            WriteLine("");
        }
    }
}
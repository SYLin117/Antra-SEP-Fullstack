namespace Assignment1;

public class PyramidPrinter
{
    public static void PrintPyramid(int row = 5)
    {
        for (int i = 1; i <= 5; i++)
        {
            int spaceNum = row - i;
            int starNum = 1 + (i - 1) * 2;
            for (int j = 0; j < spaceNum; j++)
            {
                Write(" ");
            }

            for (int j = 0; j < starNum; j++)
            {
                Write("*");
            }

            for (int j = 0; j < spaceNum; j++)
            {
                Write(" ");
            }

            WriteLine("");
        }
    }
}
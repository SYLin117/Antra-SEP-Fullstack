namespace Assignment1;

public class PrimeFinder
{
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> tmpList = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                tmpList.Add(i);
            }
        }

        return tmpList.ToArray();
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
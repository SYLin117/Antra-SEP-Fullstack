namespace Assignment1;

public static class ArrayUtils
{
    public static int[] CopyArray(int[] arr)
    {
        int len = arr.Length;
        int[] newArr = new int[len];
        for (int i = 0; i < len; i++)
        {
            newArr[i] = arr[i];
        }

        return newArr;
    }

    public static void SumRotateArray(int[] nums, int k)
    {
        int[,] rotateArr = new int[k, nums.Length];
        int[] sums = new int[nums.Length];
        rotateArr[0, 0] = nums[nums.Length - 1];
        for (int j = 1; j < nums.Length; j++)
        {
            rotateArr[0, j] = nums[j - 1];
        }

        for (int i = 1; i < k; i++)
        {
            rotateArr[i, 0] = rotateArr[i - 1, nums.Length - 1];
            for (int j = 1; j < nums.Length; j++)
            {
                rotateArr[i, j] = rotateArr[i - 1, j - 1];
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < k; j++)
            {
                sum += rotateArr[j, i];
            }

            sums[i] = sum;
        }

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                Write($"{rotateArr[i, j],3}");
            }

            WriteLine("");
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Write($"{sums[i],3}");
        }
    }

    public static int[] FindLongestSequence(int[] nums)
    {
        int res = 0;
        int start = 0;
        int maxSize = 1;
        int currentSize = 1;
        int lastVal = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == lastVal)
            {
                currentSize += 1;
                if (currentSize > maxSize)
                {
                    maxSize = currentSize;
                    res = start;
                }
            }
            else
            {
                start = i;
                lastVal = nums[i];
                currentSize = 1;
            }
        }

        Write($"start:{res}, size:{maxSize}");
        int[] resArr = new int[maxSize];
        for (int i = 0; i < maxSize; i++)
        {
            resArr[i] = nums[res];
        }

        return resArr;
    }

    public static int FindMostFrequent(int[] nums)
    {
        int res = nums[0];
        int index = 0;
        int maxFreq = 1;
        Dictionary<int, int> myDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (myDic.ContainsKey(nums[i]))
            {
                myDic[nums[i]] = myDic[nums[i]] + 1;
                if (myDic[nums[i]] > maxFreq)
                {
                    maxFreq = myDic[nums[i]];
                    index = i;
                    res = nums[i];
                }
            }
            else
            {
                myDic.Add(nums[i], 1);
            }
        }

        return res;
        // var maxValueKey = myDic.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }
}
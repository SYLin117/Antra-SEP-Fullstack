using System.Xml;

namespace Assignment3;

using System;

public class ReverseArray
{
    public static void Main()
    {
        int[] nums = GenerateNumbers();
        Reverse(nums);
        PrintNumbers(nums);
    }

    private static int[] GenerateNumbers(int length = 10)
    {
        int min = 0;
        int max = 100;
        Random rand = new Random();
        int[] nums = new int[length];
        for (int i = 0; i < length; i++)
        {
            nums[i] = rand.Next(min, max);
        }
        return nums;
    }

    private static void Reverse(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int tmp = nums[left];
            nums[left] = nums[right];
            nums[right] = tmp;
            left++;
            right--;
        }
    }

    private static void PrintNumbers(int[] nums)
    {
        foreach (var num in nums)
        {
            Write($"{num} ");
        }
    }
}
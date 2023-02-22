namespace Assignment1;

public class StringUtils
{
    public static string ReverseString(string value)
    {
        char[] chars = new char[value.Length];
        int left = 0;
        int right = value.Length - 1;
        while (left < right)
        {
            chars[left] = value[right];
            chars[right] = value[left];
            left++;
            right--;
        }

        return new string(chars);
    }

    public static string ReverseSentence(string value)
    {
        string[] words = value.Split(" ");
        int idx = 0;
        string[] resArr = new string[words.Length];
        foreach (var word in words)
        {
            resArr[idx] = ReverseString(word);
            idx++;
        }

        return string.Join(" ", resArr);
    }

    public static string ReverseWords(string str)
    {
        return String.Join(" ", str.Split('.', ' ').Reverse()).ToString();
    }

    private static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        while (left <= right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }

        return true;
    }

    public static string FindPalindrone(string str)
    {
        var mySet = new HashSet<string>();
        string[] words = str.Split(new[] { ' ', ',', '!', '.', ':', '?' });
        foreach (var word in words)
        {
            if (word.Equals(" ") || word.Equals("")) continue;
            if (IsPalindrome(word)) mySet.Add(word);
        }

        return string.Join(", ", mySet);
    }

    public static string[] ParseUrl(string str)
    {
        string[] res = new string[3];
        if (str.Contains(":"))
        {
            string[] tmp = str.Split(":");
            res[0] = tmp[0];
            str = tmp[1];
        }

        if (str[0] == '/')
        {
            str = str.Substring(2);
        }

        string[] tmp2 = str.Split("/", 2);
        res[1] = tmp2[0];
        if (tmp2.Length > 1) res[2] = tmp2[1];
        return res;
    }
}
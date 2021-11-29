using System;

public class Isograms
{
    public static bool IsIsogram(string str)
    {
        string str2 = str.ToLower();
        char[] chars = str2.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (str2.Substring(0, i).Contains(chars[i]) || str2.Substring(i + 1).Contains(chars[i]))
            {
                return false;
            }

        }
        return true;
    }
}
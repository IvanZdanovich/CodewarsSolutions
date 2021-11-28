public static class MultiplesOf3Or5
{
    public static int Solution(int value)
    {
        int result = 0;
        if (value >= 0)
        {
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
        }
        return result;
    }
}
public class SumOfDigitsOrDigitalRoot
{
    public int DigitalRoot(long n)
    {
        int result = 0;
        while (n > 9)
        {
            result += (int)(n % 10);
            n /= 10;
        }
        result += (int)n;
        return result > 9 ? DigitalRoot(result) : result;
    }
}
public static class CreditCardMask
{
    // return masked string
    public static string Maskify(string cc)
    {
        if (cc.Length > 4)
        {
            return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
        }
        return cc;
    }
}
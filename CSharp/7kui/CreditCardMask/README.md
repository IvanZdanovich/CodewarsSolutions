# Credit Card Mask

### Description
[Kata](https://www.codewars.com/kata/5412509bd436bd33920011bc/train/csharp)

### Comment
TODO

### BEST practice C#

```
public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    int len = cc.Length;
    if (len <=4)
      return cc;
        
    return cc.Substring(len-4).PadLeft(len, '#');
  }
}
```
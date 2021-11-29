# Sum of Digits / Digital Root

### Description
[Kata](https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp)

### Comment
TODO

### BEST practice C#

```
public class Number
{
  public int DigitalRoot(long n)
  {
     return (int)(1 + (n - 1) % 9);
  }
}
```
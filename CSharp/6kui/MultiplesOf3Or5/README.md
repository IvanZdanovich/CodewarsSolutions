# Multiples of 3 or 5

### Description
[Kata](https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp)

### Comment
TODO

### BEST practice C#

```
using System.Linq;
public static class Kata
{
  public static int Solution(int n)
  {
   return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
   }
}
```
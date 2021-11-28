# Isograms

### Description
[Kata](https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp)

### Comment
TODO

### BEST practice C#

```
using System;
using System.Linq;
public class Kata
{
  public static bool IsIsogram(string str) 
  {
    return str.ToLower().Distinct().Count()==str.Length;
  }
}
```
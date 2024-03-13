using System.Linq;
using System;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    var oddNumbers = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 != 0)
      {                
        array[i] = oddNumbers[index];  
        index++;
      }
    }  
    return array;
  }
}
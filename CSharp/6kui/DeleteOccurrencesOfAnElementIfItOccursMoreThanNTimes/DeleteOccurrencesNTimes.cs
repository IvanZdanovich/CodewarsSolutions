using System;
using System.Collections.Generic;
using System.Linq;

public class DeleteOccurrencesNTimes
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        int[] array = new int[arr.Length];
        int occurancies;
        int currentIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            array[i] = -1;
            array[currentIndex] = arr[i];
            occurancies = 0;
            for (int j = 0; j <= currentIndex; j++)
            {
                if (array[j] == arr[i])
                {
                    occurancies++;
                }
            }
            if (occurancies <= x)
            {
                currentIndex++;
            }
            else
            {
                array[currentIndex] = -1;
            }
        }
        return array = array.Where(x => x != -1).ToArray();
    }
}
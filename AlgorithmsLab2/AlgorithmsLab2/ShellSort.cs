using System;

public class ShellSort
{
    public static int[] Sort(int[] array)
    {
        int[] newArray = new int[array.Length];
        Array.Copy(array, newArray, array.Length);

        int n = newArray.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = newArray[i];
                int j;
                for (j = i; j >= gap && newArray[j - gap] > temp; j -= gap)
                {
                    newArray[j] = newArray[j - gap];
                }
                newArray[j] = temp;
            }
        }

        return newArray;
    }
}
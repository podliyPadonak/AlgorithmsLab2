using System;

public class InsertionSort
{
    public static int[] Sort(int[] array)
    {
        int[] newArray = new int[array.Length];
        Array.Copy(array, newArray, array.Length);

        int n = newArray.Length;

        for (int i = 1; i < n; i++)
        {
            int key = newArray[i];
            int j = i - 1;

            while (j >= 0 && newArray[j] > key)
            {
                newArray[j + 1] = newArray[j];
                j = j - 1;
            }
            newArray[j + 1] = key;
        }

        return newArray;
    }
}
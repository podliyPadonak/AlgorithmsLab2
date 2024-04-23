using System;

public class SelectionSort
{
    public static int[] Sort(int[] array)
    {
        int[] newArray = new int[array.Length];
        Array.Copy(array, newArray, array.Length);

        for (int i = 0; i < newArray.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < newArray.Length; j++)
            {
                if (newArray[j] < newArray[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = newArray[minIndex];
            newArray[minIndex] = newArray[i];
            newArray[i] = temp;
        }

        return newArray;
    }
}
using System;
using System.Diagnostics;

class MainProgram
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(20000);

        Console.WriteLine("Original array:");
        PrintArray(array);

        Stopwatch stopwatch = new Stopwatch();

        // Сортування за допомогою Selection Sort
        stopwatch.Start();
        int[] sortedArray1 = SelectionSort.Sort(array);
        stopwatch.Stop();
        Console.WriteLine($"\nSelection Sort: {stopwatch.Elapsed}");
        //Console.WriteLine("Sorted array:");
        //PrintArray(sortedArray1);

        // Сортування за допомогою Insertion Sort
        stopwatch.Reset();
        stopwatch.Start();
        int[] sortedArray2 = InsertionSort.Sort(array);
        stopwatch.Stop();
        Console.WriteLine($"\nInsertion Sort: {stopwatch.Elapsed}");
        //Console.WriteLine("Sorted array:");
        //PrintArray(sortedArray2);

        // Сортування за допомогою Shell Sort
        stopwatch.Reset();
        stopwatch.Start();
        int[] sortedArray3 = ShellSort.Sort(array);
        stopwatch.Stop();
        Console.WriteLine($"\nShell Sort: {stopwatch.Elapsed}");
        //Console.WriteLine("Sorted array:");
        //PrintArray(sortedArray3);

        // Сортування за допомогою Merge Sort
        stopwatch.Reset();
        stopwatch.Start();
        int[] sortedArray4 = MergeSort.Sort(array);
        stopwatch.Stop();
        Console.WriteLine($"\nMerge Sort: {stopwatch.Elapsed}");
        //Console.WriteLine("Sorted array:");
        //PrintArray(sortedArray4);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10000); // Генеруємо випадкові числа в діапазоні від 0 до 9999
        }
        return array;
    }
}

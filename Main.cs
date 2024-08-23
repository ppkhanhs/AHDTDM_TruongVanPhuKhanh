
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 4, 6, 1, 3, 2, 6 };
        Console.WriteLine("Mảng trước khi sắp xếp:");
        PrintArray(arr);

        MergeSort(arr);

        Console.WriteLine("\nMảng sau khi sắp xếp:");
        PrintArray(arr);
    }

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];
        for (int i = mid; i < arr.Length; i++)
            right[i - mid] = arr[i];

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
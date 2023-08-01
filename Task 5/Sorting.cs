#define BUBBLESORT
//#define QUICKSORT

using System;

public class SortingAlgorithms
{
#if BUBBLESORT
    public static void BubbleSort(int[] arr)
    {

        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)

                break;
        }
    }
#endif
    //#pragma warning disable CS1072
    //#warning Warning Example;
    //#error  Error Example

#if QUICKSORT
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
            
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp2;

        return i + 1;
    }
#endif

    public static void Main(string[] args)

#pragma warning restore IDE0079
    {
//#line 50 "question (b).cs"
//        int a = "d";
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine();

        int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);

#if BUBBLESORT
        BubbleSort(arr);
#elif QUICKSORT
        QuickSort(arr, 0, arr.Length - 1);
#else
        Console.WriteLine("Sorting algorithm not defined.");
        return;
#endif

        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}

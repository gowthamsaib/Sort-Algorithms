using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 72, 3, 14, 7, 1 };

        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        BubbleSortArray(numbers);

        Console.WriteLine("\nSorted Array:");
        PrintArray(numbers);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

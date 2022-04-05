using System;

namespace InsertionSort
{
    internal class Program
    {
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        // A utility function to print
        // array of size n
        static void printArray(int[] arr)
        {
            Console.WriteLine("Sorted array is: ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        // Driver Code
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insertion sort program");
            Console.WriteLine("Please enter the range ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array element ");
            for (int i = 0; i < n; ++i)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Program ob = new Program();
            ob.sort(arr);
            printArray(arr);
        }
    }
}

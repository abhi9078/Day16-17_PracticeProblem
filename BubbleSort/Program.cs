using System;

namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            //Display unit
            Console.WriteLine("Sorted array is: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        //Driver method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BubbleSort Program");
            Console.WriteLine("Please enter the length of the Array");
            int n= int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Please enter the array elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Program.BubbleSort(arr);
            
        }
    }
}

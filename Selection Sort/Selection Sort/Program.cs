using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array of random numbers.
            int[] nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100000);
            }

            int[] nums2 = new int[100000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums2[i] = rand.Next(100000);
            }

            int[] nums3 = new int[100000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums3[i] = rand.Next(100000);
            }

            Console.WriteLine("\nRandom Numbers:");

            foreach (int x in nums)
                Console.Write(x + " ");

            Console.WriteLine("\n\nBubble Sort - Sorted Numbers:");
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            BubbleSort(nums);
            stopwatch1.Stop();
            BubbleSortDisplay(nums);

            Console.WriteLine("\n\nInsertion Sort - Sorted Numbers:");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            InsertionSort(nums2);
            stopwatch2.Stop();
            InsertionSortDisplay(nums2);

            Console.WriteLine("\n\nSelection Sort - Sorted Numbers:");
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();

            SelectionSort(nums3);
            stopwatch3.Stop();
            SelectiontDisplay(nums3);

            Console.WriteLine($"\n\nProcessing time for Bubble Sort: {stopwatch1.ElapsedMilliseconds} milliseconds");
            Console.WriteLine($"\n\nProcessing time for Insertion Sort: {stopwatch2.ElapsedMilliseconds} milliseconds");
            Console.WriteLine($"\n\nProcessing time for Selection Sort: {stopwatch3.ElapsedMilliseconds} milliseconds\n");
        }
        /*Basic bubble sort algorithm*/
        static int[] BubbleSort(int[] arr)
        {
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                /*Internal loop goes through the elements and checks each one*/
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        //Insertion Sort algorithm
        static int[] InsertionSort(int[] arr)
        {
            int temp, j;

            for (int i = 0; i < arr.Length; i++)
            {
                j = i;
                temp = arr[i];
                while (j > 0 && arr[j - 1] >= temp)
                {
                    arr[j] = arr[j - 1];
                    j -= 1;
                }
                arr[j] = temp;
            }
            return arr;
        }

        //Insertion Sort algorithm
        static int[] SelectionSort(int[] arr)
        {
            for (int outter = 0; outter < arr.Length; outter++)
            {
                int min = outter;//Create a starting point for the lowest number.
                for (int inner = outter + 1; inner < arr.Length; inner++)//Linear search the rest of the data for the lowest value
                {
                    if (arr[inner] < arr[min])
                        min = inner;//Store the lowest number in the min variable
                }
                int temp = arr[outter];//Once the lowest value is found perform the swap.
                arr[outter] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }

        /*Display the array*/
        static void BubbleSortDisplay<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
        }
        static void InsertionSortDisplay<T>(T[] array)
        {
            foreach (T x in array)
            {
                Console.Write(x + " ");
            }
        }
        static void SelectiontDisplay<T>(T[] array)
        {
            foreach (T x in array)
            {
                Console.Write(x + " ");
            }
        }
    }
}

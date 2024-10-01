using System;

namespace CrashCourse_DataStructure
{
    class Lesson10
    {
        public static void L10_SearchingAlgorithm()
        {
            Console.Write("How many elements you want to input: ");
            int num = int.Parse(Console.ReadLine());

            int[] array = new int[num];

            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nChoose search method: " +
                              "\n[1] Linear Search" +
                              "\n[2] Binary Search (sorted array)");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the value to search: ");
            int search = int .Parse(Console.ReadLine());

            int index = -1;

            switch (choice)
            {
                case 1:
                    index = LinearSearch(array, search);
                    break;
                case 2:
                    Array.Sort(array);
                    index = BinarySearch(array, search);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            if(index != -1)     Console.WriteLine("Value " + search + " found at index " + index + ".");
            else                Console.WriteLine("Value " + search + " not found in the array.");

        }
        static int LinearSearch(int[] array, int search)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)     return i;
            }
            return -1;
        }

        static int BinarySearch(int[] array, int search)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if(array[mid] == search)            return mid;
                else if (array[mid] < search)       left = mid + 1;
                else                                right = mid - 1;
               
            }
            return -1;
        }
    }
}

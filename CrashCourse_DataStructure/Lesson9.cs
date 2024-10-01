using System;

namespace CrashCourse_DataStructure
{
    class Lesson9
    {
        public static void L9_SortingAlgorithm()
        {
            Console.WriteLine("How many elements you want to sort:");
            int num = int.Parse(Console.ReadLine());

            int[] array = new int[num];

            Console.WriteLine("Enter the elements: ");
            for  (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array : ");
            DisplayArray(array);

            BubbleSort(array);
            Console.WriteLine("\nSorted Array   : ");
            DisplayArray(array);
        }

        public static void DisplayArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void BubbleSort(int[] array)
        {
            int num = array.Length;

            for(int i = 0; i < num - 1; i++)
            {
                for(int j = 0; j < num - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

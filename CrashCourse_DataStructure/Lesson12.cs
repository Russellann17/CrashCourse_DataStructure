using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DataStructure
{
    class Lesson12
    {
        public static void L12_DivideAndConquer()
        {
            string[] fruits = { "Apple", "Banana", "Grapes", "Mango", "Orange", "Peach", "Strawberry", "Durian" };

            Console.WriteLine("Available fruits:");
            PrintFruits(fruits);

            Console.Write("\nEnter the name of the fruit you want to search: ");
            string search = Console.ReadLine();

            int index = BinarySearch(fruits, search);
            if (index != -1)
                Console.WriteLine("Fruit " + search + " found at index: " + index);
            else
                Console.WriteLine("Fruit " + search + " not found.");
        }

        static void PrintFruits(string[] fruits)
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + fruits[i]);
            }
        }

        static int BinarySearch(string[] array, string search)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid].Equals(search, StringComparison.OrdinalIgnoreCase))
                    return mid;
                if (string.Compare(array[mid], search, StringComparison.OrdinalIgnoreCase) < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}

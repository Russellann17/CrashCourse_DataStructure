using System;
using System.Collections.Generic;

namespace CrashCourse_DataStructure
{
    class Lesson13
    {
        public static void L13_Backtracking()
        {
            Console.Write("Enter the number of fruits: ");
            int numFruits = int.Parse(Console.ReadLine());

            string[] fruits = new string[numFruits];
            int[] weight = new int[numFruits];

            for(int i = 0; i < numFruits; i++)
            {
                Console.Write("Enter fruit name #" + (i+1) + "  : ");
                fruits[i] = Console.ReadLine();

                Console.Write("Enter weight for "+ fruits[i] + ": ");
                weight[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter the target sum of weights: ");
            int targetSum = int.Parse(Console.ReadLine());

            Console.WriteLine("Target sum: " + targetSum);
            List<string> currentSubset = new List<string>();

            bool isFound = FindSubsetSum(fruits, weight, currentSubset, 0, 0, targetSum);

            if (!isFound)
            {
                Console.WriteLine("No subset of fruits sums up to " + targetSum);
            }
        }

        static bool FindSubsetSum(string[] fruits, int[] weight, List<string> currentSubset, int index, int currentSum, int targetSum)
        {
            if (currentSum == targetSum)
            {
                Console.WriteLine("Subset found: " + string.Join(", ", currentSubset));
                return true;
            }

            if (index == fruits.Length || currentSum > targetSum)
            { return false; }

            currentSubset.Add(fruits[index]);

            if (FindSubsetSum(fruits, weight, currentSubset, index + 1, currentSum + weight[index], targetSum))
            { return true; }
     
            currentSubset.RemoveAt(currentSubset.Count - 1);

            return FindSubsetSum(fruits, weight, currentSubset, index + 1, currentSum, targetSum);
        }
    }
}

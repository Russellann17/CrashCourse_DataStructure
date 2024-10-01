using System;
using System.Collections.Generic;

namespace CrashCourse_DataStructure
{
    class Lesson11
    {
        public static void L11_GreedyAlgorithm()
        {
            Console.Write("Enter the number of sticks: ");
            int numberOfSticks = int.Parse(Console.ReadLine());

            List <int> sticks = new List <int>();
            Console.WriteLine("Enter the lengths of sticks: ");
            for (int i = 0; i < numberOfSticks; i++)
            {
                sticks.Add(int.Parse(Console.ReadLine()));
            }

            int minCost = ConnectSticks(sticks);
            Console.WriteLine("Minimum cost to connect the sticks: " + minCost);
        }

        static int ConnectSticks(List<int> sticks)
        {
            if (sticks.Count == 0) return 0;

            int totalCost = 0;
            while (sticks.Count > 1)
            {
                sticks.Sort();
                int cost = sticks[0] + sticks[1];
                totalCost += cost;
                sticks.RemoveRange(0, 2);
                sticks.Add(cost);
            } 

            return totalCost;
        }
    }
}

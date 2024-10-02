using System;
using System.Collections.Generic;

namespace CrashCourse_DataStructure
{
    class Lesson14
    {
        public static void L14_SpaceAndTimeAnalysis()
        {
            Console.Write("How many things would you like to enter? ");
            int numOfThings = int.Parse(Console.ReadLine());

            List<string> things = new List<string>();

            Console.WriteLine("Please enter the things: ");
            for(int i = 0; i < numOfThings; i++)
            {
                Console.Write("Thing " + (i + 1) + ": ");
                string thing = Console.ReadLine();
                things.Add(thing);
            }

            Dictionary<string, int> thingCounts = CountThings(things);

            Console.WriteLine("\nOccurences of each thing: ");
            foreach(var kvp in thingCounts)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value + " times");
            }
        }
        static Dictionary<string, int> CountThings(List<string> things)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var thing in things)
            {
                if (counts.ContainsKey(thing)) { counts[thing]++; }
                else { counts[thing] = 1; }
            }
            return counts;
        }
    }
}

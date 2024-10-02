using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- DATA STRUCTURES LESSON -------" +
                              "\n[1]  Lesson 1  : Introduction" +
                              "\n[2]  Lesson 2  : Classes and Objects" +
                              "\n[3]  Lesson 3  : Linked List" +
                              "\n[4]  Lesson 4  : Stack and Queue" +
                              "\n[5]  Lesson 5  : Trees" +
                              "\n[6]  Lesson 6  : Graphs" +
                              "\n[7]  Lesson 7  : Hashing" +
                              "\n[8]  Lesson 8  : Heaps" +
                              "\n[9]  Lesson 9  : Sorting Algorithms" +
                              "\n[10] Lesson 10 : Searching Algorithms" +
                              "\n[11] Lesson 11 : Greedy Algorithms" +
                              "\n[12] Lesson 12 : Divide and Conquer" +
                              "\n[13] Lesson 13 : Backtracking" +
                              "\n[14] Lesson 14 : Space and Time Complexity Analysis" +
                              "\n[0] Exit");

            while (true)
            {
                Console.Write("Choose a Lesson: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Lesson1.L1_Introduction();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Lesson2.L2_ClassesAndObjects();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Lesson3.L3_LinkedList();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Lesson4.L4_StackAndQueue();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Lesson5.L5_Trees();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Lesson6.L6_Graph();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Lesson7.L7_Hashing();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        Lesson8.L8_Heaps();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        Lesson9.L9_SortingAlgorithm();
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        Lesson10.L10_SearchingAlgorithm();
                        Console.WriteLine("\n");
                        break;
                    case 11:
                        Lesson11.L11_GreedyAlgorithm();
                        Console.WriteLine("\n");
                        break;
                    case 12:
                        Lesson12.L12_DivideAndConquer();
                        Console.WriteLine("\n");
                        break;
                    case 13:
                        Lesson13.L13_Backtracking();
                        Console.WriteLine("\n");
                        break;
                    case 14:
                        Lesson14.L14_SpaceAndTimeAnalysis();
                        Console.WriteLine("\n");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }

        }
    }
}



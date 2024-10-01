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
                              "\n[1] Lesson 1 : Introduction" +
                              "\n[2] Lesson 2 : Classes and Objects" +
                              "\n[3] Lesson 3 : Linked List" +
                              "\n[4] Lesson 4 : Stack and Queue" +
                              "\n[5] Lesson 5 : Trees" +
                              "\n[6] Lesson 6 : Graphs" +
                              "\n[7] Lesson 7 : Hashing" +
                              "\n[8] Lesson 8 : Heaps" +
                              "\n[9] Lesson 9 : Sorting Algorithms" +
                              "\n[0] Exit");

            while (true)
            {
                Console.Write("Choose a Lesson: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
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
                    case 0:
                        return;



                }
            }

        }
    }
}



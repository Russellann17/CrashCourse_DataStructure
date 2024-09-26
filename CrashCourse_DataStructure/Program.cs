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
                              "\n[1] Lesson 2 : Classes and Objects" +
                              "\n[2] Lesson 3 : Linked List" +
                              "\n[3] Lesson 4 : Stack and Queue" +
                              "\n[4] Lesson 5 : Trees" +
                              "\n[5] Lesson 6 : Graphs" +
                              "\n[6] Lesson 7 : Hashing" +
                              "\n[0] Exit");

            while (true)
            {
                Console.Write("Choose a Lesson: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Lesson2.L2_ClassesAndObjects();
                    Console.WriteLine("\n");
                }
                else if (choice == 2)
                {
                    Lesson3.L3_LinkedList();
                    Console.WriteLine("\n");
                }
                else if(choice == 3)
                {
                    Lesson4.L4_StackAndQueue();
                    Console.WriteLine("\n");
                }
                else if(choice == 4)
                {
                    Lesson5.L5_Trees();
                    Console.WriteLine("\n");
                }
                else if(choice == 5)
                {
                    Lesson6.L6_Graph();
                    Console.WriteLine("\n");
                }
                else if (choice == 0) return;
            }
                
                
            }
        }
    }



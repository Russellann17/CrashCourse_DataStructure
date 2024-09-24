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
            Console.WriteLine("[1] Lesson 2 : Classes and Objects" +
                              "[2] Lesson 3 : Linked List" +
                              "[0] Exit");

            while (true)
            {
                Console.Write("Choose a Lesson: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Lesson2.L2_ClassesAndObjects();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Lesson3.L3_LinkedList();
                        Console.WriteLine("\n");
                        break;
                    case 3:

                    case 0:
                        return;
                }
                
                
            }
        }
    }

}

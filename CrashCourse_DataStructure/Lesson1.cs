using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DataStructure
{
    class Lesson1
    {
        public static void L1_Introduction()
        {
            List<string> fruits = new List<string>();
            bool run = true;

            while (run)
            {
                Console.WriteLine("\n--- Fruit Management ---" +
                                  "\n[1] Add a fruit" +
                                  "\n[2] Remove a fruit" +
                                  "\n[3] Display all fruits" +
                                  "\n[4] Exit");
                Console.Write("Choose an option (1 to 4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the name of the fruit to add: ");
                        string fruitToAdd = Console.ReadLine();
                        fruits.Add(fruitToAdd);
                        Console.WriteLine(fruitToAdd + " has been added.");
                        break;

                    case 2:
                        Console.Write("Enter the name of the fruit to remove: ");
                        string fruitToRemove = Console.ReadLine();
                        bool removed = false;

                        for (int i = 0; i < fruits.Count; i++)
                        {
                            if (fruits[i].Equals(fruitToRemove, StringComparison.OrdinalIgnoreCase))
                            {
                                fruits.RemoveAt(i);
                                removed = true;
                                Console.WriteLine(fruitToRemove + " has been removed.");
                                break;
                            }
                        }

                        if (!removed)
                        {
                            Console.WriteLine(fruitToRemove + " not found in the list.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("List of fruits:");
                        if (fruits.Count > 0)
                        {
                            for (int i = 0; i < fruits.Count; i++)
                            {
                                Console.WriteLine(i+1 + ". " + fruits[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No fruits in the list.");
                        }
                        break;

                    case 4:
                        run = false;
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}

using System;
using System.Runtime.Remoting.Messaging;

namespace CrashCourse_DataStructure
{
    class Lesson3
    {
        public static void L3_LinkedList()
        {  
            ShoppingList shoppingList = new ShoppingList();
            string input;
            while (true)
            {
                
                Console.WriteLine("--- SHOPPING LIST MANAGER ---" +
                                  "\n[1] Add Item" +
                                  "\n[2] Remove Item" +
                                  "\n[3] Search Item" +
                                  "\n[4] Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Enter an item to add to the list (or type 'exit' to finish):");
                            input = Console.ReadLine();
                            if (input.ToLower() == "exit") break;
                            shoppingList.AddItem(input);
                        }
                        Console.WriteLine("Item/s added successfully.\n");
                        shoppingList.DisplayItems();
                        Console.WriteLine("Total number of items : " + shoppingList.CountItems() + "\n");
                        break;
                    case 2:
                        Console.Write("\nEnter an item to remove from the list: ");
                        input = Console.ReadLine();
                        shoppingList.RemoveItem(input);
                        Console.WriteLine("Item removed successfully.");

                        Console.WriteLine("\nYour updated shopping list: ");
                        shoppingList.DisplayItems();
                        Console.WriteLine("Total number of items : " + shoppingList.CountItems() + "\n");
                        break;
                    case 3:
                        Console.Write("Search for an item: ");
                        input = Console.ReadLine();
                        if (shoppingList.CheckItem(input)) Console.WriteLine("Yes, " + input + " is in your shopping list.\n");
                        else Console.WriteLine("No, " + input + " is not in your shopping list.\n");
                        break;
                    case 4:
                        return;

                }
            }
        }
        
    }

    class ItemNode
    {
        public string item { get; set; }
        public ItemNode next {  get; set; }

        public ItemNode(string item)
        {
            this.item = item;
            next = null;
        }

    }

    class ShoppingList
    {
        public ItemNode priority;
        public int CountItems()
        {
            int count = 0;
            ItemNode current = priority;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }

        public void AddItem(string item)
        {
            ItemNode newItem = new ItemNode(item);
            if(priority == null)
            {
                priority = newItem;
            }
            else
            {
                ItemNode current = priority;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
            }
        }
        
        public void DisplayItems()
        {
            ItemNode current = priority;
            int count = 1;

            Console.WriteLine("Your shopping list:");
            while(current != null)
            {
                Console.WriteLine(count + ". "+ current.item);
                current = current.next;
                count++;
            }
        }

        public void RemoveItem(string item)
        {
            if (priority == null) return;

            if (priority.item.Equals(item, StringComparison.OrdinalIgnoreCase))
            {
                priority = priority.next;
                return;
            }

            ItemNode current = priority;

            while (current.next != null && !current.next.item.Equals(item, StringComparison.OrdinalIgnoreCase))
            {
                current = current.next;
            }

            if (current.next != null)
            {
                current.next = current.next.next; 
            }
        }

        public bool CheckItem(string Item)
        {
            ItemNode current = priority;
            while (current != null)
            {
                if (current.item.Equals(Item, StringComparison.OrdinalIgnoreCase)) return true;
                current = current.next;
            }
            return false;
        }
    }
}

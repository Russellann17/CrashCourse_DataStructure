using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DataStructure
{
    class Lesson4
    {
        public static void L4_StackAndQueue()
        {
            CustomerQueue customerQueue = new CustomerQueue();

            while (true)
            {
                Console.WriteLine("\n---- CUSTOMER SERVICE QUEUE ----" +
                    "\n[1] Add Customer" +
                    "\n[2] Serve Customer" +
                    "\n[3] Current Queue" +
                    "\n[0] Exit ");
                Console.Write("Choose and option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Customer Name: ");
                    string name = Console.ReadLine();
                    customerQueue.AddCustomer(name);
                }
                else if (choice == 2)
                {
                    string servedCustomer = customerQueue.ServeCustomer();
                    Console.WriteLine("Served Customer: " + servedCustomer + "\n");
                }
                else if (choice == 3)
                {
                    List<string> currentQueue = customerQueue.CurrentQueue();
                    Console.WriteLine("Current Queue: \n" + string.Join("\n", currentQueue) + "\n");
                }
                else if (choice == 0) return;
            }
        }
    }

    class CustomerQueue
    {
        private Queue<string> queue;
        public CustomerQueue()
        {
            queue = new Queue<string>();
        }

        public void AddCustomer(string name)
        {
            queue.Enqueue(name);
            Console.WriteLine(name + " has been added to the queue.\n");
        }

        public string ServeCustomer()
        {
            if(queue.Count == 0)
            {
                return "No customers to serve \n";
            }
            return queue.Dequeue();
        }
        public List<string> CurrentQueue()
        {
            return new List<string>(queue);
        }
    }
}

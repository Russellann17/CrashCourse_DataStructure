using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DataStructure
{
    class Lesson7
    {
        public static void L7_Hashing()
        {
            var contactManager = new ContactManager();

            while (true)
            {
                Console.WriteLine("---- CONTACT MANAGER ----" +
                                  "\n[1] Add Contact" +
                                  "\n[2] Search Contact" +
                                  "\n[3] Delete Contact" +
                                  "\n[0] Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Name         : ");
                        string name = Console.ReadLine();
                        Console.Write("Phone number : ");
                        string phone = Console.ReadLine();
                        contactManager.AddContact(name, phone);
                        break;
                    case 2:
                        Console.Write("Search (Name of Contact) : ");
                        string nameToSearch = Console.ReadLine();
                        string phoneNumber = contactManager.SearchContact(nameToSearch);
                        if (phoneNumber != null)
                            Console.WriteLine($"Phone number: {phoneNumber}");
                        else
                            Console.WriteLine("Contact not found.");
                        break;
                    case 3:
                        Console.Write("Delete (Name of Contact): ");
                        string nameToDelete = Console.ReadLine();
                        contactManager.DeleteContact(nameToDelete);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
    
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
    class ContactManager
    {
        private List<List<Contact>> hashTable;
        private const int tableSize = 10;

        public ContactManager()
        {
            hashTable = new List<List<Contact>>(tableSize);
            for (int i = 0; i < tableSize; i++)
            {
                hashTable.Add(new List<Contact>());
            }
        }
        private int GetHash(string name)
        {
            int hash = name.GetHashCode() % tableSize;
            return Math.Abs(hash);
        }
        public void AddContact(string name, string phoneNumber)
        {
            int index = GetHash(name);
            hashTable[index].Add(new Contact(name, phoneNumber));
            Console.WriteLine("Contact added.");
        }
        public string SearchContact(string name)
        {
            int index = GetHash(name);
            foreach (var contact in hashTable[index])
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return contact.PhoneNumber;
                }
            }
            return null;
        }
        public void DeleteContact(string name)
        {
            int index = GetHash(name);
            var contacts = hashTable[index];
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Successfully deleted.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }
    }
}
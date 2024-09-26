using System;

namespace CrashCourse_DataStructure
{
    class Lesson5
    {
        public static void L5_Trees()
        {
            var binaryTree = new BinaryTree();
            var bst = new BinarySearchTree();

            Console.WriteLine("Enter numbers to add to the trees (type 'done' to finish):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int value))
                {
                    binaryTree.Add(value);
                    bst.Add(value);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("\nBinary Tree In-Order Traversal:");
            binaryTree.InOrderTraversal(binaryTree.Root);

            Console.WriteLine("\n\nBinary Search Tree In-Order Traversal:");
            bst.InOrderTraversal(bst.Root);
        }
    }

    class Node
    {
        public int value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            this.value = value;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public Node Root;

        public void Add(int value)
        {
            Root = AddNode(Root, value);
        }

        private Node AddNode(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }

            if (current.Left == null)
            {
                current.Left = AddNode(current.Left, value);
            }
            else
            {
                current.Right = AddNode(current.Right, value);
            }

            return current;
        }

        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.value + " ");
                InOrderTraversal(node.Right);
            }
        }
    }

    class BinarySearchTree : BinaryTree
    {
        public new void Add(int value)
        {
            Root = AddNode(Root, value);
        }

        private Node AddNode(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }

            if (value < current.value)
            {
                current.Left = AddNode(current.Left, value);
            }
            else if (value > current.value)
            {
                current.Right = AddNode(current.Right, value);
            }

            return current;
        }
    }
}

using System;
using System.Collections.Generic;

namespace CrashCourse_DataStructure
{
    class Lesson6
    {
        public static void L6_Graph()
        {
            var graph = new Lesson6.Graph(5);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            graph.DisplayMatrix();
            Console.WriteLine();

            graph.DisplayList();
        }

        class Graph
        {
            private int[,] adjacencyMatrix;
            private Dictionary<int, List<int>> adjacencyList;
            private int vertices;

            public Graph(int size)
            {
                vertices = size;
                adjacencyMatrix = new int[size, size];
                adjacencyList = new Dictionary<int, List<int>>();
            }

            public void AddEdge(int source, int destination)
            {
                adjacencyMatrix[source, destination] = 1;
                adjacencyMatrix[destination, source] = 1;

                if (!adjacencyList.ContainsKey(source))
                {
                    adjacencyList[source] = new List<int>();
                }
                if (!adjacencyList.ContainsKey(destination))
                {
                    adjacencyList[destination] = new List<int>();
                }

                adjacencyList[source].Add(destination);
                adjacencyList[destination].Add(source);
            }

            public void DisplayMatrix()
            {
                Console.WriteLine("Adjacency Matrix:");
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        Console.Write(adjacencyMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void DisplayList()
            {
                Console.WriteLine("Adjacency List:");
                foreach (var pair in adjacencyList)
                {
                    Console.Write($"{pair.Key} -> ");
                    foreach (var vertex in pair.Value)
                    {
                        Console.Write($"{vertex} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}


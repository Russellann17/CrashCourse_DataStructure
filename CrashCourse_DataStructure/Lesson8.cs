using System;
using System.Collections.Generic;

namespace CrashCourse_DataStructure
{
    class Lesson8
    {
        public static void L8_Heaps()
        {
            MinHeap minHeap = new MinHeap();
            MaxHeap maxHeap = new MaxHeap();

            Console.WriteLine("Enter numbers for Min-Heap (type 'done' to finish):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;
                if (int.TryParse(input, out int value))
                    minHeap.Insert(value);
                else
                    Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Min-Heap Extract Min: " + minHeap.Min());

            Console.WriteLine("\nEnter numbers for Max-Heap (type 'done' to finish):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;
                if (int.TryParse(input, out int value))
                    maxHeap.Insert(value);
                else
                    Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Max-Heap Extract Max: " + maxHeap.Max());
        }
    }

    class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int value)
        {
            heap.Add(value);
            ValueUp(heap.Count-1);
        }
        public int Min()
        {
            if (heap.Count == 0) 
                throw new InvalidOperationException("Heap is empty");

            int min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            ValueDown(0);
            return min;
        }
        private void ValueUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1)/2;
                if (heap[index] >= heap[parentIndex])
                    break;
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }
        private void ValueDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while ( index <= lastIndex)
            {
                int leftValue = 2 * index + 1;
                int rightValue = 2 * index + 2;
                int smallest = index;

                if (leftValue <= lastIndex && heap[leftValue] < heap[smallest])
                    smallest = leftValue;
                if(rightValue <= lastIndex && heap[rightValue] > heap[smallest])
                    smallest = rightValue;

                if (smallest == index) break;
                Swap(index, smallest);
                index = smallest;
            }
        }
        private void Swap(int index, int smallest)
        {
            int temp = heap[index];
            heap[index] = heap[smallest];   
            heap[smallest] = temp;
        }
    }

    class MaxHeap
    {
        private List<int> heap = new List<int>();
        public void Insert(int value)
        {
            heap.Add(value);
            ValueUp(heap.Count - 1);
        }
        public int Max()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty");
            int max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            ValueDown(0);
            return max;
        }
        private void ValueUp(int index)
        {
            while(index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index] <= heap[parentIndex])
                    break;
                Swap(index, parentIndex);
                index = parentIndex;
            }
        }
        private void ValueDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (index <= lastIndex)
            {
                int leftValue = 2 * index + 1;
                int rightValue = 2 * index + 2;
                int largest = index;

                if (leftValue <= lastIndex && heap[leftValue] > heap[largest])
                    largest = leftValue;
                if (rightValue <= lastIndex && heap[rightValue] > heap[largest])
                    largest = rightValue;

                if (largest == index) break;
                Swap(index, largest);
                index = largest;
            }
        }
        private void Swap(int index, int parentIndex)
        {
            int temp = heap[index];
            heap[index] = heap[parentIndex];
            heap[parentIndex] = temp;
        }
    }
}

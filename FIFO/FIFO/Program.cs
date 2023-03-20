namespace FIFO;

using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        myQueue.Enqueue(44);
        myQueue.Enqueue(44);


        int firstItem = myQueue.Dequeue();
        int secondItem = myQueue.Dequeue();
        int thirdItem = myQueue.Dequeue();
        //int fourItem = myQueue.Dequeue();

        Console.WriteLine($"First item: {firstItem}"); // виведе "First item: 10"
        Console.WriteLine($"Second item: {secondItem}"); // виведе "Second item: 20"
        Console.WriteLine($"Third item: {thirdItem}"); // виведе "Third item: 30"
        Console.WriteLine($"Queue count: {myQueue.Count}"); // виведе "Queue count: 2"
    }
}
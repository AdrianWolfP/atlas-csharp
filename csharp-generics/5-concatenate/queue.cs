using System;

/// <summary>
/// This class implements a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// This class represents a node in the queue.
    /// </summary>
    class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T value;
        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node next;
        /// <summary>
        /// Initializes a new instance of the Node class with the specified value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// The head node of the queue.
    /// </summary>
    Node head;
    /// <summary>
    /// The tail node of the queue.
    /// </summary>
    Node tail;

    /// <summary>
    /// The number of elements in the queue.
    /// </summary>
    int count;

    /// <summary>
    /// This method returns the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements stored in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    } 
    
    public T Enqueue(T value)
    {
        Node node == new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
        return node.value;
    }
    
    /// <summary>
    /// This method removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The element at the front of the queue, or the default value of T if the queue is empty.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = head;
        head = node.next;
        count--;
        return node.value;
    }

    /// <summary>
    /// This method returns the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The element at the front of the queue, or the default value of T if the queue is empty.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// This method prints all the elements in the queue to the console.
    /// </summary>
    /// <remarks>This method does not modify the queue in any way.</remarks>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Node node = head;
        while (node != null)
        {
            Console.WriteLine(node.value);
            node = node.next;
        }
    }

    /// <summary>
    /// This method returns the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        int i = 0;
        Node node = head;
        while (node != null)
        {
            i++;
            node = node.next;
        }
        count = i;
        return count;
    }

    /// <summary>
    /// This method concatenates all the elements in the queue into a single string.
    /// </summary>
    /// <remarks>
    /// This method is intended for use with queues of strings or characters only.
    /// If the queue contains elements of a different type, this method will return null.
    /// </remarks>
    /// <returns>
    /// A string containing all the elements in the queue, separated by a single space.
    /// If the queue is empty, this method returns null.
    /// If the queue contains elements of a type other than string or char, this method returns null.
    /// </returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        Node node = head;
        string result = "";
        while (node != null)
        {
            result += node.value;
            if (typeof(T) == typeof(string) && node.next != null)
                result += " ";
            node = node.next;
        }
        return result;
    }
}
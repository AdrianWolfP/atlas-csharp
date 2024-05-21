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

    /// <summary>
    /// This method adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The element to add to the queue.</param>
    /// <returns>The element that was added to the queue.</returns>
    public T Enqueue(T value)
    {
        Node node = new Node(value);
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
}
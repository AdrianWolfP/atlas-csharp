using System;

/// <summary>
/// This class represents a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of the elements in the queue.</typeparam>
/// <remarks>
/// This class provides a simple implementation of a queue data structure.
/// The queue is implemented as a singly linked list, with a head and a tail.
/// Elements are added to the end of the queue (enqueue) and removed from the front of the queue (dequeue).
/// </remarks>
public class Queue<T>
{
    /// <summary>
    /// This method returns the type of the elements in the queue.
    /// </summary>
    /// <returns>
    /// A System.Type object representing the type of the elements in the queue.
    /// </returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
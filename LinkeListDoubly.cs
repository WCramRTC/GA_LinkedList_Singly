using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedList_Singly
{
    internal class LinkeListDoubly<T>
    {

           // Internal Node class to represent elements in the doubly linked list.
        protected class Node<T>
        {
            T _data;
            Node<T> _next;
            Node<T> _previous;

            public Node(T data)
            {
                _data = data;
            }

            public Node<T> Next { get => _next; set => _next = value; }
            public Node<T> Previous { get => _previous; set => _previous = value; }
            public T Data { get => _data; set => _data = value; }
        }

        Node<T> _head;  // Reference to the first element (head) of the doubly linked list.
        Node<T> _tail;  // Reference to the last element (tail) of the doubly linked list.

        // Method to add an element to the end of the doubly linked list.
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head == null)
            {
                // If the list is empty, set both head and tail to the new node.
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                // Otherwise, add the new node to the end of the list.
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
        }

        // Method to remove an element with specified data from the doubly linked list.
        public bool RemoveElement(T data)
        {
            Node<T> current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                {
                    // Found the node to remove.

                    if (current.Previous != null)
                    {
                        // Update the previous node's Next pointer.
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        // The node to remove is the head; update the head reference.
                        _head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        // Update the next node's Prev pointer.
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        // The node to remove is the tail; update the tail reference.
                        _tail = current.Previous;
                    }

                    // Optional: Release memory for the removed node (if needed).
                    current = null;

                    return true; // Node removed successfully.
                }

                current = current.Next;
            }

            return false; // Node with the specified data not found.
        }

        // Method to print the elements of the doubly linked list in forward order.
        public void PrintForward()
        {
            Node<T> current = _head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        // Method to print the elements of the doubly linked list in reverse order.
        public void PrintReverse()
        {
            Node<T> current = _tail;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Previous;
            }
        }
    }
}

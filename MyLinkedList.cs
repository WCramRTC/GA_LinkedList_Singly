using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedList_Singly
{
    public class MyLinkedList
    {
        Node _first;  // Reference to the first node in the linked list
        int count;    // Keeps track of the number of nodes in the linked list

        // Constructor to initialize an empty linked list
        public MyLinkedList()
        {
            count = 0;
        }

        // Constructor to initialize a linked list with one node containing the given data
        public MyLinkedList(string data)
        {
            _first = new Node(data);
            count = 1;
        }

        // Insertion Methods:

        // Inserts a new node with the given data at the beginning of the linked list.
        public void InstertAtStart(string data)
        {
            Node temp = new Node(data);

            if (_first == null)
                _first = temp; // If the list is empty, set the new node as the first node
            else
            {
                temp.Next = _first; // Set the new node's Next reference to the current first node
                _first = temp; // Update the first node to the new node
            }

            count++;
        }

        // Inserts a new node with the given data at the end of the linked list.
        public void InsertAtEnd(string data)
        {
            Node temp = new Node(data);

            if (_first == null)
                _first = temp; // If the list is empty, set the new node as the first node
            else
            {
                Node current = _first;

                while (current.Next != null)
                    current = current.Next;

                current.Next = temp; // Set the Next reference of the last node to the new node
            }

            count++;
        }

        // Inserts a new node with the given data before the specified node in the linked list.
        public void InsertBeforeNode(string data, string insertBefore)
        {
            Node temp = new Node(data);

            if (_first == null)
                _first = temp; // If the list is empty, set the new node as the first node
            else
            {
                Node current = _first;

                while (current.Next.Next != null)
                {
                    if (insertBefore == current.Next.Next.Data)
                    {
                        Console.WriteLine($"Found It! {current} - {current.Next.Data} - {current.Next.Next.Data} ");
                        temp.Next = current.Next.Next;
                        current.Next.Next = temp;
                        count++;
                        return;
                    }
                    Console.WriteLine("is running");
                    current = current.Next;
                }
            }
        }

        // Indexer to access a node by its position in the linked list.
        public Node this[int flag]
        {
            get
            {
                int index = 0;

                if (index > count)
                    return null; // The specified position is out of bounds

                Node current = _first;

                while (current != null && index != flag)
                {
                    index++;
                    current = current.Next;
                }

                return current;
            }
        }

        // Returns the number of elements/nodes in the linked list.
        public int NumberOfElements()
        {
            Node current = _first;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        // Searches for a node with the specified data in the linked list and returns it.
        public Node Search(string data)
        {
            Node current = _first;

            while (current != null)
            {
                if (data == current.Data)
                    return current; // Found a node with the specified data

                current = current.Next;
            }
            return null; // The node with the specified data was not found
        }

        // Deletion Methods:

        // Deletes the first node in the linked list.
        public bool DeleteAtStart()
        {
            if (_first == null)
                return false; // The list is empty, nothing to delete
            else
            {
                _first = _first.Next; // Set the first node to the next node, effectively removing the first node
                count--;
                return true;
            }
        }

        // Deletes the last node in the linked list.
        public bool DeleteAtEnd()
        {
            Node current = _first;

            if (current == null)
                return false; // The list is empty, nothing to delete
            else
            {
                Console.WriteLine("Looking For Data");
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null; // Remove the reference to the last node, effectively deleting it
                count--;
                return true;
            }
        }

        // Deletes the node with the specified data from the linked list.
        public bool DeleteByValue(string value)
        {
            if (_first == null)
                return false; // The list is empty, nothing to delete

            Node current = _first;

            while (current.Next.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next; // Remove the reference to the node with the specified value
                    count--;
                    return true;
                }

                current = current.Next;
            }

            return false; // The node with the specified value was not found
        }

        // Returns the count of elements in the linked list.
        public int Count { get => count; set => count = value; }

        // Displays all the elements/nodes in the linked list.
        public void Display()
        {
            Node current = _first;

            Console.WriteLine($"Current Count: {count}");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        // Node class representing elements of the linked list.
        public class Node
        {
            string _data;
            Node _next;

            public Node(string data)
            {
                _data = data;
            }

            public Node(string data, Node next)
            {
                _data = data;
                _next = next;
            }

            public string Data { get => _data; set => _data = value; }
            internal Node Next { get => _next; set => _next = value; }
        } // Node class

    } // MyLinkedList class

} // namespace

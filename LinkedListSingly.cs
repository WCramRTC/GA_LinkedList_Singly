using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedList_Singly
{
    internal class LinkedListSingly
    {

        Node _head;
        int currentCount = 0;

        public int CurrentCount { get => currentCount; set => currentCount = value; }

        // 

        // GetByIndex
        public int GetByIndex(int index)
        {
            Node current = _head;
            int currentIndex = 0;


            // If the index is negative or the index is above our count 
            // throw an exception
            if(index < 0 || index >= currentCount)
            {
                throw new IndexOutOfRangeException();
            }

            while(current != null)
            {
                if(currentIndex == index)
                {
                    return current.Data;
                }

                currentIndex++;
                current = current.Next;
            }

            return -1;
        }

        public int this[int index]
        {
            get
            {
                Node current = _head;
                int currentIndex = 0;


                // If the index is negative or the index is above our count 
                // throw an exception
                if (index < 0 || index >= currentCount)
                {
                    throw new IndexOutOfRangeException();
                }

                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        return current.Data;
                    }

                    currentIndex++;
                    current = current.Next;
                }

                return -1;
            }
        }

        // Count
        public int Count()
        {
            Node current = _head;
            int count = 0;

            while(current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        // Maintain Integrity
        public void MaintainIntegrity()
        {
            Node current = _head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            CurrentCount = count;
        }

        // Remove
        public int RemoveFirst()
        {
            // Save the data from the first element
            int temp = _head.Data;

            // Replace the head with the next reference
            _head = _head.Next;

            // Decrement currentCount
            currentCount--;

            // Return the data from the first element
            return temp;
        }




        // Add method

        public void Add(int data)
        {
            // First we create a new node to hold our data.
            Node newNode = new Node(data);

            // Check to see if the list is empty
            // If yes, assign the new node to _head
            if(_head == null)
            {
                _head = newNode;
            }
            else
            {
                // Create a node to keep track of the current node
                Node current = _head;
                // Loop through our linked list
                // If .next is empty. then we are at the last link in our list
                while(current.Next != null)
                {
                    current = current.Next;
                }

                // If we are at the end of our linked list, add our new node
                current.Next = newNode;
            }

            // Increment the amount
            currentCount++;


        } // Add

        // Create the DisplayMethod

        public void Display()
        {
            // Create a referece to head
            Node current = _head;

            // while loop that checks if current != null

            while(current != null)
            {
                Console.Write(current.Data + " ");
                // set current to the next node
                current = current.Next;
            }
            Console.WriteLine();

        } // Display


        // Create our node for our Linked List
        public class Node
        {
            // 2 fields
            // data
            // .next address reference
            int _data;
            Node _next;

            public Node(int data)
            {
                _data = data;
            }

            public int Data { get => _data; set => _data = value; }
            public Node Next { get => _next; set => _next = value; }
        }

    } // class

} // namespace

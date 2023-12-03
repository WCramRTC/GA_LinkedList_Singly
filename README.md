
# Guide to Singly Linked Lists in C#

## Tutorials

### Introduction

A Singly Linked List is a linear data structure where each element (commonly called a node) contains a data part and a link to the next node in the list. This guide will show you how to create, add to, and sort a Singly Linked List in C#.

### Starting Code
```csharp
using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SinglyLinkedList
{
    public Node Head;

    public SinglyLinkedList()
    {
        Head = null;
    }
}
```

**Understanding the Code:** We define a `Node` class representing each element in the list and a `SinglyLinkedList` class to manage the list.

---

### **1. Adding a Node**

**Objective:** Learn to add a new node to the list.

**Method Implementation:**
```csharp
public void AddNode(int data)
{
    Node newNode = new Node(data);

    if (Head == null)
    {
        Head = newNode;
    }
    else
    {
        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }
}
```

**Using the Method:**
```csharp
SinglyLinkedList myList = new SinglyLinkedList();
myList.AddNode(5);
myList.AddNode(10);
```

---

### **2. Displaying the List**

**Objective:** Learn to display the contents of the list.

**Method Implementation:**
```csharp
public void PrintList()
{
    Node current = Head;
    while (current != null)
    {
        Console.Write(current.Data + " ");
        current = current.Next;
    }
}
```

**Using the Method:**
```csharp
myList.PrintList();
```

---

### **3. Sorting the List**

**Objective:** Implement a sorting mechanism (e.g., Bubble Sort) for the list.

**Method Implementation:**
```csharp
public void SortList()
{
    Node current, index;
    int temp;

    for (current = Head; current != null; current = current.Next)
    {
        for (index = current.Next; index != null; index = index.Next)
        {
            if (current.Data > index.Data)
            {
                temp = current.Data;
                current.Data = index.Data;
                index.Data = temp;
            }
        }
    }
}
```

**Using the Method:**
```csharp
myList.SortList();
```

---

### Summary

In this guide, we have explored how to implement a basic Singly Linked List in C#, including adding new nodes, displaying the list, and sorting it. Linked lists are fundamental in computer science and understanding them paves the way for learning more complex data structures.

---

### Additional Tips and Resources

- **Understanding Pointers:** Grasping the concept of references or pointers is crucial in linked lists.
- **Memory Efficiency:** Linked lists can be more memory-efficient than arrays for certain operations.
- **Further Learning:** Explore variations like Doubly Linked Lists and Circular Linked Lists.
- **Syntax Highlighting:** Notice how class and method declarations are highlighted in the editor for clarity.

---

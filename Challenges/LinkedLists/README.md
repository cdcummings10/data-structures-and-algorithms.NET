# .NET Data Structures and Algorithms

## Linked Lists part2

*Author: Chris Cummings*

---

## Description

Write the following methods for the Linked List class:

.append(value) which adds a new node with the given value to the end of the list

.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node

.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node

---

## Approach

.append = Iterated through the linked list and once the last node pointed to null, switched the pointer to the new node.

.insertBefore = Iterate through the linked list and search each node value for the value inputted into the method.
When the value is found, reassign the previous node Next to new node and the new Node Next to the current node.

.insertAfter = Iterate through the linked list and search each node value for the value inputted into the mehtod.
When the value is found, reassign the new node Next to current node Next and reassign current node Next to new Node.

---

## Visuals
![Code Challenge 6 Whiteboard](../../assets/linkedListspt2.jpg)

---



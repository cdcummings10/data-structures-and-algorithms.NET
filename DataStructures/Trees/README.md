# .NET Data Structures and Algorithms

## Multi Bracket Validation

*Author: Chris Cummings*

---

## Description

Create a Node class that has properties for the value stored in the node, 
the left child node, and the right child node.

Create a BinaryTree class. 
Define a method for each of the depth first traversals called `preOrder`, `inOrder`,
 and `postOrder` which returns an array of the values, ordered appropriately.

Write a breadth first traversal method which takes a Binary Tree as its unique 
input. Without utilizing any of the built-in methods available to your language, 
traverse the input tree using a Breadth-first approach.

---

## Approach

**.PreOrder** - I created a public method which creates a List and returns the list
when finished. Inside the method, I call an overloaded version of .PreOrder and
send in the root node as well as the list.  The overloaded method adds the node
value to the list, and then checks the left child. If the child is not null, 
the method is called recursively.  It then checks the right child and does the
same thing.

**.InOrder** - InOrder is just like .PreOrder, except instead of adding the value
to the list before checking the leftchild, it is added after.

**.PostOrder** - PostOrder is just like .PreOrder, except instead of adding the value
to the list at the beginning, the value is added after both the left and right 
children have been checked.

**.BreadthFirstTraversal** - I first add the root to the queue. I then create a
while loop that runs while the front of the queue is not null using Queue.Peek.
I then dequeue the node which I call "front", add the front.Value to the return
list, and enqueue it's two children if they are not null.  The loop runs again
and continues this process until there is nothing left in the queue.

---

## Visuals
*No whiteboard for this challenge.*

---

## Change Log

1.1: Finished Breadth, PreOrder, PostOrder, InOrder and unit tests. - 11/6/2019

---


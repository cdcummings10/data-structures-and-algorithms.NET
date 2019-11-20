# .NET Data Structures and Algorithms

## Insertion Sort

*Author: Chris Cummings*

---

## Description

Write a method called InsertionSort that takes in an array of integers and
returns the array sorted from least to greatest.

---

## Approach

I first created a for loop for the array, and inside I defined a j variable
and a temp variable.  The j variable represents everything to the left of
array[j] as being already sorted. The temp variable is a variable I can use
inside of a while loop to keep track of the current number being evaluated.

I then created a while loop that ran while j >= 0 (the end of the array)
and while the temp variable was less than array[j]. In this loop I stepped
through the the array, replacing the array[j+1] with array[j], and setting
j to j-1.

---

## Blog
[Link to Blog](https://github.com/cdcummings10/data-structures-and-algorithms.NET/blob/master/Challenges/InsertionSort/Blog.md)

---

## Change Log

1.1: Finished Insertion Sort Challenge - 11/18/2019

---


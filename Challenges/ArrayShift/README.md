# .NET Data Structures and Algorithms

## Insert Shift Arrays

*Author: Chris Cummings*

---

## Description

Write a function called insertShiftArray which takes in an array and the value to be added. 
Without utilizing any of the built-in methods available to your language, 
return an array with the new value added at the middle index.

---

## Approach

In order to calculate the middle of the array under the assumption that I needed to ceiling my division,
I wrote an if statement for odd or even lengths that adds 1 to the middle index if its odd.  
I created a boolean to tell if an object was inserted in order to use in my for loop so after 
the halfway mark, the value would be using the original array index -1 to account for an extra 
value being added to the array.

---

## Visuals
![Code Challenge 2 Whiteboard](../../../assets/arrayShift.jpg)

---

## Change Log

1.1: Finished Code Challenge 2 - 10/17/2019

---


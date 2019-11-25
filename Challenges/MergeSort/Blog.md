# Merge Sort
---

Merge sort is a method of sorting an array.  Merge sort sorts an array by splitting the array in half recursively until there are only
single numbers left in the array, and then combining the arrays as we go back through the call stack.

---

## Pseudo Code

```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left



```

---

## Explanation

![Merge Sort Image 1](assets/Blog1.png)
1) The method first sorts the input array into two arrays, a left and right array.  The array is split by defining a middle
point which is the array length / 2.
![Merge Sort Image 2](assets/Blog2.png)
2) The method is called recursively, splitting the array again.
![Merge Sort Image 3](assets/Blog3.png)
3) The recursive calls stop when all arrays have a length of 1.
![Merge Sort Image 4](assets/Blog4.png)
4) Once the length of the array is one, the recursive functions start popping off the stack. The function merges the left and 
right arrays together, sorting them as they go.

---

# Efficiency

### Time: 
* Best: O(nlg(n))
* Worst: O(nlg(n))
  * The function runs consistently every time going through each variable, so the O of time is based on the number of recursive
  calls it takes to break the left and right down to be length of 1.
### Space:
* Best: O(n)
* Worst: O(n)
  * The merge sort creates variables in space, so it creates a variable for each number, thus O(n).
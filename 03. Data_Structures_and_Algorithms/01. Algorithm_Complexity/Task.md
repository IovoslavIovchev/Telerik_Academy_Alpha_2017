## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `N`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i = 0; i < arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```

  **Explanation:**
    We have a for-loop that iterates `N` times and each time we have linear traversing 
    of the array, which means that the following code runs in `exponential time O(N^2)`.

2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `N * M`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row = 0; row < matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```

  **Explanation:** We jave a loop that iterates through the rows and only starts iterating through the columns if the number at index `0` at the said row is `even`. Therefore the *best case* performance is `O(N)` and the *worst case* performance is `O(N * M)`;

3. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `N * M`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```

   **Explanation:** `NB`: The following code *throws an exception* if **n != m**! Otherwise the performance is `O(N * M)`
namespace Code;

public static class Question8
{
  // 1.8 Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.

  // Space: O(N + M)
  // Time: O(N2)
  public static void ZeroMatrix(int[,] matrix)
  {
    if (matrix == null)
    {
      throw new ArgumentNullException(nameof(matrix));
    }

    var zeroRows = new List<int>();
    var zeroCols = new List<int>();

    var numCols = matrix.GetLength(0) + 1;
    var numRows = matrix.Length / numCols;

    for (var row = 0; row < numRows; row++)
    {
      for (var col = 0; col < numCols; col++)
      {
        if (matrix[row, col] == 0)
        {
          zeroRows.Add(row);
          zeroCols.Add(col);
        }
      }
    }

    foreach (var row in zeroRows)
    {
      for (var col = 0; col < numCols; col++)
      {
        matrix[row, col] = 0;
      }
    }

    foreach (var col in zeroCols)
    {
      for (var row = 0; row < numRows; row++)
      {
        matrix[row, col] = 0;
      }
    }
  }
}
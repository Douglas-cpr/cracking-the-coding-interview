namespace Helpers;

public static class MatrixHelper
{
  // Example input:
  // 1 2 3 4
  // Example output:
  // 1 2
  // 3 4
  public static int[,] CreateMatrix(int[] list)
  {
    if (list.Length == 0) throw new ArgumentNullException("Input shouldn't not be empty array");

    var size = MatrixSize(list);
    var matrix = new int[size, size];
    var listCounter = 0;
 
    for (var r = 0; r < size; r++)
    {
      for (var c = 0;  c < size; c++)
      {
        matrix[r, c] = list[listCounter++];
      }
    }

    return matrix;
  }

  public static int MatrixSize(int[] list)
  {
    var size = Math.Sqrt(list.Length);
    if (size % 1 != 0) throw new ArgumentException("Number of elements must be a perfect square");
    return (int)size;
  }

  public static int[,] CreateMatrix(int[] list, int numRows, int numCols)
  {
    if (numRows == 0 || numCols == 0) throw new ArgumentException("Number os rows and cols must be grather than 0");
    if (list.Length == 0) throw new ArgumentNullException("Input shouldn't not be empty array");

    var matrix = new int[numRows, numCols];
    var listCounter = 0;

    for (var r = 0; r < numRows; r++)
    {
      for (var c = 0; c < numCols; c++)
      {
        matrix[r, c] = list[listCounter++];
      }
    }

    return matrix;
  }
}


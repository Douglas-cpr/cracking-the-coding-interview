using System.Collections;
using System.Text;

namespace Code;

// 1.7 Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?

public static class Question7
{


  // Space: O(N^2)
  // Time: O(N^2)
  public static int[,] RotateMatrix(int[,] matrix)
  {
    if (matrix == null)
    {
      throw new ArgumentNullException(nameof(matrix));
    }

    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
      throw new ArgumentException("Matrix needs to be square", nameof(matrix));
    }
 
    var size = matrix.GetLength(0);
    var result = new int[size, size];


    // transpose matrix
    for (var row = 0; row < size; row++) {
      for (var col = row; col < matrix.GetLength(row); col++)
      {
        if (row != col)
        {
          var temp = matrix[row, col];
          matrix[row, col] = matrix[col, row];
          matrix[col, row] = temp;
        }
      }
    }

    // rotate
    for (var i = 0; i < size; i++) 
    {
      for (var j = 0; j < size / 2; j++)
      {
        var temp = matrix[i, j];
        matrix[i, j] = matrix[i, size - j - 1];
        matrix[i, size - j - 1] = temp;
      }
    }

    return matrix;
  }

  // Space: O(1)
  // Time: O(N^2)
  public static void RotateMatrixInPlace(int[,] matrix)
  {
    if (matrix == null)
    {
      throw new ArgumentNullException(nameof(matrix));
    }

    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
      throw new ArgumentException("Matrix needs to be square", nameof(matrix));
    }

    var size = matrix.GetLength(0);
    var offset = 0;

    while (size > 1)
    {
      for (int i = 0; i < size - 1; i++)
      {
        var orig = matrix[offset, i + offset];

        // Top left
        matrix[offset, i + offset] = matrix[size - 1 - i + offset, offset];

        // Bottom left
        matrix[size - 1 - i + offset, offset] = matrix[size - 1 + offset, size - 1 - i + offset];

        // Bottom right
        matrix[size - 1 + offset, size - 1 - i + offset] = matrix[i + offset, size - 1 + offset];

        // Top right
        matrix[i + offset, size - 1 + offset] = orig;
      }

      size -= 2;
      offset++;
    }
  }
}
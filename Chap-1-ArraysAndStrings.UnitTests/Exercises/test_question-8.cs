namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion8
{

  [Fact]
  public void ShouldSetZeroAllOfRow_WhenHasOneZeroInRow()
  {
    var numRows = 2;
    var numCols = 3;
    var matrix = MatrixHelper.CreateMatrix(new int[] { 1, 2, 0, 4, 5, 6}, numRows, numCols);
    var expectedResponse = MatrixHelper.CreateMatrix(new int[] { 1, 2, 0, 4, 5, 0 }, numRows, numCols);

    Question8.ZeroMatrix(matrix);

    for (var row = 0; row < numRows; row++)
      for (var col = 0; col < numCols; col++) 
        matrix[row, col].Should().Be(expectedResponse[row, col]);
  }
}
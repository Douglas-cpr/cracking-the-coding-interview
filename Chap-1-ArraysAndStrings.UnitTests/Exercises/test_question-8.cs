namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion8
{

  [Fact]
  public void ShouldSetZeroAllOfRow_WhenHasOneZeroInRow()
  {
    var numRows = 2;
    var numCols = 3;
    var matrix = MatrixHelper.CreateMatrix(new int[] { 1, 2, 0, 4, 5, 6}, numRows, numCols);
    var expectedResponse = MatrixHelper.CreateMatrix(new int[] { 0, 0, 0, 4, 5, 6 }, numRows, numCols);

    Question8.ZeroMatrix(matrix);

      for (var col = 0; col < numCols; col++) 
        matrix[0, col].Should().Be(expectedResponse[0, col]);
  }

  [Fact]
  public void ShouldSetZeroAllOfCol_WhenHasOneZeroInCol()
  {
    var numRows = 2;
    var numCols = 3;
    var matrix = MatrixHelper.CreateMatrix(new int[] { 0, 2, 3, 4, 5, 6}, numRows, numCols);
    var expectedResponse = MatrixHelper.CreateMatrix(new int[] { 0, 2, 3, 0, 5, 6 }, numRows, numCols);

    Question8.ZeroMatrix(matrix);

    for (var row = 0; row < numRows; row++)
        matrix[row, 0].Should().Be(expectedResponse[row, 0]);
  }

  [Fact]
  public void ShouldThrowAnError_WhenMatrixIsNull() 
  {
    var action = () => Question8.ZeroMatrix(null);
    action.Should().Throw<ArgumentNullException>();
  }
}
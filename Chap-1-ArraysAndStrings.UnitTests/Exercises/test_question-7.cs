namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion7
{

  [Fact]
  public void Should_RotateMatrixIn90Degrees()
  {
    var inputMatrix = MatrixHelper.CreateMatrix(new int[] { 1, 2, 3, 4 });
    var expectedRotatedMatrix = MatrixHelper.CreateMatrix(new int[] { 3, 1, 4, 2 });

    var rotatedMatrix = Question7.RotateMatrix(inputMatrix);
    var size = Math.Sqrt(rotatedMatrix.Length);

    for (var row = 0; row < size; row++)
    {
      for (var col = 0; col < size; col++)
      {
        var result = rotatedMatrix[row, col];
        var expected = expectedRotatedMatrix[row, col];
        result.Should().Be(expected);
      }
    }
  }

  [Fact]
  public void Should_RotateMatrixIn90DegreesInPlace()
  {
    var inputMatrix = MatrixHelper.CreateMatrix(new int[] { 1, 2, 3, 4 });
    var expectedRotatedMatrix = MatrixHelper.CreateMatrix(new int[] { 3, 1, 4, 2 });

    Question7.RotateMatrixInPlace(inputMatrix);
    var size = Math.Sqrt(inputMatrix.Length);

    for (var row = 0; row < size; row++)
    {
      for (var col = 0; col < size; col++)
      {
        var result = inputMatrix[row, col];
        var expected = expectedRotatedMatrix[row, col];
        result.Should().Be(expected);
      }
    }
  }

}
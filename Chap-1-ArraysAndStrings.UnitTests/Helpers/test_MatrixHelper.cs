namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestMatrixHelper
{
  [Fact]
   public void ShouldCreateAnMatrix_WhenInputPerfectSquareArray()
   {
      var input = new int[] { 1, 2, 3, 4 };
      var matrix = MatrixHelper.CreateMatrix(input);
      matrix.Should().BeOfType<int[,]>();
   }

   [Fact]
   public void ShouldCreateAn2x2Matrix_WhenInputAnArrayWithFourElements()
   {
      var input = new int[] { 1, 2, 3, 4 };
      var matrix = MatrixHelper.CreateMatrix(input);
      matrix.Length.Should().Be(4);
   }

   [Fact]
   public void ShouldCreateAnMatrixWithCorrectValues_WhenInputArrayWithFourElements()
   {
      var input = new int[] { 1, 2, 3, 4 };
      var matrix = MatrixHelper.CreateMatrix(input);

      var inputSquare = Math.Sqrt(input.Length);
      var expectedReponse = new List<int>();

      for(var row = 0; row < inputSquare; row++)
      {
         for (var col = 0; col < inputSquare; col++) expectedReponse.Add(matrix[row, col]);
      }

      for (var i = 0; i < input.Length; i++) input[i].Should().Be(expectedReponse[i]);
   }

   [Fact]
   public void ShouldThrowAnError_WhenAnyInputsIsNullOrEmpty()
   {
      var input = new int[] { };
      var action = () => MatrixHelper.CreateMatrix(input);
      action.Should().Throw<ArgumentNullException>();
   }

   [Fact]
   public void ShouldThrowAnError_WhenInputIsNotAPerfectSquare()
   {
      var input = new int[] { 1, 2, 3 };
      var action = () => MatrixHelper.CreateMatrix(input);
      action.Should().Throw<ArgumentException>();
   }
}
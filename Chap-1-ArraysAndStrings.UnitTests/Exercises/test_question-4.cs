namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion4
{
  [Fact]
  public void ShoudFalse_WhenInputIsEmpty()
  {
    var value = string.Empty;
    var response = Question4.PalindromePermutation(value);
    response.Should().BeFalse();
  }

  [Fact]
  public void ShouldFalse_WhenInputIsEmptySpace()
  {
    var value = " ";
    var response = Question4.PalindromePermutation(value);
    response.Should().BeFalse();
  }

  [Fact]
  public void ShouldFalse_WhenInputHasOneCharacter()
  {
    var value = "a";
    var response = Question4.PalindromePermutation(value);
    response.Should().BeFalse();
  }

  [Fact]
  public void ShouldTrue_WhenInputIsPalindromePermutation()
  {
    var value = "ab ba";
    var response = Question4.PalindromePermutation(value);
    response.Should().BeTrue();
  }

  [Fact]
  public void ShouldTrue_WhenInputIsPalindromePermutationButDifferentCase()
  {
    var value = "ab BA";
    var response = Question4.PalindromePermutation(value);
    response.Should().BeTrue();
  }
}
namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion6
{

  [Fact]
  public void ShouldCountCharacters_WhenHasMultipleRepeatedCharacters()
  {
    var input = "aaammlloppaa";
    var result = Question6.StringCompression(input);
    result.Should().Be("a3m2l2o1p2a2");
  }

  [Fact]
  public void ShouldCountedCharacter_WhenInputHasOneCharacter()
  {
    var input = "a";
    var result = Question6.StringCompression(input);
    result.Should().Be("a1");
  }

  [Fact]
  public void ShouldReturnWhiteSpace_WhenInputIsWhiteSpace()
  {
    var input = " ";
    var result = Question6.StringCompression(input);
    result.Should().Be(" ");
  }

  [Fact]
  public void ShouldReturnEmtpyString_WhenInputIsEmpty()
  {
    var input = string.Empty;
    var result = Question6.StringCompression(input);
    result.Should().Be(string.Empty);
  }
}
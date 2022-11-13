namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion1
{

    [Fact]
    public void ShouldTrue_WhenValueIsEmptyString()
    {
      var stringData = String.Empty;
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }

    [Fact]
    public void ShouldTrue_WhenValuenHasOneCharacter()
    {
      var stringData = "a";
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }

    [Fact]
    public void ShouldTrue_WhenValuenHasTwoSameCharactersButDifferentCase()
    {
      var stringData = "aA";
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }

    [Fact]
    public void ShouldFalse_WhenValuesHasTwoSameCharacters()
    {
      var stringData = "aa";
      var result = Question1.IsUnique(stringData);
      result.Should().BeFalse();
    }

    [Fact]
    public void ShouldFalse_WhenHasManyRepeatedCharacters()
    {
      var stringData = "aabbbcccccaaaakkk";
      var result = Question1.IsUnique(stringData);
      result.Should().BeFalse();
    }
}
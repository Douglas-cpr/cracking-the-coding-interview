namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion1
{

    [Fact]
    public void ReturnsTrue_WhenValueIsEmptyString()
    {
      var stringData = String.Empty;
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }


    [Fact]
    public void ReturnTrue_WhenValuenHasOneCharacter()
    {
      var stringData = "a";
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }

    [Fact]
    public void ReturnTrue_WhenValuenHasTwoSameCharacterButDifferentCase()
    {
      var stringData = "aA";
      var result = Question1.IsUnique(stringData);
      result.Should().BeTrue();
    }
}
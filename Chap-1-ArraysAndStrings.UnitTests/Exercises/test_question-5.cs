namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion5
{

  [Fact]
  public void ShouldFalse_WhenOriginalIsEqualToModifiedButDifferentCase()
  {
    var original = "PALE";
    var modified = "pale";
    var result = Question5.OneWay(original, modified);
    result.Should().BeFalse();
  }

  [Fact]
  public void ShouldFalse_WhenModifiedItIsTotallyDifferentFromOriginal()
  {
    var original = "ugadunga";
    var modified = "hahah";
    var result = Question5.OneWay(original, modified);
    result.Should().BeFalse();
  }


  [Fact]
  public void ShouldFalse_WhenModifiedHasTwoMoreCharacters()
  {
    var original = "pale";
    var modified = "palele";
    var result = Question5.OneWay(original, modified);
    result.Should().BeFalse();
  }

  [Fact]
  public void ShouldFalse_WhenModifiedHasTwoCharacterLess()
  {
    var original = "pale";
    var modified = "pa";
    var result = Question5.OneWay(original, modified);
    result.Should().BeFalse();
  }

  [Fact]
  public void ShouldTrue_WhenModifiedHasOneCharacterLess()
  {
    var original = "pale";
    var modified = "pal";
    var result = Question5.OneWay(original, modified);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldTrue_WhenOriginalAndValueAreEmpty()
  {
    var original = string.Empty;
    var modified = string.Empty;
    var result = Question5.OneWay(original, modified);
    result.Should().BeTrue();    
  }

  [Fact]
  public void ShoudTrue_WhenBothInputsAreEqual()
  {
    var original = "pale";
    var modified = "pale";
    var result = Question5.OneWay(original, modified);
    result.Should().BeTrue();
  }
}
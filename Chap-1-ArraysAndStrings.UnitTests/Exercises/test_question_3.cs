namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion3 
{
  [Fact]
  public void ShouldThrowAnArgumentNullException_WhenUrlIsEmpty()
  {
    var url = String.Empty;
    var urlLength = 0;

    var action = () => Question3.Urlify(url, urlLength);

    action.Should().Throw<ArgumentNullException>();
  }

  [Fact]
  public void ShouldThrowAnArgumentNullException_WhenUrlIsEmptySpace()
  {
    var url = " ";
    var urlLength = 1;

    var action = () => Question3.Urlify(url, urlLength);

    action.Should().Throw<ArgumentNullException>();
  }

  [Fact]
  public void ShouldThrowArgumentException_WhenUrlHasDifferentLengthFromInfo()
  {
    var url = "john doe";
    var urlLength = 3;

    var action = () => Question3.Urlify(url, urlLength);

    action.Should().Throw<ArgumentException>();
  } 

  [Fact]
  public void ShouldReturnUrlUrlify_WhenInputValidValues()
  {
    var url = "john doe";
    var urlLength = 8;

    var result = Question3.Urlify(url, urlLength);

    result.Should().Be("john%20doe");
  }

  [Fact]
  public void ShouldReturnUrlUrlify_WhenInputValidValuesUppercase()
  {
    var url = "JOHN DOE";
    var urlLength = 8;

    var result = Question3.Urlify(url, urlLength);

    result.Should().Be("JOHN%20DOE");
  }

  [Fact]
  public void ShouldReturnUrlUrlify_WhenInputUrlWithSpecialChars()
  {
    var url = "JOHN D@$ ";
    var urlLength = 9;

    var result = Question3.Urlify(url, urlLength);

    result.Should().Be("JOHN%20D@$%20");
  }
}


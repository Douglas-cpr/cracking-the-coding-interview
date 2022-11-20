namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion9
{

  [Fact]
  public void ShouldTrue_WhenS2IsRotateFromS1()
  {
    var s1 = "waterbottle";
    var s2 = "erbottlewat";

    var isSubstring = Question9.StringRotation(s1, s2);
    var isSubstringOpt = Question9.StringRotationOptimized(s1, s2);

    isSubstring.Should().BeTrue();
    isSubstringOpt.Should().BeTrue();
  }

  [Fact]
  public void ShouldFalse_WhenS2IsNotRotateFromS1()
  {
    var s1 = "waterbottle";
    var s2 = "erbottlewa";

    var isSubstring = Question9.StringRotation(s1, s2);
    var isSubstringOpt = Question9.StringRotationOptimized(s1, s2);

    isSubstring.Should().BeFalse();
    isSubstringOpt.Should().BeFalse();
  }

  [Fact]
  public void ShouldTrue_WhenS2IsRotateFromS1Short()
  {
    var s1 = "abc";
    var s2 = "cab";

    var isSubstring = Question9.StringRotation(s1, s2);
    var isSubstringOpt = Question9.StringRotationOptimized(s1, s2);

    isSubstring.Should().BeTrue();
    isSubstringOpt.Should().BeTrue();
  }

  [Fact]
  public void ShouldFalse_WhenInputHasDifferentLengths()
  {
    var s1 = "abca";
    var s2 = "cab";

    var isSubstring = Question9.StringRotation(s1, s2);
    var isSubstringOpt = Question9.StringRotationOptimized(s1, s2);

    isSubstring.Should().BeFalse();
    isSubstringOpt.Should().BeFalse();
  }

  [Fact]
  public void ShouldThrowAnArgumentNullException_WhenAnyInputBeEmpty()
  {
    var s1 = string.Empty;
    var s2 = "cab";

    var action = () => Question9.StringRotation(s1, s2);
    var actionOpt = () => Question9.StringRotationOptimized(s1, s2);

    action.Should().Throw<ArgumentNullException>();
    actionOpt.Should().Throw<ArgumentNullException>();
  }
}
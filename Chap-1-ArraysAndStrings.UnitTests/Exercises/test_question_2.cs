namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion2
{

    [Fact]
    public void ShouldThrowAnError_WhenAnyInputsIsNullOrEmpty()
    {
      var input1 = String.Empty;
      var input2 = "aaabbbccc";
      var action = () => Question2.CheckPermutation1(input1, input2);
      var action2 = () => Question2.CheckPermutation2(input1, input2);
      action.Should().Throw<ArgumentException>();
      action2.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void ShouldFalse_WhenInputsHasDifferentLenght()
    {
      var input1 = "a";
      var input2 = "aA";
      var result = Question2.CheckPermutation1(input1, input2);
      var result2 = Question2.CheckPermutation2(input1, input2);
      result.Should().BeFalse();
      result2.Should().BeFalse();
    }

    [Fact]
    public void ShouldFalse_WhenNotPermutation()
    {
      var input1 = "abc";
      var input2 = "def";
      var result = Question2.CheckPermutation1(input1, input2);
      var result2 = Question2.CheckPermutation2(input1, input2);
      result.Should().BeFalse();
    }

    [Fact]
    public void ShouldFalse_WhenIsPermutationButDifferenctCase()
    {
      var input1 = "abc";
      var input2 = "cbA";
      var result = Question2.CheckPermutation1(input1, input2);
      var result2 = Question2.CheckPermutation2(input1, input2);
      result.Should().BeFalse();
      result2.Should().BeFalse();
    }

    [Fact]
    public void ShouldTrue_WhenIsPermutation()
    {
      var input1 = "abc";
      var input2 = "cba";
      var result = Question2.CheckPermutation1(input1, input2);
      var result2 = Question2.CheckPermutation2(input1, input2);
      result.Should().BeTrue();
      result2.Should().BeTrue();
    }
}
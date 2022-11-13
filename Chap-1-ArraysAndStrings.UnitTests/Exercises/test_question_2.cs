namespace Chap_1_ArraysAndStrings.UnitTests;

public class TestQuestion2
{

    [Fact]
    public void ShouldThrowAnError_WhenAnyInputsIsNullOrEmpty()
    {
      var input1 = String.Empty;
      var input2 = "aaabbbccc";
      var action = () => Question2.CheckPermutation1(input1, input2);
      action.Should().Throw<ArgumentException>();
    }
}
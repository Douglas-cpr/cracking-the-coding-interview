namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion6
{
  private Node<string> BuildNodesToTest(List<string> values)
  {
    var nodes = new Node<string>(values[0]);
    for(var i = 1; i < values.Count; i++) nodes.AppendToTail(values[i]);
    return nodes;
  }

  [Fact]
  public void ShouldReturnTrue_WhenIsPalindrome()
  {
    var input = BuildNodesToTest(new() { "a", "i", "a" });
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnTrue_WhenIsPalindrome2()
  {
    var input = BuildNodesToTest(new() { "r", "e", "v", "i", "v", "e", "r" });
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnTrue_WhenHasOneCharacter()
  {
    var input = BuildNodesToTest(new() { "r" });
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnFalse_WhenIsNotPalindrome()
  {
    var input = BuildNodesToTest(new() { "b", "c", "a" });
    var result = Question6.Palindrome(input);
    result.Should().BeFalse();
  }
}
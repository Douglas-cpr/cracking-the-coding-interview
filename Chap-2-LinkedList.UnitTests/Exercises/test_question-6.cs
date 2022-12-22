using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion6
{
  [Fact]
  public void ShouldReturnTrue_WhenIsPalindrome()
  {
    var input = LinkedListHelpers.CreateLinkedList("a", "i", "a");
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnTrue_WhenIsPalindrome2()
  {
    var input = LinkedListHelpers.CreateLinkedList("r", "e", "v", "i", "v", "e", "r");
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnTrue_WhenHasOneCharacter()
  {
    var input = LinkedListHelpers.CreateLinkedList("r");
    var result = Question6.Palindrome(input);
    result.Should().BeTrue();
  }

  [Fact]
  public void ShouldReturnFalse_WhenIsNotPalindrome()
  {
    var input = LinkedListHelpers.CreateLinkedList("b", "c", "a");
    var result = Question6.Palindrome(input);
    result.Should().BeFalse();
  }
}
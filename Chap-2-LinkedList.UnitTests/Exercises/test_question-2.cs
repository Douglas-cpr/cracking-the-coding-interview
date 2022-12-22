using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion2
{
  [Fact]
  public void ShouldThrowAnArgumentOutOfRangeException_WhenKIsSmallerThanZero()
  {
    var nodes = LinkedListHelpers.CreateLinkedList(1, 2, 3, 4, 5, 6, 7);
    var action = () => Question2.ReturnKthToLast(nodes, -2);
    action.Should().Throw<ArgumentOutOfRangeException>();
  }

  [Fact]
  public void ShouldThrowAnArgumentOutOfRangeException_WhenKIsGreatherThanLinkedListSize()
  {
    var nodes = LinkedListHelpers.CreateLinkedList(1, 2, 3, 4, 5, 6, 7);
    var action = () => Question2.ReturnKthToLast(nodes, 99);
    action.Should().Throw<ArgumentOutOfRangeException>();
  }

  [Fact]
  public void ShouldReturnLastKthElement_WhenInputIsValid()
  {
    var nodes = LinkedListHelpers.CreateLinkedList(1, 2, 3, 4, 5, 6, 7);
    var response = Question2.ReturnKthToLast(nodes, 2);
    var expectedResponse = new Node<int>(6);
    expectedResponse.AppendToTail(7);
    while (expectedResponse != null && response != null)
    {
      response.Data.Should().Be(expectedResponse.Data);
      response = response.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
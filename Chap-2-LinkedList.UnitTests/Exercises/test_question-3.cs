using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion3
{
  [Fact]
  public void ShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = LinkedListHelpers.CreateLinkedList("a", "b");
    var result = Question3.DeleteMiddleNode(nodes);
    var expectedResponse = new Node<string>("a");
    expectedResponse.AppendToTail("b");
    while(result != null && expectedResponse != null)
    {
      result.Data.Should().Be(expectedResponse.Data);
      result = result.Next;
      expectedResponse = expectedResponse.Next;
    }
  }

  [Fact]
  public void ShouldThrowAnArgumentOutOfRangeException_WhenKIsSmallerThanZero()
  {
    var nodes = LinkedListHelpers.CreateLinkedList("a", "b", "c");
    var result = Question3.DeleteMiddleNode(nodes);
    var expectedResponse = new Node<string>("a");
    expectedResponse.AppendToTail("c");

    while(result != null && expectedResponse != null)
    {
      result.Data.Should().Be(expectedResponse.Data);
      result = result.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
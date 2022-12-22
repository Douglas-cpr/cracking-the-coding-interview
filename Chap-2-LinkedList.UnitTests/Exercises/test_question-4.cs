using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion4
{
  [Fact]
  public void BadImpShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = LinkedListHelpers.CreateLinkedList(1, 15, 10, 5, 6, 2, 11);
    var expectedResponse = LinkedListHelpers.CreateLinkedList(1, 2, 10, 5, 6, 15, 11);

    Question4.Partition(nodes, 5);

    while(nodes != null && expectedResponse != null)
    {
      nodes.Data.Should().Be(expectedResponse.Data);
      nodes = nodes.Next;
      expectedResponse = expectedResponse.Next;
    }
  }

  [Fact]
  public void OptimizesImpShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = LinkedListHelpers.CreateLinkedList(1, 15, 10, 5, 6, 2, 11);
    var expectedResponse = LinkedListHelpers.CreateLinkedList(1, 2, 15, 10, 5, 6, 11);

    Question4.PartitionOptimized(nodes, 5);

    while(nodes != null && expectedResponse != null)
    {
      nodes.Data.Should().Be(expectedResponse.Data);
      nodes = nodes.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
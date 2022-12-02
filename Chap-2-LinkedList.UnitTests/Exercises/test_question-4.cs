namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion4
{
  private Node<int> BuildNodesToTest(List<int> values)
  {
    var nodes = new Node<int>(values[0]);
    for(var i = 1; i < values.Count; i++) nodes.AppendToTail(values[i]);
    return nodes;
  }


  [Fact]
  public void BadImpShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = BuildNodesToTest(new() { 1, 15, 10, 5, 6, 2, 11 });
    var expectedResponse = BuildNodesToTest(new() { 1, 2, 10, 5, 6, 15, 11 });

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
    var nodes = BuildNodesToTest(new() { 1, 15, 10, 5, 6, 2, 11 });
    var expectedResponse = BuildNodesToTest(new() { 1, 2, 15, 10, 5, 6, 11 });

    Question4.PartitionOptimized(nodes, 5);

    while(nodes != null && expectedResponse != null)
    {
      nodes.Data.Should().Be(expectedResponse.Data);
      nodes = nodes.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
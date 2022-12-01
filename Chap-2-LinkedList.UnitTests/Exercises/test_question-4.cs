namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion4
{
  public Node<int> BuildNodesToTest(List<int> values)
  {
    var nodes = new Node<int>(values[0]);
    for(var i = 1; i < values.Count; i++) nodes.AppendToTail(values[i]);
    return nodes;
  }

  [Fact]
  public void ShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = BuildNodesToTest(new List<int>() { 1, 15, 10, 5, 6, 2, 11 });
    Question4.Partition(nodes, 5);
    var expectedResponse = new Node<int>(1);
    expectedResponse.AppendToTail(2);
    expectedResponse.AppendToTail(10);
    expectedResponse.AppendToTail(5);
    expectedResponse.AppendToTail(6);
    expectedResponse.AppendToTail(15);
    expectedResponse.AppendToTail(11);
    while(nodes != null && expectedResponse != null)
    {
      nodes.Data.Should().Be(expectedResponse.Data);
      nodes = nodes.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
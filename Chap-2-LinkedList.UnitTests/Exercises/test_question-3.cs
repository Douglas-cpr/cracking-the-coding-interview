namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion3
{
  public Node<string> BuildNodesToTest(List<string> values)
  {
    var nodes = new Node<string>(values[0]);
    for(var i = 1; i < values.Count; i++) nodes.AppendToTail(values[i]);
    return nodes;
  }

  [Fact]
  public void ShouldReturnHeadWithoutModification_WhenDontHaveMiddleNode()
  {
    var nodes = BuildNodesToTest(new List<string>() { "a", "b" });
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
    var nodes = BuildNodesToTest(new List<string>() { "a", "b", "c" });
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
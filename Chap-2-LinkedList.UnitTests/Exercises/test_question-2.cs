namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion2
{
  public Node BuildNodesToTest()
  {
    var nodes = new Node(1);
    nodes.AppendToTail(2);
    nodes.AppendToTail(3);
    nodes.AppendToTail(4);
    nodes.AppendToTail(5);
    nodes.AppendToTail(6);
    nodes.AppendToTail(7);
    return nodes;
  }
  

  [Fact]
  public void ShouldThrowAnArgumentOutOfRangeException_WhenKIsSmallerThanZero()
  {
    var nodes = BuildNodesToTest();
    var action = () => Question2.ReturnKthToLast(nodes, -2);
    action.Should().Throw<ArgumentOutOfRangeException>();
  }

  [Fact]
  public void ShouldThrowAnArgumentOutOfRangeException_WhenKIsGreatherThanLinkedListSize()
  {
    var nodes = BuildNodesToTest();
    var action = () => Question2.ReturnKthToLast(nodes, 99);
    action.Should().Throw<ArgumentOutOfRangeException>();
  }

  [Fact]
  public void ShouldReturnLastKthElement_WhenInputIsValid()
  {
    var nodes = BuildNodesToTest();
    var response = Question2.ReturnKthToLast(nodes, 2);
    var expectedResponse = new Node(6);
    expectedResponse.AppendToTail(7);
    while (expectedResponse != null && response != null)
    {
      response.Data.Should().Be(expectedResponse.Data);
      response = response.Next;
      expectedResponse = expectedResponse.Next;
    }
  }
}
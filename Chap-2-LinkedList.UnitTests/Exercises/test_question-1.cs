using System.Threading.Tasks;
using System.Collections.Generic;
namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion1
{
  public Node<int> BuildNodesToTest()
  {
    var nodes = new Node(1);
    nodes.AppendToTail(2);
    nodes.AppendToTail(2);
    nodes.AppendToTail(4);
    nodes.AppendToTail(10);
    nodes.AppendToTail(10);
    nodes.AppendToTail(66);
    return nodes;
  }

  [Fact]
  public void ShouldRemoveDuplicatedValuesFromLinkedList_WhenIsValid_Normal()
  { 
    var nodes = BuildNodesToTest();

    Question1.RemoveDups(nodes);

    var expectedData = new int[] { 1, 2, 4, 10, 66 };
    var j = 0;

    while(nodes.Next != null)
    {
      nodes.Data.Should().Be(expectedData[j]);
      j++;
      nodes = nodes.Next;
    }
  }

  [Fact]
  public void ShouldRemoveDuplicatedValuesFromLinkedList_WhenIsValid_TwoPointers()
  { 
    var nodes = BuildNodesToTest();

    Question1.RemoveDups_TwoPointers(nodes);
    
    var expectedData = new int[] { 1, 2, 4, 10, 66 };
    var j = 0;

    while(nodes.Next != null)
    {
      nodes.Data.Should().Be(expectedData[j]);
      j++;
      nodes = nodes.Next;
    }
  }

  [Fact]
  public void ShouldNotChange_WhenHasOndeNode()
  {
    var nodes = new Node(1);
    Question1.RemoveDups(nodes);
    Question1.RemoveDups_TwoPointers(nodes);
    nodes.Data.Should().Be(1);
  }
}

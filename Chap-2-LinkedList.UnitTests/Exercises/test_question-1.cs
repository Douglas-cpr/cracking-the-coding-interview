using System.Threading.Tasks;
using System.Collections.Generic;
using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion1
{
  [Fact]
  public void ShouldRemoveDuplicatedValuesFromLinkedList_WhenIsValid_Normal()
  { 
    var nodes = LinkedListHelpers.CreateLinkedList(1, 2, 2, 4, 10, 10, 66);

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
    var nodes = LinkedListHelpers.CreateLinkedList(1, 2, 2, 4, 10, 10, 66);

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

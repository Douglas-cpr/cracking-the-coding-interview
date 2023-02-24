using System.Reflection;
using System.Runtime.Intrinsics.X86;
using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion8
{
  [Fact]
  public void ShouldReturnLoopStart_WhenInputsAreValid()
  {
    var list = LinkedListHelpers.CreateLinkedList(1, 2, 3);
    var loopStart = LinkedListHelpers.AddLoop(list, 4, 5);

    var result = Question8.FindLoopStart(list);
    
    // result.Should().Equals(loopStart);

    var list2 = LinkedListHelpers.CreateLinkedList(1, 2, 3, 4, 6);
    var loopStart2 = LinkedListHelpers.AddLoop(list2, 5, 6, 7, 8);

    var result2 = Question8.FindLoopStart(list2);
    
    // result2.Should().BeSameAs(loopStart2);
    
  }
}
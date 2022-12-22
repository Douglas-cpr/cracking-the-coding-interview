using Chap_2_LinkedList.Helpers;

namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion7
{
  [Fact]
  public void ShouldReturnIntersection_WhenInputsAreValid()
  {
    var l1 = LinkedListHelpers.CreateLinkedList(1, 2, 6, 7);
    var intersection = LinkedListHelpers.CreateLinkedList(3, 6, 7);
    var l2 = LinkedListHelpers.CreateLinkedList(6, 9);
    
    AddIntersection(l1, l2, intersection);
    ValidateIntersection(l1, l2, intersection);
  }

  [Fact]
  public void ShouldReturnNull_WhenDontHasIntersection()
  {
    var l1 = LinkedListHelpers.CreateLinkedList(1, 2, 6, 7);
    var l2 = LinkedListHelpers.CreateLinkedList(6, 9);
    
    ValidateIntersection(l1, l2, null);
  }

  private void AddIntersection<T>(Node<T> l1, Node<T> l2, Node<T> intersection)
  {
    while (l1.Next != null)
    {
      l1 = l1.Next;
    }

    l1.Next = intersection;

    while (l2.Next != null)
    {
      l2 = l2.Next;
    }

    l2.Next = intersection;
  }

  private void ValidateIntersection<T>(Node<T> l1, Node<T> l2, Node<T>? intersection)
  {
    var result = Question7.GetIntersection(l1, l2);
    result.Should().BeSameAs(intersection);
  }
}
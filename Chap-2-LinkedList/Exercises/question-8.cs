namespace Code;

// 2.8 Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the beginning of the loop.
//     DEFINITION
//     Circular linked list: A(corrupt) linked list in which a node's next pointer points to an earlier node, so as to make a loop in the linked list.
//     EXAMPLE
//     Input:  A -> B -> C -> D -> E -> C[the same C as earlier]
//     Output: C

public static class Question8
{
  // Space: O(N)
  // Time: O(N)
  public static Node<T> FindLoopStart<T>(Node<T> head)
  {
    var slow = head;
    var fast = head;

    while (fast.Next != null) 
    {
      fast = fast.Next.Next;
      
      if (Object.ReferenceEquals(fast, slow)) return slow;

      slow = slow.Next;
    }

    return null;
  }
}
namespace Code;
// 2.2 Return kth to last: Implement an algorithm to find the kth to last element of a singly linked list
// note: From final to k, example list size - k >
public static class Question2
{
  // Space O(?)
  // Time O(?)
  public static Node ReturnKthToLast(Node head, int k)
  {
    if (head == null) throw new ArgumentNullException(nameof(head));
    if (k < 0) throw new ArgumentOutOfRangeException("K must be non-negative value");

    var result = head;

    for (var j = 0; j < k-1; j++)
    {
      head = head.Next;
      if (head == null) throw new ArgumentOutOfRangeException(nameof(k), "There must be at least k elements in the list");
    }

    while(head.Next != null)
    {
      head = head.Next;
      result = result.Next;
    }

    return result;
  }
}
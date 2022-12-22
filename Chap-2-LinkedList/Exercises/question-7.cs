using System.Reflection.Emit;
namespace Code;

// 2.7 Intersection: Given two (singly) linked lists, determine if the two lists intersect.  Return th eintersection node.  Node that the intersection is defined based on reference, not value.  
// That is if the kth node of the first linked list is exactly the same node (by reference) as the jth node of the second linked list, then they are intersecting.

public class Question7
{
  // Space O(N)
  // Time O(A+B)
  public static Node<T> GetIntersection<T>(Node<T> l1, Node<T> l2)
  {
    if (l1 is null) throw new ArgumentNullException(nameof(l1));
    if (l2 is null) throw new ArgumentNullException(nameof(l2));

    var l1Length = GetLength(l1);
    var l2Length = GetLength(l2);

    // equality the nodes length, the last node always quals before intersection
    if (l1Length > l2Length)
    {
      for (int i = 0; i < l1Length - l2Length; i++)
      {
        l1 = l1.Next;
      }
    }
    else if (l1Length < l2Length)
    {
      for (int i = 0; i < l2Length - l1Length; i++)
      {
        l2 = l2.Next;
      }
    }

    while(l1 != null)
    {
      if (Object.ReferenceEquals(l1, l2)) return l1;
      l1 = l1.Next;
      l2 = l2.Next;
    }

    return null;
  }


  private static int GetLength<T>(Node<T> head)
  {
    var tmp = head;
    var count = 0;

    while (head != null)
    {
      count++;
      head = head.Next;
    }

    return count;
  }


  // Space O(N)
  // Time O(AB2)
  public static Node<T> GetIntersectionBruteForce<T>(Node<T> l1, Node<T> l2)
  {
    if (l1 is null) throw new ArgumentNullException(nameof(l1));
    if (l2 is null) throw new ArgumentNullException(nameof(l2));

    var tmp = l2;

    while (l1 != null)
    {
      if (Object.ReferenceEquals(l1, l2))
      {
        return l1;
      }

      while (tmp != null)
      {
        if (Object.ReferenceEquals(l1, tmp))
        {
          return l1;
        }

        tmp = tmp.Next;
      }

      l1 = l1.Next;
      tmp = l2;
    }

    throw new ArgumentException(); // do stuff
  }
}
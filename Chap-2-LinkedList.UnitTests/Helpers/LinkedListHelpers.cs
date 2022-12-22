using System;
namespace Chap_2_LinkedList.Helpers;

public static class LinkedListHelpers 
{
  public static Node<T> CreateLinkedList<T>(params T[] values) where T : IEquatable<T>
  {
    if (values is null) throw new ArgumentNullException(nameof(values));


    var head = new Node<T>(values[0]);
    var cur = head;

    for (int i = 1; i < values.Length; i++)
    {
      var next = new Node<T>(values[i]);
      cur.Next = next;
      cur = cur.Next;
    }
    
    return head;
  }
}
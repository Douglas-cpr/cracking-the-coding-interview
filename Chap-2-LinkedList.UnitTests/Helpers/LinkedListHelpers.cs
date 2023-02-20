using System;
namespace Chap_2_LinkedList.Helpers;

public static class LinkedListHelpers 
{
  public static Node<T> CreateLinkedList<T>(params T[] values)
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

  public static Node<T> AddLoop<T>(Node<T> head, params T[] loop)
  {
    while (head.Next != null)
    {
      head = head.Next;
    }

    var loopStart = LinkedListHelpers.CreateLinkedList(loop);
    var loopEnd = loopStart;

    while (loopEnd.Next != null)
    {
      loopEnd = loopEnd.Next;
    }

    if (head != null)
    {
      head.Next = loopStart;
    }

    loopEnd.Next = loopStart;

    return loopStart;
  }
}
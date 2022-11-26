using System.Reflection.Metadata.Ecma335;
using System.IO.Pipes;
using System.Reflection.Emit;
using System.Diagnostics.Contracts;
namespace Code;

public static class Question1
{
  public static void RemoveDups(Node head)
  {
    if (head == null) throw new ArgumentNullException(nameof(head));
    if (head.Next == null) return;

    var hashSet = new HashSet<int>();

    hashSet.Add(head.Data);

    while(head.Next != null)
    {
      if (hashSet.Contains(head.Next.Data))
      {
        head.Next = head.Next.Next;
      }
      else
      {
        head = head.Next; 
        hashSet.Add(head.Data);
      }
    }
  }

  public static void RemoveDups_TwoPointers(Node head)
  {
    if (head == null) throw new ArgumentNullException(nameof(head));
    if (head.Next == null) return;

    var p2 = head.Next;

    while (p2 != null && p2.Next != null)
    {
      if (head.Data == p2.Data)
      {
        head.Next = p2.Next;
        p2.Next = p2.Next.Next;

        head = p2;
        p2 = p2.Next;
        continue;
      }

      head = head.Next;
      p2 = p2.Next;
    }
  }
}
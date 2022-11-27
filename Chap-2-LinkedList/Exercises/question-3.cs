namespace Code;
// 2.3 Delete Middle Node: Implement an algorithm to delete a node in the middle 
// (i.e., any node but the first and last node not, not necessarily the exact middle) of a singly linked list, given only
// access to that node
public static class Question3
{
    public static Node<string> DeleteMiddleNode(Node<string> head)
    { 
      if (head == null) throw new ArgumentNullException(nameof(head));
      if (head.Next == null || head.Next.Next == null) return head;
      head.Next = head.Next.Next;
      return head;
    }
}
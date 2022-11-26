namespace Code;

public class MyLinkedList
{
  public Node Head { get; set; }

  public MyLinkedList(Node node) 
  {
    Head = node;
  }

  public void AddLast(Node node)
  {
    if (Head.Next == null) 
    {
      Head.Next = node;
      return;
    }

    var head = Head;

    while(head.Next != null)
    {
      head = head.Next;
    }

    head.Next = node;
  }
}

public class Node 
{
  public Node Next = null;

  public int Data;

  public Node(int d)
  {
    Data = d;
  }

  public void AppendToTail(int d)
  {
    Node end =  new Node(d);
    Node n = this;
    while (n.Next != null) n = n.Next;
    n.Next = end;
  }

  public Node Delete(Node head, int d)
  {
    Node n = head;

    if (n.Data == d) return head.Next;

    while (n.Next != null)
    {
      if(n.Next.Data == d) 
      {
        n.Next = n.Next.Next;
        return head;
      }
      n = n.Next;
    }
    return head;
  }
}
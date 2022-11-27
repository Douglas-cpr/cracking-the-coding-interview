namespace Code;

public class Node : Node<int>
{
  public Node(int d) : base(d) { }
}

public class Node<T>
{
  public Node<T> Next = null;

  public T Data;

  public Node(T d)
  {
    Data = d;
  }

  public void AppendToTail(T d)
  {
    Node<T> end =  new Node<T>(d);
    Node<T> n = this;
    while (n.Next != null) n = n.Next;
    n.Next = end;
  }

  public Node<T> Delete(Node<T> head, T d)
  {
    Node<T> n = head;
    if (Equals(n.Data, d)) return head.Next;

    while (n.Next != null)
    {
      if(Equals(n.Next.Data, d)) 
      {
        n.Next = n.Next.Next;
        return head;
      }
      n = n.Next;
    }
    return head;
  }

  private bool Equals(T x, T y)
  {
    return EqualityComparer<T>.Default.Equals(x, y);
  }
}
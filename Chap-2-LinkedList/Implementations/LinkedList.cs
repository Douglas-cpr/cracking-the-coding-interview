namespace Code;

public class Node : Node<int>
{
  public Node(int d) : base(d) { }
}

public class Node<T>
{
  public Node<T> Next = null!;
  private int _length = 0;

  public T Data;

  public Node(T d)
  {
    Data = d;
    _length++;
  }

  public void AppendToTail(T d)
  {
    Node<T> end =  new Node<T>(d);
    Node<T> n = this;
    while (n.Next != null) n = n.Next;
    n.Next = end;
    _length++;
  }

  public Node<T>? Delete(Node<T> head, T d)
  {
    Node<T> n = head;
    if (Equals(n.Data, d)) return head.Next ?? null;

    while (n.Next != null)
    {
      if(Equals(n.Next.Data, d)) 
      {
        n.Next = n.Next.Next;
        _length--;
        return head;
      }
      n = n.Next;
    }

    _length--;
    return head;
  }

  private bool Equals(T x, T y)
  {
    return EqualityComparer<T>.Default.Equals(x, y);
  }

  public int GetLength()
  {
    return _length;
  }
}
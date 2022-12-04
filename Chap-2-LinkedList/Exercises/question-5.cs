namespace Code;

// 2.5. Sum Lists: You have two numbers represented by a linked list, where each node contains a single digit.The digits are stored in reverse order, such that the 1's digit is at the head of the list.  Write a function that adds the two numbers and returns the sum as a linked list.
//      EXAMPLE
//      Input: (7 -> 1 -> 6) + (5 -> 9 -> 2).  that is, 617 + 295.
//      Output: 2 -> 1 -> 9.  That is, 912.
//      FOLLOW UP
//      Suppose the digits are stored in forward order.Repeat the above problem.
//      EXAMPLE
//      Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).  That is 617 + 295.
//      Output: 9 -> 1 -> 2.  That is, 912.


public class Question5
{

  public class PartialSum
  {
    public Node<Digit> Sum { get; set; } = null!;
    public int Carry = 0;
  }

  public static Node<Digit> SumLists(Node<Digit> l1, Node<Digit> l2)
  {
    var len1 = l1.GetLength();
    var len2 = l2.GetLength();


    if (len1 < len2)
    {
      l1 = PadList(l1, len2 - len1);
    } 
    else
    {
      l2 = PadList(l2, len1 - len2);
    }

    var sum = SumListsHelper(l1, l2);

    if (sum.Carry == 0)
    {
      return sum.Sum;
    }
    
    var result = InsertBefore(sum.Sum, sum.Carry);
    return result;
  }

  private static PartialSum SumListsHelper(Node<Digit> l1, Node<Digit> l2)
  {
    if (l1 == null && l2 == null) return new PartialSum();
    
    var sum = SumListsHelper(l1.Next, l2.Next);
    var val = sum.Carry + l1.Data.Value + l2.Data.Value;
    
    var fullResult = InsertBefore(sum.Sum, val % 10);

    sum.Sum = fullResult;
    sum.Carry = val / 10;

    return sum;
  }

  private static Node<Digit> InsertBefore(Node<Digit> head, int data)
  {
    var digit = new Digit(data);
    var node = new Node<Digit>(digit);
    if (head != null)
    {
      node.Next = head;
    }
    return node;
  }

  private static Node<Digit> PadList(Node<Digit> head, int padding)
  {
    var node = head;
    for (var i = 0; i < padding; i++) node = InsertBefore(node, 0);
    return node;
  }
  public static Node<Digit>? SumListsReverse(Node<Digit>? l1, Node<Digit>? l2, int carryOver)
  {   
    if (l1 == null && l2 == null && carryOver == 0) return null;

    var val = carryOver;

    if (l1 != null) val += l1.Data.Value;
    if (l2 != null) val += l2.Data.Value;

    var result = new Node<Digit>(new Digit(val % 10));

    if (l1 != null || l2 != null)
    {
      var more = SumListsReverse(
        l1 == null ? null : l1.Next,
        l2 == null ? null : l2.Next,
        val >= 10 ? 1 : 0
      );

      while (more != null) 
      {
        result.AppendToTail(new Digit(more.Data.Value));
        more = more.Next;
      };
    }

    return result;
  }
  
}
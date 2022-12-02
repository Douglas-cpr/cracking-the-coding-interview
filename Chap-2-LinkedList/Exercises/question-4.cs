namespace Code;
// 2.4 Partition: Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x. 
// (IMPORTANT: The partition element x can appear anywhere in the “right partition”; it does not need to appear between the left and right partitions. The additional spacing the example below indicates the partition.)


// Note: other possible solution is create 3 LinkedList: 1 to smallest than pivot, 2 to equal pivot, 3 to largest than pivot
// then merge them

public static class Question4
{
    // Space O(N2)
    // Time O(N2)
    public static void Partition(Node<int> head, int partition)
    { 
      if (head.Next == null) return;

      while (head != null)
      {
        var pointer_aux = head.Next;

        while (pointer_aux != null)
        {
          if (pointer_aux.Data < partition && head.Data > pointer_aux.Data)
          {
            Swap(head, pointer_aux);
          }
          pointer_aux = pointer_aux.Next;
        }
        head = head.Next;
      }
    }

  private static void Swap(Node<int> node, Node<int> aux)
  {
    var temp = node.Data;
    var aux_temp = aux.Data;
    var node_temp = node;

    var search = true;

    while(node_temp != null && search)
    {
      if (node_temp.Data == aux_temp) 
      {
        node_temp.Data = temp;
        search = false;
      }
      node_temp = node_temp.Next;
    }
    node.Data = aux_temp;
  }


    // Space O(N)
    // Time O(N)
  public static void PartitionOptimized(Node<int> head, int partition)
  {
    var smallest = new Node<int>(-1);
    var largestOrEqual = new Node<int>(-1);
    var temp = head;

    while(temp != null)
    {
      if (temp.Data < partition)
      {
        smallest.AppendToTail(temp.Data);
      }
      else 
      {
        largestOrEqual.AppendToTail(temp.Data);
      }

      temp = temp.Next;
    }
    
    // not run with static creators
    smallest = smallest.Next;
    largestOrEqual = largestOrEqual.Next;

    while(head != null && largestOrEqual != null)
    {
      if (smallest != null)
      {
        head.Data = smallest.Data;
        smallest = smallest.Next;
      }
      else 
      {
        head.Data = largestOrEqual.Data;
        largestOrEqual = largestOrEqual.Next;
      }
      head = head.Next;
    }
  }

}
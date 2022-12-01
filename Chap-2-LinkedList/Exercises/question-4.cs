namespace Code;
// 2.4 Partition: Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes greater than or equal to x. 
// (IMPORTANT: The partition element x can appear anywhere in the “right partition”; it does not need to appear between the left and right partitions. The additional spacing the example below indicates the partition.)
public static class Question4
{
    public static void Partition(Node<int> head, int partition)
    { 
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

}
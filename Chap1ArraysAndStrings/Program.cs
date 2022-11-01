using System.Collections;
internal class Program
{
  private static void Main(string[] args)
  {

    var arr1 = new string[] { "a", "b", "c", "d", "e" };
    var arr2 = new string[] { "a", "b", "c", "d"};

    var merged = merge(arr1, arr2);

    Console.WriteLine(merged);

  }


  private static ArrayList merge(string[] a, string[] b)
  {
    var arrayList = new ArrayList();

    foreach(var str in a) arrayList.Add(str);
    foreach(var str in b) arrayList.Add(str);

    return arrayList;
  }
}


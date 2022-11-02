using Chap1.ArrayList;

internal class Program
{
  private static void Main(string[] args)
  {

    var arr1 = new string[] { "a", "b", "c", "d", "e" };
    var arr2 = new string[] { "a", "b", "c", "d"};

    var merged = merge(arr1, arr2);
  }


  private static MyArrayList merge(string[] a, string[] b)
  {
    var arrayList = new MyArrayList();

    foreach(var str in a) arrayList.Add(str);
    foreach(var str in b) arrayList.Add(str);

    arrayList.Remove("e");
    arrayList.RemoveAt(1);
    arrayList.Insert(0, 1);
    arrayList.Insert(6, 6);
    arrayList.Insert(7, 7);
    arrayList.Insert(8, 8);

    return arrayList;
  }
}


using Chap1.ArrayList;
using Chap1.HashTable;

internal class Program
{
  private static void Main(string[] args)
  {
    // ArrayList
    var merged = merge();

    // HashTable
    var hashTable = new MyHashTable<string, int>();
    hashTable.Add("a", 1);
    hashTable.Add("a", 2);
  }


  private static MyArrayList merge()
  {
    var a = new string[] { "a", "b", "c", "d", "e" };
    var b = new string[] { "a", "b", "c", "d"};

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


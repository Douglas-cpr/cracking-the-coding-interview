namespace Code;

// 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.


public static class Question2
{
  
  // Space O(?)
  // Time O(?)
  public static bool CheckPermutation2(string value1, string value2)
  {
    var v1Size = value1.Length;
    var v2Size = value2.Length;

    if (v1Size != v2Size) return false;

    var char1 = value1.ToCharArray();
    var char2 = value2.ToCharArray();

    Array.Sort(char1);
    Array.Sort(char2);

    for(var i = 0; i < char1.Length; i++)
    {
      if (char1[i] != char2[i]) return false;
    }

    return true;
  }

  // Space O(?)
  // Time O(?)
  public static bool CheckPermutation1(string value1, string value2)
  {
    var NO_OF_CHARS = 256;

    var v1 = value1.ToCharArray();
    var v2 = value2.ToCharArray();
    var count1 = new int[NO_OF_CHARS];
    var count2 = new int[NO_OF_CHARS];

    if (v1.Length != v2.Length) return false;

    for (var i = 0; i < v1.Length && i < v2.Length; i++)
    { 
      count1[v1[i]]++;
      count2[v2[i]]++;
    }
 
    for (var i = 0; i < NO_OF_CHARS; i++) 
    {
        if (count1[i] != count2[i]) return false;
    }

    return true;
  }
}
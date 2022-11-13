namespace Code;

// 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters.  What if you cannot use additional data structures?

public static class Question1
{
  
  // Space O(N)
  // Time O(N)
  public static bool IsUnique(string value) 
  {
    if (string.IsNullOrEmpty(value)) return true;

    var charArray = value.ToCharArray();
    var passed = new List<char>();

    for (var i = 0; i < charArray.Length; i++)
    {
      var c = charArray[i];

      if (passed.Any(p => p.Equals(c)))
      {
        return false;
      }
      passed.Add(c);
    }
    return true;
  }
}
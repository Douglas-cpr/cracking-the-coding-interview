namespace Code;

// 1.5 One Away: There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character.  Given two strings, write a function to check if they are one dit (or zero edits) away.
//     EXAMPLE
//     pale, ple -> true
//     pales, pale -> true
//     pale, bale -> true
//     pale, bake -> false

public static class Question5 
{

  // Space O(?)
  // Time O(?)
  public static bool OneWay(string originalValue, string modifiedValue)
  {
    var originalValueCharArr = originalValue.ToCharArray();
    var modifiedValueCharArr = modifiedValue.ToCharArray();

    var diffLength = Math.Abs(originalValue.Length - modifiedValue.Length);
    if (diffLength > 1) return false;
    
    var diffCount = 0;

    var minSize = Math.Min(originalValue.Length, modifiedValue.Length);

    for (var i = 0; i < minSize; i++)
    {
      if (originalValueCharArr[i] != modifiedValueCharArr[i]) diffCount++;
      if (diffCount > 1) return false;
    };

    return true;
  }
}
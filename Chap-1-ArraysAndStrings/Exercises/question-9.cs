using System.Reflection;
using System.Text;

namespace Code;

// 1.9  String Rotation: Assume you have a method isSubstring which checks if one word is a substring of another. Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring (e.g.,"waterbottle" is a rotation of "erbottlewat").

// Space: O(N)
// Time: O(N)



public static class Question9
{
  public static bool StringRotationOptimized(string s1, string s2)
  {
    if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) throw new ArgumentNullException("Input cannot be null or empty");
    if (s1.Length != s2.Length) return false;

    var  concBuilder = new StringBuilder();
    concBuilder.Append(s1);
    concBuilder.Append(s1);
    return concBuilder.ToString().Contains(s2);
  }

  public static bool StringRotation(string s1, string s2)
  {
    if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) throw new ArgumentNullException("Input cannot be null or empty");
    if (s1.Length != s2.Length) return false;
    var midLength = Math.Abs(s1.Length / 2);
    var init = s1.Substring(0, midLength);
    var final = s1.Substring(midLength);
    var str = FindSubstring(init, final, midLength, s2);
    if (str == s1) return true;
    return false;
  }

  private static string FindSubstring(string init, string final, int point, string toFind)
  {
    var initIdx = toFind.IndexOf(init);
    var endIdx = toFind.IndexOf(final);

    if (initIdx > -1 && endIdx > -1) 
    {
      var result = toFind.Substring(initIdx) + toFind.Substring(0, initIdx);
      return result;
    }
    if (point > toFind.Length) return "";

    if (endIdx > -1)
    {
      var newInit = init.Substring(0, point - 1);
      return FindSubstring(newInit, final, point-1, toFind);
    }

    if (point == 1)
    {
      return FindSubstring(init.Substring(0, point), final.Substring(point + 1), point+1, toFind);
    }

    return FindSubstring(init.Substring(0, point - 1), final.Substring(point + 1), point+1, toFind);
  }
}
using System.Collections;
using System.Text;

namespace Code;

// 1.6 String Compression: Implement a method to perform basic string compression using the counts of repeated characters.  For example, the string aabcccccaaa would become a2b1c5a3.  If the "compressed" string would not become smaller than the original string, your method should return the original string.

public static class Question6
{

  // Space O(?)
  // Time O(?)
  public static string StringCompression(string value)
  {
    var arrayList = new ArrayList();
    var chars = value.ToLower().ToArray();

    var str = new StringBuilder();

    int count = 0;

    for (var i = 0; i < chars.Length; i++)
    {
      count++;
      if (i == chars.Length - 1 || chars[i] != chars[i+1])
      { 
        var res = chars[i].ToString() + count.ToString();
        arrayList.Add(res);
        count = 0;
      }
    }

    var result = new StringBuilder();

    foreach(var item in arrayList)
    {
      result.Append(item);
    }

    return result.ToString();
  }
}
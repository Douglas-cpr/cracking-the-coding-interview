using System.Text;

namespace Code;

// 1.3 URLify: Write a method to replace all spaces in a string with '%20'.  You may assume that the string has sufficient space at the end of the string to hold the additional characters, and that you are given the "true" length of the string. (Note: if implementing in java, please use a character array so that you can perform this operation in place.)
// EXAMPLE
// Input:  "Mr John Smith    "
// Output: "Mr%20John%20Smith"

public static class Question3
{
  // Space O(N)
  // Time O(N)
  public static string Urlify(string url, int trueUrlLength)
  {
    if (string.IsNullOrWhiteSpace(url)) throw new ArgumentNullException("url cannot be null or empty");

    if (url.Length != trueUrlLength) throw new ArgumentException("Size of url must be " + trueUrlLength);

    var urlChars = url.ToCharArray();
    var result = new StringBuilder();


    for (var i = 0; i < urlChars.Length; i++) 
    {
      if (Char.IsWhiteSpace(urlChars[i]))
      {
        result.Append("%20");
      }
      else
      {
        result.Append(urlChars[i]);
      }
    } 

    return result.ToString();
  }
}
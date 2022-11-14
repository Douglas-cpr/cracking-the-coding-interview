namespace Code;

// 1.4 Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.  A palindrome is a word or phrase that is the same forwards and backwards.A permutation is a rearrangement of letters.The palindrome does not need to be limited to just dictionary words.
//     EXAMPLE
//     Input: Tact Coa
//     Output: True (permutations: "taco cat", "atco cta", etc.)

public class Question4
{

  // Space O(?)
  // Time O(?)
  public static bool PalindromePermutation(string value)
  {
    if (string.IsNullOrWhiteSpace(value) || value.Length == 1) return false;

    var sanitizedValue = value.Replace(" ", "").ToLowerInvariant();
    var chars = sanitizedValue.ToCharArray();
    var mapping = new int[256];

    foreach(var c in chars)
    {
      var idx = (int)c;

      if (mapping[idx] == 0)
      {
        mapping[idx] = 1;
      }
      else 
      {
        mapping[idx] = 0;
      }
    }

    var res = HasMoreOneOddValue(mapping);

    return !res;
  }

  // Space O(?)
  // Time O(?)
  private static bool HasMoreOneOddValue(int[] mapping)
  {
    var oddCounter = 0;

    foreach(var val in mapping)
    {
      if (oddCounter > 1)
      {
        return true;
      }

      if ((int)val == 1) 
      {
        oddCounter++;
      };
    }
    return false;
  }
}
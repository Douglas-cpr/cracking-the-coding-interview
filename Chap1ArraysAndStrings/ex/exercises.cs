using System.Text;

public class Exercices 
{
  public void Main()
  {
    var uniqueWithoutDataStructuresParam = "Ta doidao cachoeira";
    UniqueWithoutDataStructures(uniqueWithoutDataStructuresParam);


    var permutationParam1 = "aabb";
    var permutationParam2 = "abba";

    CheckPermutationO2(permutationParam1, permutationParam2);
    CheckPermutationON(permutationParam1, permutationParam2);


    Urlify("Mr John Smith", 13);
  }

  public bool UniqueWithoutDataStructures(string value) 
  {
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

  public bool CheckPermutationO2(string value1, string value2)
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

  public bool CheckPermutationON(string value1, string value2)
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

  public string Urlify(string url, int trueUrlLength)
  {
    var urlChars = url.ToCharArray();
    var result = new StringBuilder();

    if (urlChars.Length != trueUrlLength) throw new ArgumentException("Size of url must be " + trueUrlLength);

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


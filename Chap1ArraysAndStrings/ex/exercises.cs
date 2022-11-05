
public class Exercices 
{
  public void Main()
  {
    var value = "Ta doidao cachoeira";
    
    var result = UniqueWithoutDataStructures(value);
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

}


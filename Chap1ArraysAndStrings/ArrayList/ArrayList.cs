namespace Chap1.ArrayList;

public class ArrayList
{
  private int _length = 2;
  public string[] data;

  public ArrayList() 
  {
    data = new string[_length];
  }

  public void Add(string value) 
  {
    data.Append(value);

    if (data.Length == _length) 
    {
      _length = _length * 2;
      Array.Resize(ref data, _length);
    }
  }
}
public interface IStringBuilder 
{ 
  void Append(string value);
  string ToString();
  void Clear();
}

public class MyStringBuilder : IStringBuilder
{
  public int Capacity { get; private set; } 
  public int Length { get; private set; }

  private const int defaultCapacity = 32;
  private char[] _internalBuffer;

  public MyStringBuilder(int capacity)
  {
    Capacity = capacity;
    _internalBuffer = new char[capacity];
    Length = 0;
  }

  public MyStringBuilder() : this(defaultCapacity) { }

  public void Append(string value)
  {
    var charArr = value.ToCharArray();
    ExpandCapacityIfNecessary(charArr.Length);
    foreach (var c in charArr)
    {
      _internalBuffer[Length] = c;
      Length++;
    }
  }

  public override string ToString()
  {
    return _internalBuffer.ToString() ?? string.Empty;
  }

  public void Clear()
  {
    _internalBuffer = new char[Capacity];
    Length = 0;
  }

  private void ExpandCapacityIfNecessary(int capacityToAdd)
  {
    var newLength = capacityToAdd + Length;
    if (newLength <= Capacity) return;
    ExpandCapacity();
  }

  private void ExpandCapacity()
  {
    Capacity += 2;

    var temp = new char[Capacity];

    for(var i = 0; i < _internalBuffer.Length; i++)
    {
      temp[i] = _internalBuffer[i];
    }

    _internalBuffer = temp;
  }
}
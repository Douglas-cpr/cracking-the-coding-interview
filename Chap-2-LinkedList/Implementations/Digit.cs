namespace Code;
public class Digit
{

  public int Value { get { return _digit; }}
  private readonly int _digit;

  public Digit(int digit)
  {
    if (digit < 0 || digit > 9) throw new ArgumentOutOfRangeException("Digit should be between 0 and 9");
    _digit = digit;
  }

  public bool Equals(Digit digit)
  {
    return _digit == digit.Value;
  }
}
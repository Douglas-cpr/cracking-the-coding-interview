namespace Chap_2_LinkedList.UnitTests;

public class TestQuestion5
{
  private Node<Digit> BuildNodesToTest(List<int> values)
  {
    var nodes = new Node<Digit>(new Digit(values[0]));
    for(var i = 1; i < values.Count; i++) nodes.AppendToTail(new Digit(values[i]));
    return nodes;
  }

  [Fact]
  public void ShouldReturnAnSumByListsInt_WhenInputListWithForwardOrder()
  {
    var digitsList_1 = BuildNodesToTest(new() { 6, 1, 7 });
    var digitsList_2 = BuildNodesToTest(new() { 2, 9, 5 });

    var result = Question5.SumLists(digitsList_1, digitsList_2);
    var expectedResult = BuildNodesToTest(new() { 9, 1, 2 });

    result.Should().NotBeNull();

    while (expectedResult != null && result is not null)
    {
      result.Data.Value.Should().Be(expectedResult.Data.Value);

      expectedResult = expectedResult.Next;
      result = result.Next;
    }
  }

  [Fact]
  public void ShouldReturnAnSumByListsInt_WhenInputListWithReverseOrder()
  {
    var digitsList_1 = BuildNodesToTest(new() { 7, 1, 6 });
    var digitsList_2 = BuildNodesToTest(new() { 5, 9, 2 });

    var result = Question5.SumListsReverse(digitsList_1, digitsList_2, 0);

    var expectedResult = BuildNodesToTest(new() { 2, 1, 9 });
    
    result.Should().NotBeNull();

    while (expectedResult != null && result is not null)
    {
      result.Data.Value.Should().Be(expectedResult.Data.Value);

      expectedResult = expectedResult.Next;
      result = result.Next;
    }
  }
}
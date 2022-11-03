using System.Runtime.CompilerServices;
namespace Chap1.HashTable;


public class MyHashTable<TKey, TValue>
{
  private LinkedList<Tuple<TKey, TValue>>[] _items;
  private int _hashTableSize;
  private int _maxCapacity = 1;

  public MyHashTable()
  {
    _items = new LinkedList<Tuple<TKey, TValue>>[2];
  }

  public void Add(TKey key, TValue value)
  {
    if (key == null) throw new ArgumentNullException("Key cannot be null");

    var position = GetPosition(key, _items.Length);

    if (position == -1)
    {
      _items[position] = new LinkedList<Tuple<TKey, TValue>>();
    }

    _hashTableSize++;

    GrowAndReHashIfNecessary();

    position = GetPosition(key, _items.Length);

    if (_items[position] == null)
    {
      _items[position] = new LinkedList<Tuple<TKey, TValue>>();
    }

    _items[position].AddLast(new Tuple<TKey, TValue>(key, value));
  }

  private void GrowAndReHashIfNecessary()
  {
    if (!NeedGrow()) { return; }
    _maxCapacity *= 2;
    var newItems = new LinkedList<Tuple<TKey, TValue>>[_items.Length * 2];
    foreach (var item in _items.Where(x => x != null))
    {
      foreach (var value in item)
      {
        var pos = GetPosition(value.Item1, newItems.Length);
        if (newItems[pos] == null) newItems[pos] = new LinkedList<Tuple<TKey, TValue>>();
        newItems[pos].AddFirst(new Tuple<TKey, TValue>(value.Item1, value.Item2));
      }
    }
    _items = newItems;
  }

  private bool NeedGrow()
  {
    return _hashTableSize >= _maxCapacity;
  }

  private int GetPosition(TKey key, int length)
  {
    var hash = key.GetHashCode();
    var position = Math.Abs(hash % length);
    return position;
  }

  public void Remove(TKey key)
  {
    var position = GetPosition(key, _items.Length);
    if (_items[position] == null) throw new Exception("Value not in HashTable.");
    var tuplesToRemove = _items[position].Where(item => item.Item1.Equals(key));
    if (tuplesToRemove == null) return;
    foreach (var tuple in tuplesToRemove)
    {
      _items[position].Remove(tuple);
      _hashTableSize--;
    }
  }

  public TValue Get(TKey key)
  {
    var pos = GetPosition(key, _items.Length);
    foreach (var item in _items[pos].Where(item => item.Item1.Equals(key)))
    {
      return item.Item2;
    }
    throw new Exception("Key does not exist in HashTable.");
  }

}

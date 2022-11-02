using System.Collections;

namespace Chap1.ArrayList;

public class MyArrayList : IList
{
  private object[] _items;


  public MyArrayList() 
  {
    _items = new object[1];
  }

  public object? this[int index]
  {
    get 
    {
      return _items[index];
    }  
    set
    {
      if (value != null) _items[index] = value;
    }
  }

  public bool IsFixedSize => false;

  public int Count => _items.Length;

  public int Add(object? value)
  {
    var size = _items.Length;
    IncreaseArraySize();
    _items[size - 1] = value;
    return size - 1;
  }

  private void IncreaseArraySize()
  {
    object[] tmp = new object[_items.Length + 1];
    for(int i = 0; i < _items.Length; i++) {
        tmp[i] = _items[i];
    }
    _items = tmp;
  } 

  public void Clear()
  {
    _items = new object[0];
  }

  public bool Contains(object? value)
  {
    return IndexOf(value) != -1;
  }

  public void CopyTo(Array array, int index)
  {
    if (index < 0) throw new IndexOutOfRangeException();
    for (var i = index; i < _items.Length; i++) 
    {
      array.SetValue(_items[i], i);
    }
  }

  public int IndexOf(object? value)
  {
    for(var i = 0; i < _items.Length; i++)
    {
      if (_items[i].Equals(value)) return i;
    }
    return -1;
  }

  public void Insert(int index, object? value)
  {
    if (index < 1 && index > _items.Length+1) throw new IndexOutOfRangeException();
    if (index >= _items.Length) 
    {
      Add(value);
      return;
    }
    _items[index] = value;
  }

  public void Remove(object? value)
  {
    var index = IndexOf(value);
    if (index == -1) return;
    RemoveAt(index);
  }

  public void RemoveAt(int index)
  {
    var temp = new object[_items.Length - 1];
    for(int i = 0, j = 0; i < temp.Length; i++, j++)
    {
      if (i == index) j++;
      temp[i] = _items[j];
    }
    _items = temp;
  }

  public IEnumerator GetEnumerator()
  {
    throw new NotImplementedException();
  }

  public bool IsReadOnly => throw new NotImplementedException();

  public bool IsSynchronized => throw new NotImplementedException();

  public object SyncRoot => throw new NotImplementedException(); 
}
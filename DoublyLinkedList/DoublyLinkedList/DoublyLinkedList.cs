using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
  public class DoublyLinkedList<T>
  {
    private class Node
    {
      public Node Next;
      public Node Prev;
      public T Data;
    }

    private Node _topElement;

    /// <summary>
    /// Adds a new Value at the end of the list
    /// </summary>
    /// <param name="value"></param>
    public void Add(T value)
    {
      if (_topElement == null)
      {
        _topElement = new Node()
        {
          Data = value
        };
      }
      else
      {
        Node last = GetLast();

        last.Next = new Node()
        {
          Data = value,
          Prev = last
        };
      }
    }

    private Node GetLast()
    {
      Node current = _topElement;
      while (current.Next != null)
        current = current.Next;

      return current;
    }

    /// <summary>
    /// Checks if the given value is included in the list
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Exists(T value)
    {
      for (Node current = _topElement; current != null; current = current.Next)
      {
        if (current.Data.Equals(value))
          return true;
      }
      return false;
    }

    /// <summary>
    /// Returns the lenght of the list
    /// </summary>
    /// <returns></returns>
    public int Length()
    {
      int length = 0;
      for (Node current = _topElement; current != null; current = current.Next)
      {
        length++;
      }
      return length;
    }

    /// <summary>
    /// Returns the Value of the Index in the list
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public T Get(int index)
    {
      if (index < 0)
        throw new ArgumentException("The index is not in the list");

      Node current = _topElement;
      for (int i = 0; i < index && current != null; i++)
      {
        current = current.Next;
      }

      if (current == null)
        throw new ArgumentException("The index is not in the list");

      return current.Data;
    }

    /// <summary>
    /// Removes the given value from the list
    /// </summary>
    /// <param name="value"></param>
    public void Remove(T value)
    {
      for (Node current = _topElement; current != null; current = current.Next)
      {
        if (_topElement.Data.Equals(value))
        {
          _topElement = current.Next;
        }
        else if (current.Next != null && current.Next.Data.Equals(value))
        {
          current.Next = current.Next.Next;
        }
        if (current.Prev != null && current.Prev.Data.Equals(value))
        {
          current.Prev = current.Prev.Prev;
        }

      }
    }

    /// <summary>
    /// Relace the value at the position of the index with the given value
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    public void Replace(int index, T value)
    {
      Node nodetoAd = new Node
      {
        Data = value
      };

      int i = 0;
      for (Node current = _topElement; current != null; current = current.Next)
      {
        if (index == i && i == 0)
        {
          nodetoAd.Next = current.Next;
          nodetoAd.Next.Prev = nodetoAd;
          _topElement = nodetoAd;
        }
        else if (index == i)
        {
          nodetoAd.Next = current.Next;
          nodetoAd.Next.Prev = nodetoAd;
          nodetoAd.Prev = current.Prev;
          current.Prev.Next = nodetoAd;
        }
        i++;
      }
    }

    /// <summary>
    /// Insert a value into the list
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    public void Insert(int index, T value)
    {
      Node nodetoAd = new Node
      {
        Data = value
      };

      int i = 0;
      for (Node current = _topElement; current != null; current = current.Next)
      {
        if (index == i && i == 0)
        {
          nodetoAd.Next = current;
          nodetoAd.Next.Prev = nodetoAd;
          _topElement = nodetoAd;
        }
        else if (index == i)
        {
          nodetoAd.Next = current;
          nodetoAd.Prev = current.Prev;
          nodetoAd.Next.Prev = nodetoAd;
          nodetoAd.Prev.Next = nodetoAd;
          current = nodetoAd;
        }
        i++;
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoubleLinkedList;
namespace Test
{
  class Test
  {
    [TestFixture]
    class Test1
    {
      /// <summary>
      /// Check if the given values are added at the end of the list
      /// </summary>
      [Test]
      public void TestAdd()
      {
        // Given 
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        // When /Then
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(2));
        Assert.That(list.Length(), Is.EqualTo(2));
      }
      [Test]
      public void TestAddString()
      {
        // Given 
        DoublyLinkedList<string> listString = new DoublyLinkedList<string>();
        listString.Add("1");
        listString.Add("2");
        // When /Then
        Assert.That(listString.Get(0), Is.EqualTo("1"));
        Assert.That(listString.Get(1), Is.EqualTo("2"));
        Assert.That(listString.Length(), Is.EqualTo(2));
      }

      /// <summary>
      /// Check if the given Values exists
      /// </summary>
      [Test]
      public void TestExists()
      {
        // Given 
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        // When /Then
        Assert.That(list.Exists(1), Is.EqualTo(true));
        Assert.That(list.Exists(2), Is.EqualTo(true));
        Assert.That(list.Exists(5), Is.EqualTo(false));
      }
      /// <summary>
      /// Check if the given Values exists
      /// </summary>
      [Test]
      public void TestExistsString()
      {
        // Given 
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        // When /Then
        Assert.That(list.Exists(1), Is.EqualTo(true));
        Assert.That(list.Exists(2), Is.EqualTo(true));
        Assert.That(list.Exists(5), Is.EqualTo(false));
      }

      // <summary>
      /// Check if the arrays length is equal to the given length
      /// </summary>
      [Test]
      public void TestLength()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        // When /Then
        Assert.That(list.Length(), Is.EqualTo(2));
      }

      // <summary>
      /// Check if the arrays length is equal to the given length
      /// </summary>
      [Test]
      public void TestLengthString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        // When /Then
        Assert.That(list.Length(), Is.EqualTo(2));
      }

      /// <summary>
      /// Check if the get function returns the correct values from the list
      /// </summary>
      [Test]
      public void TestGet()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        // When /Then
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(2));
        Assert.That(() => list.Get(-1), Throws.ArgumentException);
        Assert.That(() => list.Get(2), Throws.ArgumentException);
      }

      /// <summary>
      /// Check if the get function returns the correct values from the list
      /// </summary>
      [Test]
      public void TestGetString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        // When /Then
        Assert.That(list.Get(0), Is.EqualTo("1"));
        Assert.That(list.Get(1), Is.EqualTo("2"));
        Assert.That(() => list.Get(-1), Throws.ArgumentException);
        Assert.That(() => list.Get(2), Throws.ArgumentException);
      }

      /// <summary>
      /// Check if the given Value at the beginning is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtBeginning()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        // When
        list.Remove(1);
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo(2));
        Assert.That(list.Get(1), Is.EqualTo(3));
      }

      /// <summary>
      /// Check if the given Value at the beginning is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtBeginningString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        list.Add("3");
        // When
        list.Remove("1");
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo("2"));
        Assert.That(list.Get(1), Is.EqualTo("3"));
      }

      /// <summary>
      /// Check if the given Value in the middle is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtMiddle()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        // When
        list.Remove(2);
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(3));
      }

      /// <summary>
      /// Check if the given Value in the middle is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtMiddleString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        list.Add("3");
        // When
        list.Remove("2");
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo("1"));
        Assert.That(list.Get(1), Is.EqualTo("3"));
      }

      /// <summary>
      /// Check if the given Value at the end is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtEnd()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        // When
        list.Remove(3);
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo(1));
        Assert.That(list.Get(1), Is.EqualTo(2));
      }

      /// <summary>
      /// Check if the given Value at the end is removed from the list
      /// </summary>
      [Test]
      public void TestRemoveAtEndString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        list.Add("3");
        // When
        list.Remove("3");
        // Then
        Assert.That(list.Length(), Is.EqualTo(2));
        Assert.That(list.Get(0), Is.EqualTo("1"));
        Assert.That(list.Get(1), Is.EqualTo("2"));
      }

      [Test]
      public void TestReplace()
      {
        //Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //When
        list.Replace(index: 0, value: 4);
        list.Replace(index: 1, value: 5);
        //Then
        Assert.That(list.Get(0), Is.EqualTo(4));
        Assert.That(list.Get(1), Is.EqualTo(5));
        Assert.That(list.Get(2), Is.EqualTo(3));
      }

      [Test]
      public void TestReplaceString()
      {
        //Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        list.Add("3");
        //When
        list.Replace(index: 0, value: "4");
        list.Replace(index: 1, value: "5");
        //Then
        Assert.That(list.Get(0), Is.EqualTo("4"));
        Assert.That(list.Get(1), Is.EqualTo("5"));
        Assert.That(list.Get(2), Is.EqualTo("3"));
      }

      [Test]
      public void TestInsert()
      {
        // Given
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        // When
        list.Insert(index: 0, value: 5);
        list.Insert(index: 2, value: 4);
        // Then
        Assert.That(list.Length(), Is.EqualTo(5));
        Assert.That(list.Get(0), Is.EqualTo(5));
        Assert.That(list.Get(1), Is.EqualTo(1));
        Assert.That(list.Get(2), Is.EqualTo(4));
        Assert.That(list.Get(3), Is.EqualTo(2));
        Assert.That(list.Get(4), Is.EqualTo(3));
      }

      [Test]
      public void TestInsertString()
      {
        // Given
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        list.Add("1");
        list.Add("2");
        list.Add("3");
        // When
        list.Insert(index: 0, value: "5");
        list.Insert(index: 2, value: "4");
        // Then
        Assert.That(list.Length(), Is.EqualTo(5));
        Assert.That(list.Get(0), Is.EqualTo("5"));
        Assert.That(list.Get(1), Is.EqualTo("1"));
        Assert.That(list.Get(2), Is.EqualTo("4"));
        Assert.That(list.Get(3), Is.EqualTo("2"));
        Assert.That(list.Get(4), Is.EqualTo("3"));
      }
    }
  }
}

using System;
using System.Collections;

namespace claudiacarvalhoc.elvisp.projects.interview_exercices.lru_cache
{
  public class DNode
  {
    public DNode Next { get; set; }
    public DNode Previous { get; set; }
    public int Key { get; set; }
    public int Value { get; set; }

    public LRUCacheImpl()
    {
      this.Key = -1;
      this.Value = -1;
    }

    public LRUCacheImpl(int key, int value)
    {
      this.Key = key;
      this.Value = value;
    }
  }

  public class LRUCacheImpl
  {
    private int Total;
    private int Size = 0;
    private DNode Start;
    private DNode End;
    private Dictionary<int, int> Items;

    public LRUCacheImpl(int size = 5)
    {
      // Initialize 
      this.Size = 0;
      this.Start = new DNode();
      this.End = new DNode();

      // This references are always the same
      Start.Previous = End;
      End.Next = Start;

      // This references will change while items are inserted
      Start.Next = End;
      End.Previous = Start;

      // Set the size and dictionary limit items
      this.Total = size;
      this.Items = new Dictionary<int, int>(size);
    }

    public int get(int key)
    {
      DNode result;
      if (!this.Items.TryGetValue(key, out result))
      {
        value = new DNode();
      }
      return result.Value;
    }

    public void put(int key, int value)
    {
      DNode nextSecondElement = this.Start.Next;
      DNode newFirstElement;

      if (!this.Items.TryGetValue(key, out newFirstElement))
      {
        newFirstElement = new DNode(key, value);

        if (this.IsFull())
        {
          this.RemoveNode(this.End.Previous);
        }

        this.Size++;
      }
      else
      {
        this.RemoveNode(newFirstElement);
        newFirstElement.Value = value;
      }

      this.InsertNode(newFirstElement);
    }

    private bool IsFull()
    {
      return this.Size + 1 == this.Total;
    }

    private void RemoveNode(DNode node)
    {
      DNode previousElement = node.Previous;
      DNode nextElement = node.Next;

      // remove references
      node.Previous = node.Next = null;

      // point previous and next element to each one
      previousElement.Next = nextElement;
      nextElement.Previous = previousElement;
    }

    private void InsertNode(DNode node)
    {
      DNode secondElement = this.Start.Next;

      // set the first element on the list
      this.Start.Next = node;
      node.Previous = this.Start;

      // set the old first element as second
      node.Next = secondElement;
      secondElement.Previous = node;
    }
  }
}
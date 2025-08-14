using System.Collections;
using System.Globalization;

public class DoublyNode<T> 
{
    public T Value { get; set; }
    public DoublyNode<T>? Next { get; set; }
    public DoublyNode<T>? Prev { get; set; }

    public DoublyNode(T value)
    {
        Value = value;
        Next = null;
        Prev = null;
    }
}

public class DoublyLinkedList<T> : IEnumerable<T> where T : IComparable
{
    public DoublyNode<T>? Head { get; private set; }
    public DoublyNode<T>? Tail { get; private set; }
    private int count;

    public int Count
    {
        get { return count; }
        set { count = value; }
    }


    public void AddFirst(T value)
    {
        DoublyNode<T> newNode = new DoublyNode<T>(value);

        if (Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }

        Count++;
    }

    public void AddLast(T value)
    {
        DoublyNode<T>? newNode = new DoublyNode<T>(value);
        if (Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail!.Next = newNode;
            Tail = newNode;
        }

        Count++;
    }

    public void AddBefore(DoublyNode<T>? node, T value)
    {
        if (Head == null) throw new ArgumentException("There is no node");

        DoublyNode<T> newNode = new(value);

        newNode.Next = node;
        newNode.Prev = node!.Prev;

        if (node.Prev != null)
        {
            node.Prev.Next = newNode;
        }
        else
        {
            Head = newNode;
        }

        node.Prev = newNode;

        Count++;
    }

    public void AddAfter(DoublyNode<T>? node, T value)
    {
        if (Head == null) throw new ArgumentException("There is no node");

        DoublyNode<T> newNode = new(value);

        newNode.Prev = node;
        newNode.Next = node!.Next;

        if (node.Next != null)
        {
            node.Next.Prev = newNode;
        }
        else
        {
            Tail = newNode;
        }

        node.Next = newNode;

        Count++;
    }

    public void RemoveFirst()
    {
        if (Head == null) throw new ArgumentException("There is nothing to delete");
        if (Head.Next == null)
        {
            Head = Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Prev = null;
        }

        Count--;
    }

    public void RemoveLast()
    {
        if (Tail == null) throw new ArgumentException("There is nothing to delete");
        if (Tail.Prev == null)
        {
            Head = Tail = null;
        }
        else
        {
            Tail = Tail.Prev;
            Tail.Next = null;
        }

        Count--;
    }

    public void PrintForward()
    {
        if (Head == null) throw new ArgumentException("Thre is no node to print");
        DoublyNode<T>? curr = Head;

        while (curr != null)
        {
            Console.Write($"{curr.Value} -> ");
            curr = curr.Next;
        }

        Console.Write("null");
    }
    
    public void PrintBackward()
    {
        if (Tail == null) throw new ArgumentException("Thre is no node to print");
        DoublyNode<T>? curr = Tail;

        while (curr != null)
        {
            Console.Write($"{curr.Value} -> ");
            curr = curr.Prev;
        }

        Console.Write("null");
    }

    public bool Find(T value)
    {
        if (Tail == null) throw new ArgumentException("Thre is no node to find");

        DoublyNode<T>? curr = Head;

        while (curr != null)
        {
            if (curr.Value.CompareTo(value) == 0)
                return true;

            curr = curr.Next;
        }

        return false;
    }

    public DoublyNode<T> FindNode(T value)
    {
        if (Tail == null) throw new ArgumentException("Thre is no node to find");

        DoublyNode<T>? curr = Head;

        while (curr != null)
        {
            if (curr.Value.CompareTo(value) == 0)
                return curr;

            curr = curr.Next;
        }

        return null!;
    }

    public int GetCount()
    {
        return Count;
    }

    public bool isEmpty()
    {
        if (Head == null) return true;

        return false;
    }

    public void Clear()
    {
        DoublyNode<T>? current = Head;

        while (current != null)
        {
            DoublyNode<T>? next = current.Next;
            current.Prev = null;
            current.Next = null;
            current = next;
        }

        Head = null;
        Tail = null;
        Count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        DoublyNode<T> curr = Head!;
        while (curr != null)
        {
            yield return curr.Value;
            curr = curr.Next!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
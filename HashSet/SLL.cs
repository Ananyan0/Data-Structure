using System.Net.Quic;

class Node<T> where T : IComparable<T>
{
    private T? _value;
    private Node<T>? next;

    public Node(T? value)
    {
        _value = value;
        next = null;
    }

    public Node<T>? Next
    {
        get { return next; }
        set
        {
            next = value;
        }
    }
    public T? Value
    {
        get { return _value; }
        set
        {
            _value = value;
        }
    }

}

class SingleLinkedList<T> where T : IComparable<T>
{
    private Node<T>? head { get; set; }

    public Node<T>? Head
    {
        get { return head; }
        set
        {
            head = value;
        }
    }


    public void Push_Back(T? value)
    {
        if (head == null)
        {
            head = new Node<T>(value);
            return;
        }

        Node<T>? current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = new Node<T>(value);
    }

    public void Push_Front(T? value)
    {
        Node<T>? newNode = new Node<T>(value);
        newNode.Next = head;

        head = newNode;
    }

    public void Pop_Front()
    {
        if (head == null) return;
        head = head.Next;
    }

    public void Pop_Back()
    {
        if (head == null)
            return;

        if (head.Next == null)
        {
            head = null;
            return;
        }

        Node<T>? current = head;
        while (current.Next!.Next != null)
        {
            current = current.Next;
        }
        current.Next = null;
    }

    public void Insert(Node<T>? position, T? value)
    {
        Node<T>? newNode = new(value);
        newNode.Next = position!.Next;
        position.Next = newNode;
    }

    public void AddBefore(Node<T>? node, T value)
    {
        if (node == null) throw new ArgumentException("the node is null");
        if (Head == null) throw new ArgumentException("the head is null");

        Node<T> newNode = new(value);
        newNode.Next = node;

        Node<T> curr = Head;
        while (curr.Next != null && curr.Next != node)
        {
            curr = curr.Next;
        }
        curr.Next = newNode;
    }


    public void AddAfter(Node<T>? node, T value)
    {
        if (node == null) throw new ArgumentException("the node is null");
        if (Head == null) throw new ArgumentException("the head is null");

        Node<T> newNode = new(value);

        newNode.Next = node.Next;
        node.Next = newNode;
    }

    public void DeleteByValue(T? value)
    {
        if (head!.Value!.Equals(value))
        {
            head = head.Next;
        }

        Node<T>? current = head;
        while (current!.Next != null && !current.Next.Value!.Equals(value))
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void Empty()
    {
        head = null;
    }

    public Node<T>? GetMiddleElement(Node<T>? head) 
    {
        if(head == null)
        {
            throw new ArgumentException("The list is empty");
        }

        Node<T>? slow = head;
        Node<T>? fast = head;
        Node<T>? prev = null;

        while(fast.Next != null && fast.Next.Next != null)
        {
            prev = slow;
            fast = fast.Next.Next;
            slow = slow!.Next;
        }

        return prev;
    }

    public bool hasCycle() 
    {
        if(head == null)
        {
            throw new ArgumentException("List is empty");
        }

        Node<T>? slow = head;
        Node<T>? fast = head;

        while(fast != null && fast.Next != null)
        {
            slow = slow!.Next;
            fast = fast.Next.Next;

            if(fast == slow) return true;
        }

        return false;
    }

    public Node<T>? Merge(Node<T>? list1, Node<T>? list2) 
    {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        Node<T>? dummy = new Node<T>(default(T)!); 
        Node<T>? current = dummy;


        while(list1 != null && list2 != null)
        {
            if (list1.Value!.CompareTo(list2.Value) <= 0)
            {
                current.Next = list1;
                list1 = list1.Next;
            }
            else
            {
                current.Next = list2;
                list2 = list2.Next;
            }
            current = current.Next;
        }

        if (list1 == null)
            current.Next = list2;
        else current.Next = list1;

        return dummy.Next;
    }


    public Node<T>? MergeSort(Node<T>? head)
    {
        if(head == null || head.Next == null)
            return head;

        Node<T>? middle = GetMiddleElement(head);
        Node<T>? secondHalf = middle!.Next;
        middle.Next = null;

        Node<T>? left = MergeSort(head);
        Node<T>? right = MergeSort(secondHalf);

        return Merge(left, right);
    }

    public void Print()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
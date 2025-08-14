
class MyStack<T>
{

    private int _capacity = 0;
    private int _count = 0;
    private T[] stack = new T[0];

    public int Capacity
    {
        get { return _capacity; }
        set
        {
            _capacity = value;
        }
    }
    public int Count
    {
        get { return _count; }
        set
        {
            _count = value;
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            return stack[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            stack[index] = value;
        }
    }

    public void Push(T value)
    {
        if (Capacity == Count) Resize();

        stack[Count++] = value;

    }

    private void Resize()
    {
        Capacity = Capacity == 0 ? 4 : Capacity * 2;

        T[] temp = new T[Capacity];

        for (int i = 0; i < Count; i++)
        {
            temp[i] = stack[i];
        }

        stack = temp;
    }

    public void Pop()
    {
        stack[--Count] = default(T);
    }

    public T Top()
    {
        if (Count == 0)
        {
            throw new ArgumentException("Stack is empty");
        }

        return stack[Count - 1];
    }

    public int Size()
    {
        return Count;
    }

    public void Empty()
    {
        stack = new T[0];
        Count = 0;
        Capacity = 0;
    }
}
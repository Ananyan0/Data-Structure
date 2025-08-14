using System.Collections;


class MyList<T> : IEnumerable<T> 
{

    private int _capacity = 0;
    private int _count = 0;
    private T[] list = new T[0];


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
            return list[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            list[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
            yield return list[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Push_Back(T value)
    {
        if (Count == Capacity)
        {
            Resize();
        }

        list[Count++] = value;
    }

    private void Resize()
    {
        Capacity = (Capacity == 0) ? 4 : Capacity * 2;
        T[] temp = new T[Capacity];

        for (int i = 0; i < Count; i++)
        {
            temp[i] = list[i];
        }

        list = temp;
    }

    public void InsertAt(T value, int position)
    {
        for (int i = Count; i > position; i--)
        {
            list[i] = list[i - 1];
        }

        list[position] = value;
        Count++;
    }

    public void Pop_Back()
    {
        Count--;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentException($"The list do not have {index} index");
        }

        for (int i = index; i < Count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        Count--;
    }

    public bool DeleteByValue(T value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (list[i]?.Equals(value) == true)
            {
                for (int j = i; j < Count - 1; j++)
                {
                    list[j] = list[j + 1];
                }
                Count--;
                return true;
            }
        }

        return false;
    }

    public void ShrinkToFit()
    {
        if (Capacity == Count) return;

        T[] temp = new T[Count];

        for (int i = 0; i < Count; i++)
        {
            temp[i] = list[i];
        }

        list = temp;
        Capacity = Count;
    }

    public void Clean()
    {
        for (int i = 0; i < Count; i++)
        {
            list[i] = default(T);
        }

        Count = 0;
    }

    public void Empty()
    {
        list = new T[0];
        Count = 0;
        Capacity = 0;
    }



}
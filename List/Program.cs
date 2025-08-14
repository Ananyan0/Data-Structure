namespace Project_;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new();

        list.Push_Back(0);
        list.Push_Back(1);
        list.Push_Back(2);
        list.Push_Back(3);
        list.Push_Back(4);
        list.Push_Back(5);
        list.Push_Back(6);
        list.Push_Back(7);
        list.Push_Back(8);
        list.Push_Back(9);
        list.InsertAt(777, 4);
        list.DeleteAt(4);
        list.DeleteByValue(11);
        list.ShrinkToFit();


        foreach (int item in list)
        {
            System.Console.WriteLine(item);
        }
    }
}

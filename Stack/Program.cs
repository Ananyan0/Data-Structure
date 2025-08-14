namespace Project_;

class Program
{
    static void Main(string[] args)
    {

        MyStack<int> stack = new();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);


        for (int i = 0; i < stack.Count; i++)
        {
            System.Console.WriteLine(stack[i]);
        }

        System.Console.WriteLine();
        System.Console.WriteLine(stack.Top());
    }
}

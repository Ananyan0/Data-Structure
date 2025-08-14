class Program
{
    static void Main()
    {
        MyStack<int> stack = new MyStack<int>();

        Console.WriteLine(" Pushing elements ");

        Console.WriteLine();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        PrintStack(stack);

        Console.WriteLine(" Top element");
        Console.WriteLine(stack.Top());
        Console.WriteLine(" Pop elements");
        stack.Pop();
        stack.Pop();
        PrintStack(stack);

        Console.WriteLine(" Push more elements");

        Console.WriteLine();
        stack.Push(60);
        stack.Push(70);
        PrintStack(stack);
        Console.WriteLine();

        Console.WriteLine(" Stack size ");
        Console.WriteLine(stack.Size());

        Console.WriteLine(" Emptying stack ");
        stack.Empty();
        PrintStack(stack);
        Console.WriteLine($"Count={stack.Size()}, Capacity={stack.Capacity}");
    
    }

    private static void PrintStack(MyStack<int> stack)
    {
        Console.Write("Stack (bottom -> top): ");
        for (int i = 0; i < stack.Count; i++)
        {
            Console.Write(stack[i] + " ");
        }
        Console.WriteLine();
    }
}

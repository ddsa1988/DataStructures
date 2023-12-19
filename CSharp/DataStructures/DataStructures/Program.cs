using DataStructures.Stack;

public class Program {
    public static void Main(string[] args) {
        UserStack<int> myStack = new UserStack<int>(10);
        Console.WriteLine(myStack);

        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);

        Console.WriteLine(myStack);
        Console.WriteLine(myStack.Size());

        myStack.Pop();
        Console.WriteLine(myStack);
        Console.WriteLine(myStack.Size());
    }
}

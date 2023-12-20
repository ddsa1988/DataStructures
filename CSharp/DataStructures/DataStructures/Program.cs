using DataStructures.Entities;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        UserDeque<float> deque = new UserDeque<float>();

        deque.AddFront(10.5F);
        deque.AddBack(11.5F);
        deque.AddBack(22.5F);
        Console.WriteLine(deque);
        Console.WriteLine(deque.Size());
        deque.AddFront(200F);
        Console.WriteLine(deque);
        Console.WriteLine(deque.Size());
        Console.WriteLine(deque.RemoveFront());
        Console.WriteLine(deque);
        Console.WriteLine(deque.Size());
        deque.AddFront(300F);
        Console.WriteLine(deque);
        Console.WriteLine(deque.Size());
        Console.WriteLine(deque.RemoveBack());
        Console.WriteLine(deque);
        Console.WriteLine(deque.Size());
    }
}
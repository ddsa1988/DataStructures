using DataStructures.Entities;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        UserLinkedList<string> list = new UserLinkedList<string>();

        list.Push("Diego");
        list.Push("Amanda");
        list.Push("Amora");
        list.Push("Cereja");

        Console.WriteLine(list);
        Console.WriteLine(list.Size());
    }
}
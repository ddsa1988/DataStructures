using DataStructures.Entities;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        UserLinkedList<string> list = new UserLinkedList<string>();

        list.Insert("Rodrigo",0);
        list.Push("Diego");
        list.Push("Amanda");
        list.Push("Amora");
        list.Push("Cereja");
        
        Console.WriteLine(list.GetHead());
        list.Insert("Ivanice",2);
        Console.WriteLine(list.GetHead());
        list.Insert("Mireli",6);
        Console.WriteLine(list.GetHead());
    }
}
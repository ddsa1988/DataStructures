using DataStructures.Entities;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        Node<string> node1 = new Node<string>("Diego");
        Node<string> node2 = new Node<string>("Amanda");
        Node<string> node3 = new Node<string>("Diego");


        Console.WriteLine(node1);
        Console.WriteLine(node2);
        Console.WriteLine(node3);

        Console.WriteLine(node1.Equals(node2));
        Console.WriteLine(node2.Equals(node3));
        Console.WriteLine(node1.Equals(node3));

        Console.WriteLine(node1.GetHashCode());
        Console.WriteLine(node2.GetHashCode());
        Console.WriteLine(node3.GetHashCode());
    }
}
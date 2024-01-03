namespace DataStructures.Entities;

public class Node<T> {
    public T Element { get; }
    public Node<T>? Next { get; set; }

    public Node(T element) {
        Element = element;
        Next = null;
    }

    public override bool Equals(object? obj) {
        if (obj is not Node<T>) {
            return false;
        }

        Node<T>? other = obj as Node<T>;

        return other != null && Comparer<T>.Equals(Element, other.Element);
    }

    public override int GetHashCode() {
        return Element == null ? 0 : Element.GetHashCode();
    }

    public override string ToString() {
        string nextToString = Next != null ? Next.ToString() : "null";

        return Element +
               " => Next: " + nextToString;
    }
}
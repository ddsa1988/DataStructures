namespace DataStructures.Entities;

public class Node<T> {
    public T Element { get; private set; }
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

        if (other == null) {
            return false;
        }

        return Comparer<T>.Equals(Element, other.Element);
    }

    public override int GetHashCode() {
        if (Element == null) {
            return 0;
        }

        return Element.GetHashCode();
    }

    public override string ToString() {
        return "Value: " + Element +
               " Next: " + Next;
    }
}

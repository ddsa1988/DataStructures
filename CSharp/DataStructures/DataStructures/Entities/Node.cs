namespace DataStructures.Entities;

public class Node<T> {
    public T Value { get; private set; }
    public Node<T>? Next { get; private set; }

    public Node(T value) {
        Value = value;
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

        return Comparer<T>.Equals(Value, other.Value);
    }

    public override int GetHashCode() {
        if (Value == null) {
            return 0;
        }

        return Value.GetHashCode();
    }

    public override string ToString() {
        return "Value: " + Value +
               " Next: " + Next;
    }
}

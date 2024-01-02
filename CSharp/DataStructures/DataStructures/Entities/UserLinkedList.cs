using System.Text;

namespace DataStructures.Entities;

public class UserLinkedList<T> {
    private int counter = 0;
    private Node<T>? head = null;

    public void Push(T element) {
        Node<T> node = new Node<T>(element);

        if (IsEmpty()) {
            head = node;
        } else {
            Node<T>? current = head;

            while (current?.Next != null) {
                current = current.Next;
            }

            if (current != null) {
                current.Next = node;
            }
        }

        counter++;
    }

    public Node<T>? GetElementAt(int index) {
        if (IsEmpty()) {
            throw new Exception("Linkedlist is empty");
        }

        if (index < 0 || index > Size() - 1) {
            throw new Exception("Linkedlist index outrange");
        }

        Node<T>? node = head;

        for (int i = 0; i < index; i++) {
            node = node?.Next;
        }

        return node;
    }

    public int IndexOf(T element) {

        Node<T>? node = new Node<T>(element);
        Node<T>? current = head;

        for (int i = 0; i < Size(); i++) {

            if (current != null && current.Equals(node)) {
                return i;
            }

            current = current?.Next;
        }

        return -1;
    }

    public T? RemoveAt(int index) {
        Node<T>? current = head;

        if (index == 0) {
            head = current?.Next;
        } else {
            Node<T>? previous = GetElementAt(index - 1);
        }

        return default(T);
    }

    public int Size() {
        return counter;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public void Clear() {
        head = null;
        counter = 0;
    }

    public override string ToString() {
        if (IsEmpty()) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");
        Node<T>? current = head;

        while (current?.Next != null) {
            sb.Append(current.Element + " ");
            current = current.Next;
        }

        if (current != null) {
            sb.Append(current.Element);
        }

        sb.Append(" ]");

        return sb.ToString();
    }
}
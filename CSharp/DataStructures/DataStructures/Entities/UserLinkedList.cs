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

    public bool Insert(T element, int index) {
        if (index < 0 || index > Size()) {
            return false;
        }

        Node<T> node = new Node<T>(element);

        if (index == 0) {
            Node<T>? current = head;
            node.Next = current;
            head = node;
        } else {
            Node<T>? previous = GetElementAt(index - 1);

            if (previous == null) return false;

            Node<T>? current = previous.Next;
            node.Next = current;
            previous.Next = node;
        }

        counter++;

        return true;
    }

    public Node<T>? GetHead() {
        return head;
    }

    public Node<T>? GetElementAt(int index) {
        if (IsEmpty()) {
            throw new Exception("List is empty");
        }

        if (index < 0 || index > Size() - 1) {
            throw new Exception("List index out of range");
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
        if (index < 0 || index >= Size()) {
            return default(T);
        }

        Node<T>? current = head;

        if (index == 0) {
            head = current?.Next;
        } else {
            Node<T>? previous = GetElementAt(index - 1);

            current = previous?.Next;
            if (previous != null) {
                previous.Next = current?.Next;
            }
        }

        counter--;

        return current != null ? current.Element : default(T);
    }

    public bool Remove(T element) {
        int index = IndexOf(element);

        return RemoveAt(index) != null;
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
        if (IsEmpty() || head == null) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");
        Node<T>? current = head;

        while (current != null) {
            sb.Append(current.Element + " ");
            current = current.Next;
        }

        sb.Append(']');

        return sb.ToString();
    }
}
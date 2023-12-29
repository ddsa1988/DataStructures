using System.Text;

namespace DataStructures.Entities;

public class UserLinkedList<T> {
    private int counter = 0;
    private Node<T>? head = null;

    public void Push(T element) {
        Node<T> node = new Node<T>(element);

        if (head == null) {
            head = node;
        } else {
            Node<T> current = head;

            while (current.Next != null) {
                current = current.Next;
            }
            current.Next = node;
        }

        counter++;
    }

    public T RemoveAt(int index) {
        if (IsEmpty()) {
            throw new Exception("Linkedlist is empty");
        }

        if (index < 0 || index > Size() - 1) {

            throw new Exception("Index out of range");
        }

        Node<T>? current = head;

        if (index == 0) {
            head = head?.Next;
        } else {
            Node<T>? previous = null;

            for (int i = 0; i < index; i++) {
                previous = current;
                current = current?.Next;
            }

            previous.Next = current.Next;
        }
        counter--;

        return current.Element;
    }

    public int Size() {
        return counter;
    }

    public bool IsEmpty() {
        return Size() == 0;
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

        sb.Append(current.Element + " ]");

        return sb.ToString();
    }
}

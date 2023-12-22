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

        return sb.ToString();
    }
}

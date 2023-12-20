using System.Text;

namespace DataStructures.Entities;

public class UserQueue<T> {
    private readonly Dictionary<int, T> queue = new Dictionary<int, T>();
    private int head = 0;
    private int tail = 0;

    public void Enqueue(T item) {
        queue.TryAdd(tail++, item);
    }

    public T Dequeue() {
        if (IsEmpty()) {
            throw new Exception("Queue is empty");
        }

        T item = queue[head];
        queue.Remove(head++);

        return item;
    }

    public T Peek() {
        if (IsEmpty()) {
            throw new Exception("Queue is empty");
        }

        T item = queue[head];

        return item;
    }

    public int Size() {
        return tail - head;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public void Clear() {
        queue.Clear();
        head = 0;
        tail = 0;
    }

    public override string ToString() {
        if (IsEmpty()) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");

        for (int i = head; i < tail - 1; i++) {
            sb.Append(queue[i] + ", ");
        }

        sb.Append(queue[tail - 1] + " ]");

        return sb.ToString();
    }
}
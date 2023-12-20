using System.Globalization;
using System.Text;

namespace DataStructures.Entities;

public class UserDeque<T> {
    private readonly Dictionary<int, T> deque = new Dictionary<int, T>();
    private int head = 0;
    private int tail = 0;

    public void AddFront(T item) {
        if (IsEmpty()) {
            AddBack(item);
        } else if (head > 0) {
            deque.TryAdd(--head, item);
        } else {
            deque.TryAdd(tail, deque[tail - 1]);

            for (int i = tail - 1; i > 0; i--) {
                deque[i] = deque[i - 1];
            }

            deque[0] = item;
            tail++;
        }

    }

    public void AddBack(T item) {
        deque.TryAdd(tail++, item);
    }

    public T RemoveFront() {
        if (IsEmpty()) {
            throw new Exception("Deque is empty");
        }

        T item = deque[head];
        deque.Remove(head++);

        return item;
    }

    public T RemoveBack() {
        if (IsEmpty()) {
            throw new Exception("Deque is empty");
        }

        T item = deque[--tail];
        deque.Remove(tail);

        return item;
    }

    public T PeekFront() {
        if (IsEmpty()) {
            throw new Exception("Deque is empty");
        }

        T item = deque[head];

        return item;
    }

    public T PeekBack() {
        if (IsEmpty()) {
            throw new Exception("Deque is empty");
        }

        T item = deque[tail - 1];

        return item;
    }

    public int Size() {
        return tail - head;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public void Clear() {
        deque.Clear();
        head = 0;
        tail = 0;
    }

    public override string ToString() {
        if (IsEmpty()) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");

        for (int i = head; i < tail - 1; i++) {
            sb.Append(deque[i].ToString() + ", ");
        }

        sb.Append(deque[tail - 1] + " ]");

        return sb.ToString();
    }
}
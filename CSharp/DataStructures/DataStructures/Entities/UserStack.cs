using System.Text;

namespace DataStructures.Entities;

public class UserStack<T> {
    private readonly Dictionary<int, T> stack = new Dictionary<int, T>();
    private int counter = 0;

    public void Push(T item) {
        stack.TryAdd(counter++, item);
    }

    public T Pop() {
        if (IsEmpty()) {
            throw new Exception("Stack is empty");
        }

        T item = stack[--counter];
        stack.Remove(counter);

        return item;
    }

    public T Peek() {
        if (IsEmpty()) {
            throw new Exception("Stack is empty");
        }

        T item = stack[counter - 1];

        return item;
    }

    public int Size() {
        return counter;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public void Clear() {
        stack.Clear();
        counter = 0;
    }

    public override string ToString() {
        if (IsEmpty()) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");

        for (int i = 0; i < Size() - 1; i++) {
            sb.Append(stack[i] + ", ");
        }

        sb.Append(stack[Size() - 1] + " ]");

        return sb.ToString();
    }
}
using System.Text;

namespace DataStructures.Stack;

public class UserStack<T> {

    private readonly T[] stack;
    private int counter = 0;

    public UserStack(int size) {
        stack = new T[size];
    }

    public void Push(T item) {
        if (IsFull()) {
            throw new Exception("Stack is full");
        }

        stack[counter++] = item;
    }

    public T Pop() {
        if (IsEmpty()) {
            throw new Exception("Stack is empty");
        }

        T item = stack[counter - 1];
        stack[--counter] = default;

        return item;
    }

    public int Size() {
        return counter;
    }

    public bool IsEmpty() {
        return Size() == 0;
    }

    public bool IsFull() {
        return Size() == stack.Length;
    }

    public void Clear() {
        Array.Clear(stack);
        counter = 0;
    }

    public override string ToString() {
        if (IsEmpty()) {
            return "";
        }

        StringBuilder sb = new StringBuilder("[ ");

        for (int i = 0; i < Size(); i++) {
            sb.Append(stack[i] + " ");
        }

        sb.Append(']');

        return sb.ToString();
    }
}

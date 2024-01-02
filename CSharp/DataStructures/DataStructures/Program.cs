﻿using DataStructures.Entities;

namespace DataStructures;

public class Program {
    public static void Main(string[] args) {
        UserLinkedList<string> list = new UserLinkedList<string>();

        list.Push("Diego");
        list.Push("Amanda");
        list.Push("Amora");
        list.Push("Cereja");

        Console.WriteLine(list);
        Console.WriteLine(list.Size());
        Console.WriteLine(list.GetElementAt(2));
        Console.WriteLine(list.IndexOf("Cereja"));
        list.RemoveAt(2);
        Console.WriteLine(list);
    }
}
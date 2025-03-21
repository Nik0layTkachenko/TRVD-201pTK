using System;
using System.Collections.Generic;
using System.Linq;

class StringArray
{
    private string[] array;

    public StringArray(int size)
    {
        if (size < 0) throw new ArgumentException("Size must be non-negative.");
        array = new string[size];
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("Index out of bounds.");
            return array[index];
        }
        set
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("Index out of bounds.");
            array[index] = value;
        }
    }

    public int Length => array.Length;

    public static StringArray Concatenate(StringArray a, StringArray b)
    {
        if (a == null || b == null) throw new ArgumentNullException();
        StringArray result = new StringArray(a.Length);
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }
        return result;
    }

    public static StringArray Merge(StringArray a, StringArray b)
    {
        if (a == null || b == null) throw new ArgumentNullException();
        HashSet<string> mergedSet = new HashSet<string>(a.array.Concat(b.array));
        StringArray result = new StringArray(mergedSet.Count);
        int index = 0;
        foreach (var item in mergedSet)
        {
            result[index++] = item;
        }
        return result;
    }

    public void Print()
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }
}

class Program
{
    static void Main()
    {
        StringArray arr1 = new StringArray(3);
        arr1[0] = "Hello";
        arr1[1] = "World";
        arr1[2] = "C#";

        StringArray arr2 = new StringArray(3);
        arr2[0] = "!";
        arr2[1] = "Programmers";
        arr2[2] = "Rocks";

        Console.WriteLine("Array 1:");
        arr1.Print();
        Console.WriteLine("Array 2:");
        arr2.Print();

        StringArray concatenated = StringArray.Concatenate(arr1, arr2);
        Console.WriteLine("Concatenated:");
        concatenated.Print();

        StringArray merged = StringArray.Merge(arr1, arr2);
        Console.WriteLine("Merged:");
        merged.Print();
    }
}

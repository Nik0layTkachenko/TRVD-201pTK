using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Заданий масив рядків
        string[] words = { "apple", "dog", "addict", "bridge", "doodle", "dedicate", "zebra", "delta" };

        // а) Знаходимо слово, яке передує всім іншим за алфавітом
        string minWord = words.OrderBy(word => word).First();
        Console.WriteLine($"Слово, яке передує всім іншим: {minWord}");

        // б) Виводимо всі слова, що мають рівно дві букви 'd'
        var wordsWithTwoD = words.Where(word => word.Count(c => c == 'd') == 2);
        Console.WriteLine("Слова з рівно двома літерами 'd':");
        foreach (var word in wordsWithTwoD)
        {
            Console.WriteLine(word);
        }
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Завдання 1
        double x = 2.0, y = 3.0; // Змініть значення за необхідності
        double result1 = (Math.Pow((x + 1) / (x - 1), 2)) + 18 * x * y;
        Console.WriteLine("Завдання 1: " + result1);

        // Завдання 2
        double expr2 = -2 * x + 3 * x * x - 4 * Math.Pow(x, 3) + 1 + 2 * x + 3 * x * x + 4 * Math.Pow(x, 3);
        Console.WriteLine("Завдання 2: " + expr2);

        // Завдання 3
        double a1 = 3, b1 = 4, c1 = 5;
        double a2 = 6, b2 = 8, c2 = 10;
        bool isEqualArea = (a1 * b1 * c1) == (a2 * b2 * c2);
        Console.WriteLine("Завдання 3: " + isEqualArea);

        // Завдання 4
        int N = 10, M = 8;
        int floor = ((M - 1) / 3) * 2 + 1;
        Console.WriteLine("Завдання 4: " + floor);

        // Завдання 5
        int n = 30;
        Console.WriteLine("Завдання 5:");
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();

        // Завдання 6
        int[] arr = { 4, 2, 7, 1, 9, 1, 3 };
        int minVal = arr.Min();
        double avg = arr.Average();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == minVal)
                arr[i] = (int)avg;
        }
        Console.WriteLine("Завдання 6: " + string.Join(", ", arr));

        // Завдання 7
        string sentence = "Привіт світ";
        string[] words = sentence.Split(' ');
        int lastWordLength = words[^1].Length;
        Console.WriteLine("Завдання 7: " + lastWordLength);
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

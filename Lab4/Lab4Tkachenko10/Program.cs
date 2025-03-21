using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Завдання 1: Робота з одновимірним масивом
        Console.Write("Введіть розмір масиву n: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.NextDouble() * 200 - 100; // Заповнення числами від -100 до 100
        }

        Console.Write("Введіть A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Введіть B: ");
        double B = double.Parse(Console.ReadLine());

        int countInRange = array.Count(x => x >= A && x <= B);
        int maxIndex = Array.IndexOf(array, array.Max());
        double sumAfterMax = array.Skip(maxIndex + 1).Sum();

        Array.Sort(array, (x, y) => Math.Abs(y).CompareTo(Math.Abs(x))); // Сортування за спаданням модулів

        Console.WriteLine($"Кількість елементів в діапазоні [{A}, {B}]: {countInRange}");
        Console.WriteLine($"Сума елементів після максимального: {sumAfterMax}");
        Console.WriteLine("Масив після сортування:");
        Console.WriteLine(string.Join(", ", array));

        // Завдання 2: Робота з двовимірним масивом
        Console.Write("Введіть кількість рядків m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців k: ");
        int k = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, k];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < k; j++)
            {
                matrix[i, j] = rand.Next(-50, 51); // Заповнення числами від -50 до 50
            }
        }

        Console.WriteLine("Матриця:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        bool hasOddCorner = (matrix[0, k - 1] % 2 != 0) || (matrix[m - 1, k - 1] % 2 != 0);
        bool hasFiveCorner = (matrix[0, 0] % 10 == 5) || (matrix[m - 1, 0] % 10 == 5);

        Console.WriteLine($"Чи є непарні числа у верхньому правому або нижньому правому куті: {hasOddCorner}");
        Console.WriteLine($"Чи є числа, що закінчуються на 5 у верхньому лівому або нижньому лівому куті: {hasFiveCorner}");
    }
}

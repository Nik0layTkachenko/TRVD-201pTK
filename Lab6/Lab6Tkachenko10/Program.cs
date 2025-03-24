using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть чисельник: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Введіть знаменник: ");
            int denominator = int.Parse(Console.ReadLine());

            int wholePart = GetWholePart(numerator, denominator);
            Console.WriteLine($"Ціла частина: {wholePart}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Помилка: знаменник не може бути нулем.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введіть коректні цілі числа.");
        }
        finally
        {
            Console.WriteLine("Програма завершила виконання.");
        }
    }

    static int GetWholePart(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}

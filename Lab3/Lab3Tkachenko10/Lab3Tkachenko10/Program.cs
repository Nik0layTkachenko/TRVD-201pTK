using System;

// Абстрактний клас Triad
abstract class Triad
{
    protected int value1, value2, value3;

    public Triad(int v1, int v2, int v3)
    {
        value1 = v1;
        value2 = v2;
        value3 = v3;
    }

    public virtual void Increment()
    {
        value1++;
        value2++;
        value3++;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Values: {value1}, {value2}, {value3}");
    }
}

// Клас Date (Дата)
class Date : Triad
{
    public Date(int day, int month, int year) : base(day, month, year) { }

    public override void Increment()
    {
        value1++; // День
        if (value1 > 30) // Спрощена перевірка на дні місяця
        {
            value1 = 1;
            value2++;
        }
        if (value2 > 12)
        {
            value2 = 1;
            value3++;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"Date: {value1:D2}/{value2:D2}/{value3}");
    }
}

// Клас Time (Час)
class Time : Triad
{
    public Time(int hours, int minutes, int seconds) : base(hours, minutes, seconds) { }

    public override void Increment()
    {
        value3++; // Секунди
        if (value3 >= 60)
        {
            value3 = 0;
            value2++; // Хвилини
        }
        if (value2 >= 60)
        {
            value2 = 0;
            value1++; // Години
        }
        if (value1 >= 24)
        {
            value1 = 0;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"Time: {value1:D2}:{value2:D2}:{value3:D2}");
    }
}

class Program
{
    static void Main()
    {
        Date date = new Date(30, 12, 2023);
        Time time = new Time(23, 59, 59);

        Console.WriteLine("Before Increment:");
        date.Display();
        time.Display();

        date.Increment();
        time.Increment();

        Console.WriteLine("After Increment:");
        date.Display();
        time.Display();
    }
}
using System;

class Program
{
    static void Main()
    {
        // Введення значення x з консолі
        Console.WriteLine("Введіть значення x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Одиничні лямбда-вирази для обчислення функції F(x)
        Func<double, double> F1 = (double xValue) => xValue > 0 ? (xValue * xValue + 4) : 0;
        Func<double, double> F2 = (double xValue) => xValue > 0 ? (xValue * xValue + 4) : 0;

        // Виконання обчислення залежно від введеного x
        double result = x > 0 ? F1(x) : F2(x);

        // Виведення результату на консоль
        Console.WriteLine($"Результат F({x}) = {result}");
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведете коефициентите на полином, разделени с интервали:");
        string input = Console.ReadLine();

        // Разделяме входа и го преобразуваме в масив от числа
        double[] coefficients = input.Split(' ').Select(double.Parse).ToArray();

        // Извеждаме коефициентите
        Console.WriteLine("Коефициентите на полинома са:");
        foreach (var coefficient in coefficients)
        {
            Console.WriteLine(coefficient);
        }
    }
}

using System;

public class Program
{
    public static double CalculateAverageFromIntegerArray(int [] num)
    {
        int avg = 0;
        if (num == null || num.Length == 0)
        {
            throw new ArgumentException("You provided an empty array or null array");
        }

        for (int i = 0; i < num.Length; i++)
        {
            avg += num[i];
        }

        return (double) avg /num.Length;
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        Console.WriteLine("Average: " + CalculateAverageFromIntegerArray(numbers));
    }
}

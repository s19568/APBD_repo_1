using System;

public class Program
{
    public static double FindAverage(int [] num)
    {
        int avg = 0;
        if (num == null || num.Length == 0)
            throw new ArgumentException("You provided an empty array or null array");

        for (int i = 0; i < num.Length; i++)
        {
            avg += num[i];
        }

        return (double) avg /num.Length;
    }

    public static int FindMax(int[] num)
    {
        int max = 0;
        if (num == null || num.Length == 0)
            throw new ArgumentException("You provided an empty array or null array");
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
                max = num[i];
        }
        return max;
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        int[] numbersForMax = { 2, 3, 5, 7, 11, 29, 19, 23, 17 };
        Console.WriteLine("Average: " + FindAverage(numbers));
        Console.WriteLine("Max number: " + FindMax(numbersForMax));
    }
}


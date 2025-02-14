using System;

public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        // Check if the number is an integer
        if (a % 1 != 0)
        {
            Console.WriteLine($"{a} is not an integer.");
            return;
        }

        long number = (long)a;
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    public void SumTwoNumbers()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }

    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        int a = 0, b = 1;
        Console.Write("Fibonacci Series: ");
        Console.Write($"{a} {b} ");
        // Printing the first 20 Fibonacci numbers (first two already printed)
        for (int i = 2; i < 20; i++)
        {
            int c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
        }
        Console.WriteLine();
    }

    public string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int RecursiveFactorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        if (n == 0)
            return 1;
        return n * RecursiveFactorial(n - 1);
    }
}
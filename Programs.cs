using System;

class Programs
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static string BuildFullName(string first, string last)
    {
        return first + " " + last;
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static int SumArray(int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        return total;
    }

    static int FindMax(int[] numbers)
    {
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }

    static void ReverseArray(int[] numbers)
    {
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;

            start++;
            end--;
        }
    }

    static void Main()
    {
        Console.WriteLine(Add(5, 3));

        Console.WriteLine(BuildFullName("Justina", "Iruoma"));

        for (int i = 1; i <= 10; i++)
        {
            if (IsEven(i))
            {
                Console.WriteLine(i + " - Even");
            }
            else
            {
                Console.WriteLine(i + " - Odd");
            }
        }

        int[] numbers = { 10, 20, 30, 40 };

        Console.WriteLine("Sum: " + SumArray(numbers));

        Console.WriteLine("Maximum: " + FindMax(numbers));

        ReverseArray(numbers);

        Console.WriteLine("Reversed array:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
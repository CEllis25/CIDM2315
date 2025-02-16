using System;

class Program
{
    // Q1_Method()
    static int GetLargestNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    // Q2_Method
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}, Shape: {shape}");
        
        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid shape type. Use 'left' or 'right'.");
        }
    }

    static void Main()
    {
        int number1 = 5;
        int number2 = 8;
        
        // Call Q1_Method
        int largest = Program.GetLargestNumber(number1, number2);
        Console.WriteLine($"The largest number is: {largest}");

        // Call Q2_Method
        PrintTriangle(5, "left");
        PrintTriangle(5, "right");
    }
}

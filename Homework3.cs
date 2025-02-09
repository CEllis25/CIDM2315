using System;

class Program
{
    //Code for Q1
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Input an integer: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            if (IsPrime(N))
                Console.WriteLine($"{N} is prime");
            else
                Console.WriteLine($"{N} is non-prime");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an valid integer.");
        }

        //Code for Q2
     {
        Console.Write("Input an integer: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
     }

   //Code for Q3
 {
        Console.Write("Assign an int value to N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
 }
 }
}


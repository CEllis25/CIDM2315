namespace Homework2;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1
        Console.Write("Enter a letter grade (A, B, C, D, F): ");
        string input = Console.ReadLine().ToUpper(); // Convert input to uppercase

        switch (input)
        {
            case "A":
                Console.WriteLine("GPA Points: 4");
                break;
            case "B":
                Console.WriteLine("GPA Points: 3");
                break;
            case "C":
                Console.WriteLine("GPA Points: 2");
                break;
            case "D":
                Console.WriteLine("GPA Points: 1");
                break;
            case "F":
                Console.WriteLine("GPA Points: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

      // Code for Q2
     {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int smallest = Math.Min(num1, Math.Min(num2, num3));

        Console.WriteLine($"The smallest number is: {smallest}");
     }

      // Code for Bonus question
     {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
     }

  }
}

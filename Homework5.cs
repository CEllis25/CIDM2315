using System;

class Program
{
    //Q1 Method
    static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }


    //Q1 Call Method
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int largest = GetLargest(num1, num2);
        Console.WriteLine("The largest number is: " + largest);
    }
}
    //Q2 Method
{
    static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int max1 = GetLargest(a, b);
        int max2 = GetLargest(c, d);
        return GetLargest(max1, max2);
    }

    //Q2 Call Method
    {
        Console.Write("Enter first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third integer: ");
        int num3 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter fourth integer: ");
        int num4 = int.Parse(Console.ReadLine());
        
        int largest = GetLargestOfFour(num1, num2, num3, num4);
        Console.WriteLine("The largest number is: " + largest);
    }
}


   //Q3 Method
{
    static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int max1 = GetLargest(a, b);
        int max2 = GetLargest(c, d);
        return GetLargest(max1, max2);
    }

    static bool CheckAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        Console.Write("Re-enter password: ");
        string confirmPassword = Console.ReadLine();
        
        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine());
        
        if (CheckAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

    {
        Console.Write("Enter first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third integer: ");
        int num3 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter fourth integer: ");
        int num4 = int.Parse(Console.ReadLine());
        
        int largest = GetLargestOfFour(num1, num2, num3, num4);
        Console.WriteLine("The largest number is: " + largest);
        
        CreateAccount();
    }
}




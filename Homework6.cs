using System;
//Q1 Answer
//Code for Professor Class
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public Professor(string name, string teach, double salary_amount)
    {
        profName = name;
        classTeach = teach;
        salary = salary_amount;
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}
//Code for Student Class
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public Student(string name, string enroll, double grade)
    {
        studentName = name;
        classEnroll = enroll;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Program
{
    static void Main()
    {
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        Console.WriteLine($"Professor {prof1.profName} teaches {prof1.classTeach} and earns {prof1.GetSalary()}");
        Console.WriteLine($"Professor {prof2.profName} teaches {prof2.classTeach} and earns {prof2.GetSalary()}");

        Console.WriteLine($"Student {student1.studentName} is enrolled in {student1.classEnroll} and has a grade of {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.studentName} is enrolled in {student2.classEnroll} and has a grade of {student2.GetGrade()}");
    }
}

//Q2 Answer
{
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        Console.WriteLine("Professor Details:");
        Console.WriteLine($"Name: {prof1.profName}, Class: {prof1.classTeach}, Salary: {prof1.GetSalary()}");
        Console.WriteLine($"Name: {prof2.profName}, Class: {prof2.classTeach}, Salary: {prof2.GetSalary()}");

        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {student1.studentName}, Class: {student1.classEnroll}, Grade: {student1.GetGrade()}");
        Console.WriteLine($"Name: {student2.studentName}, Class: {student2.classEnroll}, Grade: {student2.GetGrade()}");

        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"\nSalary Difference between {prof1.profName} and {prof2.profName}: {salaryDifference}");

        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total Grade of {student1.studentName}'s {student1.classEnroll} course and {student2.studentName}'s {student2.classEnroll} course: {totalGrade}");
    }



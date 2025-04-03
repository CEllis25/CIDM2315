using System;
using System.Collections.Generic;
using System.Linq;

// Step 1
class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}");
    }

    public string GetName()
    {
        return studentName;
    }
}

class Program
{
    static void Main()
    {
        // Step 2
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");
        
        // Step 3
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };
        
        // Step 4
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }
        
        // Step 5
        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"Average GPA: {averageGPA:F2}");
        
        // Step 6
        Console.WriteLine("Students with GPA greater than the average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.GetName()) && gradebook[student.GetName()] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}

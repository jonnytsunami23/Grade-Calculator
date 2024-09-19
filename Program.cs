using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Main function to drive the program
        Dictionary<string, int[]> studentScores = GetStudentData();

        // Print the table of student scores, averages, and letter grades
        PrintStudentGrades(studentScores);
    }

    // Function to collect student data (names, scores)
    static Dictionary<string, int[]> GetStudentData()
    {
        Dictionary<string, int[]> studentScores = new Dictionary<string, int[]>();

        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numStudents; i++)
        {
            // Get student's name and assignment scores
            string studentName = GetStudentName(i);
            int[] scores = GetAssignmentScores(studentName);

            // Add to dictionary
            studentScores.Add(studentName, scores);
        }

        return studentScores;
    }

    // Function to get a student's name
    static string GetStudentName(int studentIndex)
    {
        Console.Write($"Enter the name of student {studentIndex + 1}: ");
        return Console.ReadLine();
    }

    // Function to get assignment scores for a student
    static int[] GetAssignmentScores(string studentName)
    {
        Console.Write($"Enter the number of assignments for {studentName}: ");
        int numAssignments = int.Parse(Console.ReadLine());

        int[] assignmentScores = new int[numAssignments];

        // Collect the scores for each assignment
        for (int j = 0; j < numAssignments; j++)
        {
            Console.Write($"What was the score for assignment {j + 1}?: ");
            assignmentScores[j] = int.Parse(Console.ReadLine());
        }

        return assignmentScores;
    }

    // Function to calculate and print the table of student grades
    static void PrintStudentGrades(Dictionary<string, int[]> studentScores)
    {
        // Print table headers
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("{0,-15} {1,-10} {2,-10}", "Student Name", "Average", "Grade");
        Console.WriteLine("------------------------------------");

        // Iterate through the student dictionary and print scores
        foreach (var student in studentScores)
        {
            string studentName = student.Key;
            int[] scores = student.Value;

            // Calculate the average score
            double averageScore = scores.Average();

            // Get the letter grade based on average score
            string letterGrade = GetLetterGrade(averageScore);

            // Print student details in formatted columns
            Console.WriteLine("{0,-15} {1,-10:F2} {2,-10}", studentName, averageScore, letterGrade);
        }

        // Print table footer
        Console.WriteLine("------------------------------------");
    }

    // Function to determine the letter grade based on average score
    static string GetLetterGrade(double averageScore)
    {
        if (averageScore >= 90)
            return "A";
        else if (averageScore >= 80)
            return "B";
        else if (averageScore >= 70)
            return "C";
        else if (averageScore >= 60)
            return "D";
        else
            return "F";
    }
}

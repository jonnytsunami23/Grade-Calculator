# Grade-Calculator
Student Grade Calculator
This C# console application allows users to input student names and assignment scores, calculates their average scores, and assigns letter grades based on the averages. The application supports any number of students and assignments.

Features
Collects student names and assignment scores.
Calculates the average score for each student.
Assigns a letter grade based on the average score.
Outputs a formatted table displaying the student names, averages, and corresponding grades.
Getting Started
Prerequisites
.NET Core SDK or any C# compiler.
A console environment to run the application.
How to Run
Clone the repository to your local machine.
Open the project in a C# environment.
Build and run the Program.cs file.
Use command dotnet run in terminal.
Follow the prompts to enter the number of students, their names, and the scores for each assignment.
Example Usage
Upon running the program, you'll be prompted to enter the number of students. After that, you'll input each student's name and the number of assignments. The program will then request the score for each assignment.

Example interaction:
Enter the number of students: 2
Enter the name of student 1: John
Enter the number of assignments for John: 3
What was the score for assignment 1?: 85
What was the score for assignment 2?: 90
What was the score for assignment 3?: 80
Enter the name of student 2: Alice
Enter the number of assignments for Alice: 2
What was the score for assignment 1?: 95
What was the score for assignment 2?: 92
After entering the data, the program outputs a table with student names, their average scores, and letter grades:

------------------------------------
Student Name    Average    Grade    
------------------------------------
John            85.00      B        
Alice           93.50      A        
------------------------------------
Grading Scale
A: 90-100
B: 80-89
C: 70-79
D: 60-69
F: 0-59

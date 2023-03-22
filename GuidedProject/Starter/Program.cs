using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;


string getLetterGrade(decimal grade) {
#pragma warning disable format
         if (grade >= 97) return "A+";
    else if (grade >= 93) return "A";
    else if (grade >= 90) return "A-";
    else if (grade >= 87) return "B+";
    else if (grade >= 83) return "B";
    else if (grade >= 80) return "B-";
    else if (grade >= 77) return "C+";
    else if (grade >= 73) return "C";
    else if (grade >= 70) return "C-";
    else if (grade >= 67) return "D+";
    else if (grade >= 63) return "D";
    else if (grade >= 60) return "D-";
    else return "F";
#pragma warning restore format
}

Dictionary<string, int[]> students = new Dictionary<string, int[]>();
students.Add("Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 });
students.Add("Andrew", new int[] { 92, 89, 81, 96, 90, 89 });
students.Add("Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 });
students.Add("Logan", new int[] { 90, 95, 87, 88, 96, 96 });
students.Add("Becky", new int[] { 92, 91, 90, 91, 92, 92, 92 });
students.Add("Chris", new int[] { 84, 86, 88, 90, 92, 94, 96, 98 });
students.Add("Eric", new int[] { 80, 90, 100, 80, 90, 100, 80, 90 });
students.Add("Gregor", new int[] { 91, 91, 91, 91, 91, 91, 91 });

Console.WriteLine("Student\t\tGrade\n");
const int exams = 5;
void printGrades(Dictionary<string, int[]> students) {
    foreach (var (studentName, scores) in students) {
        decimal sum = 0;
        int count = 0;
        foreach (int score in scores) {
            ++count;
            // extra credit is in the same array listed after the known exams
            if (count > exams) {
                sum += score * (decimal).1;
            } else {
                sum += score;
            }
        }
        decimal grade = sum / (decimal)exams;

        Console.WriteLine($"{studentName}:\t\t{grade}\t{getLetterGrade(grade)}");
    }
}

printGrades(students);

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

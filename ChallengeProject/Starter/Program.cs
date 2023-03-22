/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
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

int examAssignments = 5;

Dictionary<string, int[]> students = new Dictionary<string, int[]>();
students.Add("Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 });
students.Add("Andrew", new int[] { 92, 89, 81, 96, 90, 89 });
students.Add("Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 });
students.Add("Logan", new int[] { 90, 95, 87, 88, 96, 96 });


// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

void printGrades(Dictionary<string, int[]> students) {
    foreach (var (studentName, scores) in students) {
        decimal examSum = 0, extraCreditSum = 0;
        int count = 0;
        foreach (int score in scores) {
            ++count;
            if(count <= examAssignments) {
                examSum += score;
            } else {
                extraCreditSum += score;
            }
        }
        decimal examGrade = examSum / (decimal)examAssignments;

        // extra credit grade is 0 if there aren't any extra credit scores
        decimal extraCreditGrade = 0;
        if (scores.Length > examAssignments)
            extraCreditGrade = extraCreditSum / ((decimal)scores.Length - examAssignments);

        decimal extraCreditPoints = extraCreditSum / (decimal)10 / (decimal)examAssignments;
        decimal overallGrade = examSum / (decimal)examAssignments + extraCreditPoints;
        Console.WriteLine($"{studentName}:\t\t{examGrade}\t\t{overallGrade}\t{getLetterGrade(overallGrade)}\t{extraCreditGrade} ({extraCreditPoints} pts)");
    }
}

printGrades(students);


// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        string student = "Micheal";
        string topic = "Multiplication";
        string mathBook = "Section 7.3";
        string mathProblem = "Problems 8-19";
        string reading = "The Causes of World War II by Mary Waters";

        Assignment assignment = new(student, topic);

        MathAssignment math_assignment = new(student, topic, mathBook, mathProblem);

        WritingAssignment writing_assignment = new(student, topic, reading);
    
        string summary = assignment.GetSummary();
        string math = math_assignment.GetHomeworkList();
        string reading_fun = writing_assignment.GetWrtitingInformation();
        Console.WriteLine(reading_fun);
        
    }
}
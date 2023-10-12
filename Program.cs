using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            GradeManager gradeManager = new GradeManager();

            bool isOperationValid = false;

            do
            {
                Console.WriteLine("\n*** Grade Manager ***");
                Console.WriteLine("Type 'a' to add grade");
                Console.WriteLine("Type 'r' to remove grade");
                Console.WriteLine("Type 'g' to get student grades");
                Console.WriteLine("Type 'av' to check average of grades");

                string operationSymbol = Console.ReadLine();

                if (operationSymbol == "a" || operationSymbol == "r")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    Console.Write("Grade (1-6): ");
                    string grade = Console.ReadLine();

                    if (operationSymbol == "a") gradeManager.AddGrade(studentName, int.Parse(grade));
                    else gradeManager.RemoveGrade(studentName, int.Parse(grade));

                    isOperationValid = true;

                }
                else if (operationSymbol == "g" || operationSymbol == "av")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    if (operationSymbol == "g")
                    {
                        Console.Write($"{studentName} grades are: ");
                        gradeManager.GetGrades(studentName);
                    }
                    else
                    {
                        double average = gradeManager.CalculateAverageGrade(studentName);
                        Console.WriteLine($"{studentName} average is {average}");
                    }

                    isOperationValid = true;

                }
                else
                {
                    Console.WriteLine("Wrong symbol, try again...\n");
                }

            } while (isOperationValid);
        }

    }


}

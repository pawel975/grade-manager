using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeManager
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            bool isOperationValid = false;

            do
            {
                Console.Write("*** Grade Manager ***");
                Console.WriteLine("Type 'a' to add grade");
                Console.WriteLine("Type 'r' to remove grade");
                Console.WriteLine("Type 'g' to get student grades");
                Console.WriteLine("Type 'av' to check average of grades");

                GradeManager gradeManager = new GradeManager();

                string operationSymbol = Console.ReadLine();

                if (operationSymbol == "a")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    Console.Write("Grade (1-6): ");
                    string grade = Console.ReadLine();

                    gradeManager.AddGrade(studentName, int.Parse(grade));
                    isOperationValid = true;

                }
                else if (operationSymbol == "r")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    Console.Write("Grade (1-6): ");
                    string grade = Console.ReadLine();

                    gradeManager.RemoveGrade(studentName, int.Parse(grade));
                    isOperationValid = true;

                }
                else if (operationSymbol == "g")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    gradeManager.GetGrades(studentName);
                    isOperationValid = true;

                }
                else if (operationSymbol == "av")
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();

                    gradeManager.CalculateAverageGrade(studentName);
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

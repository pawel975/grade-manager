using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class GradeManager
    {
        // Init grades dictionary for all students
        Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

        public void AddGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
            if (!grades.ContainsKey(studentName))
            {
                grades[studentName] = new List<int>();
            }

            grades[studentName].Add(grade);
            Console.WriteLine("Grade added");
        }

        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
            if (grades.ContainsKey(studentName))
            {
                grades[studentName].Remove(grade);
                Console.WriteLine("Grade removed");
            }
            else
            {
                Console.WriteLine("Student doesn't exist");
            }
        }

        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (grades.ContainsKey(studentName))
            {
                List<int> studentGrades = grades[studentName];
                double gradesSum = 0;

                foreach (int grade in studentGrades)
                {
                    gradesSum += grade;
                }

                return gradesSum / studentGrades.Count;
            }
            else
            {
                return 0;
            }
        }

        public void GetGrades(string studentName)
        {
            try
            {
                List<int> studentGrades = new List<int>();

                Console.Write($"{studentName} grades are: ");
                foreach (int grade in grades[studentName])
                {
                    Console.Write($"{grade},");
                }

                Console.WriteLine("\n");
            }
            catch
            {
                Console.WriteLine($"There is no student named {studentName}");
            }
        }
    }
}

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

        /// <summary>
        /// Adds grade to dictionary of grades
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="grade"></param>
        public void AddGrade(string studentName, int grade)
        {
            if (!grades.ContainsKey(studentName))
            {
                grades[studentName] = new List<int>();
            }

            grades[studentName].Add(grade);
        }

        /// <summary>
        /// Remove grade from dictionary of grades
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="grade"></param>
        public void RemoveGrade(string studentName, int grade)
        {
            if (grades.ContainsKey(studentName))
            {
                grades[studentName].Remove(grade);
            }
        }

        /// <summary>
        /// Calculates average of grades for student
        /// </summary>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public double CalculateAverageGrade(string studentName)
        {
            if (grades.ContainsKey(studentName) && grades[studentName].Count > 0)
            {
                return grades[studentName].Average();
            }
            else
            {
                return 0.0;
            }
        }

        /// <summary>
        /// Return all student grades
        /// </summary>
        /// <param name="studentName"></param>
        public void GetGrades(string studentName)
        {
            if (grades[studentName] != null)
            {
                foreach (int grade in grades[studentName])
                {
                    Console.Write($"{grade},");
                }

            }
        }
    }
}

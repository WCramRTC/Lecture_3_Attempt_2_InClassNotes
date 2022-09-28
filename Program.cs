using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_Attempt_2_InClassNotes
{
    internal class Program
    {
        static List<int> compSciGrades = new List<int> { 72, 100, 100, 77 };
        static List<int> genEdGrades = new List<int> { 72, 22, 56, 77 };
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            //Console.WriteLine(compSciGrades.Count);
            //double compSciAvg = Average(compSciGrades);
            //double genEdAvg = Average(genEdGrades);


            //Console.WriteLine($"Comp Sci Average {compSciAvg}\n" +
            //    $"Gen Ed Average {genEdAvg}");
  

            Student stu1 = new Student("Zach", 100, 55);

            Student stu2 = new Student("Samantha", 100, 100);

            students.Add(stu1);
            students.Add(stu2);
            students.Add(new Student("Wong", 100, 100));


            Console.WriteLine(students[2].Name);

            Console.WriteLine("Student Total Average: " + Average(students));
         

        } // Main

        public static double Average(int compSci, int genEd)
        {
            return (compSci + genEd) / 2.0;
        } // Average()

        public static double Average(List<int> list)
        {

            double sum = 0;

            for (
                int i = 0; // starting point
                i < list.Count; // Ending point
                i++ // Increment
                )
            {
                sum += list[i];
                //sum = sum + compSciGrades[i];
            }

            return sum / list.Count;
        } // Average

        public static double Average(List<Student> students)
        {
            double sum = 0;
            for (
               int i = 0; // starting point
               i < students.Count; // Ending point
               i++ // Increment
               )
            {
                sum += students[i].Average();
                //sum = sum + compSciGrades[i];
            }

            return sum / students.Count;
        }

        #region Coments
        public static void ReviewComments()
        {
            // Variables
            // string
            // int
            // float - double - decimial
            // bool

            // Conditions
            //if
            //else if
            // else
            // switch

            // For
            // for
            // while
            // do while
            // foreach

            // operators
            // Logical -
            //    true && true
            //    true || false
            // !
            // Assignment
            // =, +=, -=
            // Math Operators
            // +, -, *, /, %
            // Comparison
            // >, < >=, <=, !=
        }
        #endregion
    }
}

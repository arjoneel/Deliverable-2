using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.STATEMNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take input from user
            //it should be integer

            //only input in string format

            //taking input
            Console.WriteLine("Enter the grade you are expecting to get in ISM-4300");
            string input = Console.ReadLine();

            //converting the input to integer format
            int cnvrtdInput = 0;
            bool isCnvrtd = int.TryParse(input, out cnvrtdInput);

            if (isCnvrtd == false)
            {
                Console.WriteLine("Input is not valid try again.");
            }

            else
            {
                string grade = CalculateGradeFromMarks(cnvrtdInput);

                Console.WriteLine($"Grade would be: {grade}");
            }

            Console.ReadLine();
        }

        private static string CalculateGradeFromMarks(int marks)
        {
            //ifelse 
            //98 - 100
            string grade = "-";
            if (marks >= 98 && marks <= 100)
            {
                grade = "A+";
            }

            else if (marks >= 92 && marks <= 97)
            {
                grade = "A";

            }
            else if (marks >= 90 && marks <= 91)
            {
                grade = "A-";
            }

            else if (marks >= 88 && marks <= 89)
            {
                grade = "B+";
            }

            else if (marks >= 82 && marks <= 87)
            {
                grade = "B";
            }

            else if (marks >= 80 && marks <= 81)
            {
                grade = "B-";
            }

            else if (marks >= 78 && marks <= 79)
            {
                grade = "C+";
            }

            else if (marks >= 72 && marks <= 77)
            {
                grade = "C";
            }

            else if (marks >= 70 && marks <= 71)
            {
                grade = "C-";
            }

            else if (marks >= 68 && marks <= 69)
            {
                grade = "D+";
            }

            else if (marks >= 62 && marks <= 67)
            {
                grade = "D";
            }

            else if (marks >= 60 && marks <= 61)
            {
                grade = "D-";
            }

            else if (marks >= 0 && marks <= 59)
            {
                grade = "E";
            }

            else if (marks <= 0 || marks >= 100)
            {
                grade = "Enter valid Grade.";
            }

            return grade;
        }
    }
}

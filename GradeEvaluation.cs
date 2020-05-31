using System;
using System.Collections.Generic;

namespace evaluategrade
{
    class Program
    {
        //Get input data.
        static double[] GradeInput()
        { 
            System.Console.WriteLine("Enter number of records/grades.");
            int NumberOfRecords=Convert.ToInt32(Console.ReadLine());
            double [] grades = new double[NumberOfRecords];
            for (int index = 0; index<NumberOfRecords; index++)
            {
                System.Console.WriteLine("\n Enter grades :");
                grades[index] = Convert.ToDouble(Console.ReadLine());
            }
            return grades;
        }

        //Average.
        static double CalculateAverage(double[] Grades)
        {
            double sum = 0;
            for (int index = 0; index < Grades.Length; index++)
            {
                sum += Grades[index];
            }
            return sum / Grades.Length;
        }

        //CalculateMax.
        static double CalculateMax(double[] Grades)
        {
            double max = Grades[0];
            foreach(var grade in Grades)
            {
                if (grade > max)
                {
                    max = grade;
                }
            }
            return max;
        }

        //CalculateMin.
        static  double CalculateMin(double[] Grades)
        {
            double min = Grades[0];
            foreach (var grade in Grades)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }
            return min;
        }

        //PrintInfo.
        static  void PrintInfo(double min, double max, double avg)
        {
            System.Console.WriteLine("Min:" + min.ToString());
            System.Console.WriteLine("\nMax:" + max.ToString());
            System.Console.WriteLine("\nAvg:" + avg.ToString());
        }

	//MainFunction.
        static void Main(string[] args)
        {
            Console.WriteLine("--EvaluateGrade--\n");
            double[] grades = GradeInput();
            PrintInfo(CalculateMin(grades),CalculateMax(grades),CalculateAverage(grades));
        }
    }
}

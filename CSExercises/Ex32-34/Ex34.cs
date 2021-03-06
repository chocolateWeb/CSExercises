using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int marks = 0, total = 0, totalSubject1 = 0, totalSubject2 = 0, totalSubject3 = 0, totalSubject4 = 0;
            int[,] student = new int[12, 4]
            {
                {56, 84, 68, 29}, {94, 73, 31, 89}, {41, 63, 36, 90}, {99, 9, 18, 17}, 
                {62, 3, 65, 75},  {40, 96, 53, 23}, {81, 15, 27, 30}, {21, 70, 100, 22}, 
                {88, 50, 13, 12}, {48, 54, 52, 78}, {64, 71, 67, 25}, {16, 93, 46, 72}
            };

            for(int i = 0; i < student.GetLength(0); i++)
            {
                for(int j = 0; j < student.GetLength(1); j++)
                {
                    marks += student[i, j];
                    if (j == 0)
                        totalSubject1 += student[i, j];

                    else if (j == 1)
                        totalSubject2 += student[i, j];

                    else if (j == 2)
                        totalSubject3 += student[i, j];

                    else
                        totalSubject4 += student[i, j];
                }
                Console.WriteLine("Student {0}: {1} marks", i, marks);
                total += marks;
                marks = 0;
            }

            Console.WriteLine("Class Average for Subject 1: {0} marks", totalSubject1 / student.GetLength(0));
            Console.WriteLine("Class Average for Subject 2: {0} marks", totalSubject2 / student.GetLength(0));
            Console.WriteLine("Class Average for Subject 3: {0} marks", totalSubject3 / student.GetLength(0));
            Console.WriteLine("Class Average for Subject 4: {0} marks", totalSubject4 / student.GetLength(0));
            Console.WriteLine("Class Average: {0} marks", total/ (student.GetLength(0) * 4));
        }
    }
}

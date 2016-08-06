using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerranktest12
{
    class Student : Person
    {
        int score;

        int totalNumberOfScore;
        private int[] allTestScores;
        private int[] scores;

        public Student(string firstName, string lastName, int id, int[] scores)
            : base(firstName, lastName, id)
        {
           
            allTestScores = new int[scores.Length];

            for (int i = 0; i < scores.Length; i++)
            {
                allTestScores[i] = scores[i];
            }
        }

        public char calculate()
        {

            char letterGrade = '1' ;

            int total = 0;

            for (int i = 0; i < allTestScores.Length; i++)
            {
                total = total + allTestScores[i];
            }

            totalNumberOfScore = allTestScores.Length;

            int averageScore = total / totalNumberOfScore;

            if (90 <= averageScore && averageScore <= 100)
            {
                letterGrade = 'O';
            }

            if (80 <= averageScore && averageScore < 90)
            {
                letterGrade = 'E';
            }

            if (70 <= averageScore && averageScore < 80)
            {
                letterGrade = 'A';
            }

            if (55 <= averageScore && averageScore < 70)
            {
                letterGrade = 'P';
            }

            if (40 <= averageScore && averageScore < 55)
            {
                letterGrade = 'D';
            }

            if (averageScore < 40)
            {
                letterGrade = 'T';
            }

            return letterGrade;
        }

    }
}

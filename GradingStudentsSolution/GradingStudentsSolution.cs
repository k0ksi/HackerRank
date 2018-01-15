using System;

class Solution
{

    static int[] solve(int[] grades)
    {
        int[] finalGrades = new int[grades.Length];

        for (int i = 0; i < grades.Length; i++)
        {
            int grade = grades[i];

            if(grade < 38)
            {
                finalGrades[i] = grade;
            }
            else
            {
                if(grade % 5 == 0)
                {
                    finalGrades[i] = grade;
                }
                else
                {
                    finalGrades[i] = (grade / 5) * 5 + 5;

                    if(finalGrades[i] - grade >= 3)
                    {
                        finalGrades[i] = grade;
                    }
                }
            }
        }

        return finalGrades;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int grades_i = 0; grades_i < n; grades_i++)
        {
            grades[grades_i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}

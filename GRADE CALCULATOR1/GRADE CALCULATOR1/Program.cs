using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();

        // Convert the input string to an integer
        if (int.TryParse(input, out int grade))
        {
            // Check if the grade is within the valid range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the corresponding letter grade
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                // Display an error message if the grade is not within the valid range
                Console.WriteLine("Error: The grade must be between 0 and 100.");
            }
        }
        else
        {
            // Display an error message if the input is not a valid integer
            Console.WriteLine("Error: Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }
}

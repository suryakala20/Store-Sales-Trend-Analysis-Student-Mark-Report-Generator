using System;
class StudentMarksReport
{
    static void Main()
    {
        Console.WriteLine("Student Marks Report Generator");
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] marks = new int[n];
        Console.WriteLine($"Enter marks for {n} students:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nOriginal Marks:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(marks[i] + " ");
        }
        Console.WriteLine();

        int[] sortedMarks = (int[])marks.Clone(); 
        Array.Sort(sortedMarks);
        Console.WriteLine("\nSorted Marks:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(sortedMarks[i] + " ");
        }
        Console.WriteLine();

        int total = 0;
        int highest = marks[0];
        int lowest = marks[0];
        for (int i = 0; i < n; i++)
        {
            total += marks[i];
            if (marks[i] > highest) highest = marks[i];
            if (marks[i] < lowest) lowest = marks[i];
        }
        Console.WriteLine($"\nTotal Marks: {total}");
        Console.WriteLine($"Highest Mark: {highest}");
        Console.WriteLine($"Lowest Mark: {lowest}");

        Console.Write("\nEnter a mark to search: ");
        int searchMark = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (marks[i] == searchMark)
            {
                found = true;
                break;
            }
        }
        Console.WriteLine(found ? "Mark found." : "Mark not found.");

        int[] backup = (int[])marks.Clone();
        Console.WriteLine("Backup of marks created.");

        int[] newMarks = new int[n];
        Console.WriteLine("\nEnter another set of marks to compare:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Student {i + 1}: ");
            newMarks[i] = int.Parse(Console.ReadLine());
        }
        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            if (marks[i] != newMarks[i])
            {
                equal = false;
                break;
            }
        }
        Console.WriteLine(equal ? "Both marks sets are identical." : "Marks sets are not identical.");
    }
}

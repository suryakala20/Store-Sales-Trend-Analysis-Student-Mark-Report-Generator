using System;
class StoreSalesAnalysis
{
    static void Main()
    {
        Console.WriteLine("Store Sales Trend Analysis");
        int days = 10; 
        int[] sales = new int[days];
        Console.WriteLine($"Enter sales for {days} days:");
        for (int i = 0; i < days; i++)
        {
            Console.Write($"Day {i + 1}: ");
            sales[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nOriginal Sales Data:");
        for (int i = 0; i < days; i++)
        {
            Console.Write(sales[i] + " ");
        }
        Console.WriteLine();

        int[] sortedSales = (int[])sales.Clone();
        Array.Sort(sortedSales);
        Console.WriteLine("\nSorted Sales Data:");
        for (int i = 0; i < days; i++)
        {
            Console.Write(sortedSales[i] + " ");
        }
        Console.WriteLine();

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];
        for (int i = 0; i < days; i++)
        {
            total += sales[i];
            if (sales[i] > highest) highest = sales[i];
            if (sales[i] < lowest) lowest = sales[i];
        }
        Console.WriteLine($"\nTotal Sales: {total}");
        Console.WriteLine($"Highest Sale: {highest}");
        Console.WriteLine($"Lowest Sale: {lowest}");
        Console.Write("\nEnter a sales value to search: ");
        int searchValue = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < days; i++)
        {
            if (sales[i] == searchValue)
            {
                found = true;
                break;
            }
        }
        Console.WriteLine(found ? "Sales value exists." : "Sales value not found.");

        int[] backup = (int[])sales.Clone();
        Console.WriteLine("Backup of sales data created.");

        int[] newSales = new int[days];
        Console.WriteLine("\nEnter another set of sales data to compare:");
        for (int i = 0; i < days; i++)
        {
            Console.Write($"Day {i + 1}: ");
            newSales[i] = int.Parse(Console.ReadLine());
        }
        bool equal = true;
        for (int i = 0; i < days; i++)
        {
            if (sales[i] != newSales[i])
            {
                equal = false;
                break;
            }
        }
        Console.WriteLine(equal ? "Both sales data sets are equal." : "Sales data sets are not equal.");
    }
}

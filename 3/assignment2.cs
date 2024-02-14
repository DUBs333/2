using System;

class Program
{
    static void Main()
    {
        // Taking user input
        Console.Write("Please enter a real number: ");
        double x;
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
            return;
        }

        // Defining the intervals
        double[,] intervals = {
            { 2, 3 },
            { 0, 1 },
            { -10, -2 }
        };

        // Testing the membership 
        bool belongsToAnyInterval = false;
        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            if (x >= intervals[i, 0] && x <= intervals[i, 1])
            {
                belongsToAnyInterval = true;
                break;
            }
        }

        // Displaying the result 
        if (belongsToAnyInterval)
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}

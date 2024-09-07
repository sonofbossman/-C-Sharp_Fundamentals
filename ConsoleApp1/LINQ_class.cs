public class LinqClass{

    public void Run()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Query to get even numbers
        Console.WriteLine("Even Numbers:");
        var evenNumbers = numbers.Where(x => (x % 2) == 0);
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n\nOdd Numbers:");
        // Filter out odd numbers
        var oddNumbers = numbers.Where(x => (x % 2) == 1);
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }

        // Multiply the even numbers by 3
        Console.WriteLine("\n\nMultiply Even Numbers by 3:");
        var mulEvenNumbers = numbers
            .Where(x => (x % 2) == 0)
            .Select(x => x*3);
        foreach (var number in mulEvenNumbers)
        {
            Console.WriteLine($"{number}");
        }

        // Sort them in ascending order
        Console.WriteLine("\n\nSorting Numbers in Ascending Order:");
        var sortNumbers = numbers
            .Where(x => (x % 2) == 0)
            .Select(x => x*3)
            .OrderBy(x => x);
        foreach (var number in sortNumbers)
        {
            Console.WriteLine($"{number}");
        }

        // Sort them in descending order
        Console.WriteLine("\n\nSorting Numbers in Descending Order:");
        var sortNumbersDesc = numbers
            .Where(x => (x % 2) == 0)
            .Select(x => x*3)
            .OrderByDescending(x => x);
        foreach (var number in sortNumbersDesc)
        {
            Console.WriteLine($"{number}");
        }

        // Display the top 3 highest even numbers
        Console.WriteLine("\n\nDisplay the top 3 highest even numbers:");
        var highestNumbers = numbers
            .Where(x => (x % 2) == 0)
            .Select(x => x*3)
            .OrderByDescending(x => x)
            .Take(3);
        foreach (var number in highestNumbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}
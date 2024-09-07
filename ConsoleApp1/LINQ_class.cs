public class LinqClass{

    public void Run()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Query to get even numbers
        var evenNumbers = numbers.Select(x => (double)x + 1);
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
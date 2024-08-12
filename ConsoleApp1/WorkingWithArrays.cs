using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LearningArrays
{
    public void Run()
    {
        // double[] arrayDouble = new double[6]
        // Read in the number of values to enter
        Console.Write("Enter the number of values to average: ");
        int numElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        string val;
            

        // Now declare an array of that size
        double[] doubleArrays = new double[numElements];
        for (int i = 0; i < numElements; i++)
        {
            // Prompt the user for another double
            Console.Write("enter double #" + (i+1) + ": ");
            val = Console.ReadLine();
            Console.WriteLine();
            double value;

            if (Double.TryParse(val, out value))
            {
                // Add this to the array using bracket notation.
                doubleArrays[i] = value;
            }
            else
            {
                for (;;)
                {
                    // Prompt the user for another input.
                    Console.WriteLine($"Attempted to input '{val}' for double #{i+1}!");
                    Console.Write("re-enter double #" + (i+1) + ": ");
                    val = Console.ReadLine();
                    Console.WriteLine();

                    if (Double.TryParse(val, out value))
                    {
                        // Add this to the array using bracket notation.
                        doubleArrays[i] = value;
                        break;
                    }
                }
                    
            }
        }
            
        // Compute the sum of array values
        double sum = 0;
        for (int i = 0; i < doubleArrays.Length; i++)
        {
            sum += doubleArrays[i];
        }

        // Now calculate the average
        double average = sum / doubleArrays.Length;

        // Output the result
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Length of Array: " + doubleArrays.Length);
        Console.WriteLine("Average: " + average);

        //double[] slicedArray = doubleArrays[1..4];

        // Console.WriteLine(string.Join(", ", slicedArray));
        // Console.WriteLine(doubleArrays[^1]);
    }
}
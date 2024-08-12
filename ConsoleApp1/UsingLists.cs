using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LearningLists
{
    public void Run()
    {
        // Create a list of integers and initialize it.
        List<int> myList = new List<int>{1, 2, 3, 4, 5};

        // Add the value 6 to the list.
        myList.Add(6);

        // Add the values 7, 8 to the list.
        int[] newValues = new int[]{7, 8};
        myList.AddRange(newValues);

        // Remove the value 4 from the list.
        myList.Remove(4);

        // Print the third element in the list.
        Console.WriteLine("Third Element: " + myList[2]);

        //  Iterate through the list using a foreach loop and print each element.
        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }
        
    }
}
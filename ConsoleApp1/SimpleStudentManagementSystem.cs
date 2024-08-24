/*

Task Overview:

Title: Simple Student Grade Management Using List
-------
You will create a simple console application that allows a user to manage a list of student names and their corresponding grades.
The user should be able to:

1. Add a new student and their grade.
2. Remove a student by name.
3. Update a student's grade.
4. Display all students and their grades.
5. Display the average grade.
6. Exit the program.
*/

using System.Diagnostics.CodeAnalysis;
namespace MyNamespace
{
    public class StudentManagementSystem
    {
        public void Run()
        {
            List<string> studentNames = new List<string>();
            List<double> studentGrades = new List<double>();
            List<string> options = new List<string>();
            options.AddRange(new string[] {"1", "2", "3", "4", "5", "6"});
            string welcomeMsg = @"
            Welcome to the Student Management Application!
            
            Select the action to perform respectively: 
                1. Add a new student and their grade.
                2. Remove a student by name.
                3. Update a student's grade.
                4. Display all students and their grades.
                5. Display the average grade.
                6. Exit the program.
            ";


            while (true)
            {
                Console.WriteLine(welcomeMsg + "\n");
                Console.Write("Select option: ");
                string? option = Console.ReadLine();
                Console.WriteLine();
                while (option == null || !(options.Contains(option)))
                {
                    Console.WriteLine("Invalid option!");
                    Console.Write("Select a valid option: ");
                    option = Console.ReadLine();
                    Console.WriteLine();
                }

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\n**** Add Record Menu ****\n\n");
                        
                        // Handle Name Input from user
                        Console.Write("Enter student name: ");
                        string? name = Console.ReadLine();
                        Console.WriteLine();
                        while (name == null || name.Length == 0 || name.Trim() == "")
                        {
                            Console.WriteLine("Invalid Name!");
                            Console.Write("Input a valid name: ");
                            name = Console.ReadLine();
                            Console.WriteLine();
                        }

                        // Handle grade input from user
                        Console.Write("Enter student grade: ");
                        string? getGrade = Console.ReadLine();
                        double grade;
                        while (!(double.TryParse(getGrade, out grade)))
                        {
                            Console.WriteLine("Invalid Grade!");
                            Console.Write("Input a valid grade: ");
                            getGrade = Console.ReadLine();
                            Console.WriteLine();
                        }

                        // Add the record to the list and inform user about this action.
                        studentNames.Add(name);
                        studentGrades.Add(grade);
                        if (studentNames.Contains(name) && studentGrades.Contains(grade))
                        {
                            Console.WriteLine("1 new record added!");
                        }
                        break;
                        
                    case "2":
                        // Accept the name to remove.
                        Console.WriteLine("\n**** Remove Student by Name Menu ****\n\n");
                        Console.Write("Enter student name: ");
                        name = Console.ReadLine();
                        Console.WriteLine();

                        // Check for a valid name and if the name is contained in the DB.
                        if (name == null || name.Length == 0 || name.Trim() == "" || !(studentNames.Contains(name)))
                        {
                            Console.WriteLine("Invalid Name! Try again with a valid name.");
                        }
                        else
                        {
                            // Proceed to remove record if it's a valid name and name is contained in DB.
                            int studentPos = studentNames.IndexOf(name);
                            studentNames.RemoveAt(studentPos);
                            studentGrades.RemoveAt(studentPos);
    
                            // Inform the user of the action.
                            Console.WriteLine("1 record deleted!");

                        }
                        break;
                    
                    case "3":
                        // Accept the name of the student whose grade is to be updated.
                        Console.WriteLine("\n**** Update Grade Menu ****\n\n");
                        Console.Write("Enter student name: ");
                        name = Console.ReadLine();
                        Console.WriteLine();

                        // Check for a valid name and if the name is contained in the DB.
                        if (name == null || name.Length == 0 || name.Trim() == "" || !(studentNames.Contains(name)))
                        {
                            Console.WriteLine("Invalid Name! Try again with a valid name.");
                        }
                        else
                        {
                            // Proceed to accept the new grade
                            Console.Write("Enter new grade: ");
                            getGrade = Console.ReadLine();
                            while (!(double.TryParse(getGrade, out grade)))
                            {
                                Console.WriteLine("Invalid Grade!");
                                Console.Write("Input a valid grade: ");
                                getGrade = Console.ReadLine();
                                Console.WriteLine();
                            }

                            // Update the grade 
                            int studentPos = studentNames.IndexOf(name);
                            studentGrades[studentPos] = grade;

                            // Inform the user of the action.
                            Console.WriteLine("1 record updated!");
                        }

                        break;
                    
                    case "4":
                        Console.WriteLine("\n**** All students and their grades ****\n\n");
                        if (studentNames.Count == 0)
                        {
                            Console.WriteLine("No Record Found!");
                        }
                        else
                        {
                            for (int i = 0; i < studentNames.Count; i++)
                            {
                                Console.WriteLine($"{i+1}. Name: {studentNames[i]} \t Grade: {studentGrades[i]}");
                            }
                        }
                        
                        break;
                    
                    case "5":
                        Console.WriteLine("\n**** Display Average Grade ****\n\n");
                        if (studentNames.Count == 0)
                        {
                            Console.WriteLine("No record found, cannot compute average!");
                        }
                        else
                        {
                            double sum = 0;
                            foreach (double grd in studentGrades)
                            {
                                sum += grd;
                            }
                            double average = (sum / studentGrades.Count);
                            Console.WriteLine("Average Grade: " + average);
                        }
                        
                        break;
                    
                    case "6":
                        Console.WriteLine("Exiting the program...");
                        break;
                }
                if (option == "6")
                {
                    break;
                }

            }
        }
    }
}
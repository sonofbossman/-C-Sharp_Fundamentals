/*

Classwork
Try creating a small application using dictionaries:

1. Task:

A. Create a dictionary that stores a list of employees and their department.
B. Implement functionalities to:
   # Add a new employee with their department.
   # Remove an employee by name.
   # Update an employee’s department.
   # Display all employees and their departments.
   # Search for an employee to see if they exist in the dictionary and display their department.

2. Questions:

How would you handle a scenario where a key (employee name) does not exist in the dictionary?
How can you ensure that adding a new employee does not overwrite an existing one?

*/

using System.Diagnostics.Tracing;

public class EMS
{
    Dictionary<string, string> employees = new Dictionary<string, string>();
    public void Run()
    {
        List<string> options = new List<string>();
        options.AddRange(new string[] {"1", "2", "3", "4", "5", "6"});
        string welcomeMsg = @"
        Welcome to the Employee Management System App!
            
            Select the action to perform respectively: 
                1. Add a new employee with their department.
                2. Remove an employee by name.
                3. Update an employee’s department.
                4. Display all employees and their departments.
                5. Search for an employee to see if they exist in the dictionary and display their department.
                6. Exit the program.
            ";
        bool running = true;
        
        while (running)
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
                    Console.WriteLine("\n**** Add New Employee ****\n\n");
                        
                    // Handle Name Input from user
                    Console.Write("Enter employee's name: ");
                    string? name = Console.ReadLine();
                    Console.WriteLine();
                    while (name == null || name.Length == 0 || name.Trim() == "")
                    {
                        Console.WriteLine("Invalid Name!");
                        Console.Write("Input a valid name: ");
                        name = Console.ReadLine();
                        Console.WriteLine();
                    }

                    // Handle Department Input from user
                    Console.Write("Enter employee's department: ");
                    string? department = Console.ReadLine();
                    Console.WriteLine();
                    while (department == null || department.Length == 0 || department.Trim() == "")
                    {
                        Console.WriteLine("Invalid Department!");
                        Console.Write("Input a valid department: ");
                        department = Console.ReadLine();
                        Console.WriteLine();
                    }

                    // Add the record and inform user of this action.
                    employees.Add(name,  department);
                    if (employees.ContainsKey(name))
                    {
                        Console.WriteLine("1 new record added!\n\n");
                    }
                    Console.WriteLine("------------------------------------------------------");
                        
                    break;
            
                case "2":
                    
                    // Accept the name to remove.
                    Console.WriteLine("\n**** Delete Employee Record ****\n\n");
                    Console.Write("Enter employee's name: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                    // Check for a valid name and if the name is contained in the DB.
                    if (name == null || name.Length == 0 || name.Trim() == "" || !(employees.ContainsKey(name)))
                    {
                        Console.WriteLine("Invalid Name! Try again with a valid name.");
                    }
                    else
                    {
                        // Proceed to remove record if it's a valid name and name is contained in DB.
                        employees.Remove(name);
                        // Inform the user of the action.
                        Console.WriteLine("1 record deleted!\n\n");
                    }
                    Console.WriteLine("------------------------------------------------------");
                    break;
                
                case "3":
                    // Update Employee Record
                    Console.WriteLine("\n**** Update Employee Record ****\n\n");
                    Console.Write("Enter employee's name: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                    // Check for a valid name and if the name is contained in the DB.
                    if (name == null || name.Length == 0 || name.Trim() == "" || !(employees.ContainsKey(name)))
                    {
                        Console.WriteLine("Invalid Name! Try again with a valid name.");
                    }
                    else
                    {
                        // Accept the new department
                        Console.Write("Enter employee's new department: ");
                        department = Console.ReadLine();
                        Console.WriteLine();
                        while (department == null || department.Length == 0 || department.Trim() == "")
                        {
                            Console.WriteLine("Invalid Department!");
                            Console.Write("Input a valid department: ");
                            department = Console.ReadLine();
                            Console.WriteLine();
                        }

                        // Update and inform user
                        employees[name] = department;
                        Console.WriteLine("1 record updated!\n\n");
                    }
                    Console.WriteLine("------------------------------------------------------");
                    break;
                
                case "4":
                    Console.WriteLine("\n**** All Employees and their Departments ****\n\n");
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No Record Found!\n\n\n");
                    }
                    else
                    {
                        foreach (KeyValuePair<string, string> employee in employees)
                        {
                            Console.WriteLine($"Name: {employee.Key.PadRight(8)} Department: {employee.Value}");
                        }
                    }
                    Console.WriteLine("------------------------------------------------------");
                    break;
                
                case "5":
                    Console.WriteLine("\n**** Search Employee by Name ****\n\n");
                    Console.Write("Enter employee's name: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                    if (name == null || name.Length == 0 || name.Trim() == "" || !(employees.ContainsKey(name)))
                    {
                        Console.WriteLine($"Employee '{name}' does not exist!");  
                    }
                    else
                    {
                        Console.WriteLine($"Name: {name.PadRight(8)} Department: {employees[name]}");
                    }
                    Console.WriteLine("------------------------------------------------------");
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


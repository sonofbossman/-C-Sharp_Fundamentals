using System;
using System.Collections.Generic;
using System.Linq;

/*
Classwork
Task:

1. Create a List of employees, each with a name, department, and salary.
2. Use LINQ to:
    a. Find all employees in a particular department.
    b. Find the employee with the highest salary.
    c. Sort the employees by salary in ascending order.
    d. Group employees by department and display each group.
*/

public class Employee
{
    public string? Name { get; set; }
    public string? Department { get; set; }
    public double Salary { get; set; }

    public void Run()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Tolani", Department = "HR", Salary = 55000 },
            new Employee { Name = "Tunde", Department = "IT", Salary = 69000 },
            new Employee { Name = "Segun", Department = "Marketing", Salary = 55000 },
            new Employee { Name = "Olamipe", Department = "Marketing", Salary = 55000 },
            new Employee { Name = "Chizoba", Department = "HR", Salary = 59000 },
            new Employee { Name = "Charlie", Department = "Finance", Salary = 59000 },
            new Employee { Name = "Kikelomo", Department = "Finance", Salary = 59000 },
            new Employee { Name = "Shadiat", Department = "Card Management", Salary = 59000 },
            new Employee { Name = "Mosope", Department = "Card Management", Salary = 51000 },
            new Employee { Name = "Anthony", Department = "Treasury", Salary = 69500 },
            new Employee { Name = "Ezra", Department = "IT", Salary = 50000 },
            new Employee { Name = "Eleniyan", Department = "IT", Salary = 69000 },
            new Employee { Name = "Ebube", Department = "IT", Salary = 65900 }
        };

        // a. Find all employees in a particular department.
        var emp_by_dept = employees.Where(e => e.Department == "IT");
        Console.WriteLine("Employees in a particular department:\n");
        foreach (var emp in emp_by_dept)
        {
            Console.WriteLine($"Name: {emp.Name}, \tDepartment: {emp.Department}, \tSalary: {emp.Salary}");
        };

        // b. Find the employee with the highest salary.
        Console.WriteLine("\n\nEmployee with the highest salary:\n"); 
        var maxSalaryEmp = employees.MaxBy(e => e.Salary);
        if (maxSalaryEmp != null)
        {
            Console.WriteLine($"Name: {maxSalaryEmp.Name}, \tDepartment: {maxSalaryEmp.Department}, \tSalary: {maxSalaryEmp.Salary}");
        } 
        else
        {
            Console.WriteLine("No Employee Found!");
        }

        // c. Sort the employees by salary in ascending order.
        Console.WriteLine("\n\nSort the employees by salary in ascending order:\n");
        var sortBySalary = employees.OrderBy(e => e.Salary);
        foreach (var emp in sortBySalary)
        {
            Console.WriteLine($"Name: {emp.Name}, \tDepartment: {emp.Department}, \tSalary: {emp.Salary}");
        }

        // d. Group employees by department and display each group.
        Console.WriteLine("\n\nGroup employees by department:\n");
        var groupByDept = employees.GroupBy(e => e.Department);
        foreach (var group in groupByDept)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach(var emp in group)
            {
                Console.WriteLine($"Name: {emp.Name}, \tSalary: {emp.Salary}");
            }
            Console.WriteLine("");
        }

    }
}
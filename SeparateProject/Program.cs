using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var customers = DataSeeder.GetCustomers();
        var products = DataSeeder.GetProducts();
        var employees = DataSeeder.GetEmployees();

        // Example 1: Filter employees
        var highSalary = employees.Where(e => e.Salary > 60000);

        Console.WriteLine("High Salary Employees:");
        foreach (var emp in highSalary)
        {
            Console.WriteLine(emp.Name);
        }

        // Example 2: Total revenue
        var totalRevenue = customers
            .SelectMany(c => c.Orders)
            .Sum(o => o.TotalAmount);

        Console.WriteLine($"Total Revenue: {totalRevenue}");

        // Example 3: Customer with big spending
        var bigCustomers = customers
            .Where(c => c.Orders.Sum(o => o.TotalAmount) > 2000);

        Console.WriteLine("Big Customers:");
        foreach (var c in bigCustomers)
        {
            Console.WriteLine(c.Name);
        }
    }
}
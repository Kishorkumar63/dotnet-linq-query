using System;
using System.Linq;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main()
    {
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<Program>();

        var customers = DataSeeder.GetCustomers();
        var products = DataSeeder.GetProducts();
        var employees = DataSeeder.GetEmployees();

        // Example 1: Filter employees
        var highSalary = employees.Where(e => e.Salary > 60000);

        logger.LogInformation("High Salary Employees:");
        foreach (var emp in highSalary)
        {
            logger.LogInformation("{Name}", emp.Name);
        }

        // Example 2: Total revenue
        var totalRevenue = customers
            .SelectMany(c => c.Orders)
            .Sum(o => o.TotalAmount);

        logger.LogInformation("Total Revenue: {TotalRevenue}", totalRevenue);

        // Example 3: Customer with big spending
        var bigCustomers = customers
            .Where(c => c.Orders.Sum(o => o.TotalAmount) > 2000);

        logger.LogInformation("Big Customers:");
        foreach (var c in bigCustomers)
        {
            logger.LogInformation("{Name}", c.Name);
        }
    }
}
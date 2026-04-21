using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var customers = DataSeeder.GetCustomers();
        var products = DataSeeder.GetProducts();
        var employees = DataSeeder.GetEmployees();

        // // Example 1: Filter employees
        // var highSalary = employees.Where(e => e.Salary > 60000);

        // Console.WriteLine("High Salary Employees:");
        // foreach (var emp in highSalary)
        // {
        //     Console.WriteLine(emp.Name);
        // }

        // // Example 2: Total revenue
        // var totalRevenue = customers
        //     .SelectMany(c => c.Orders)
        //     .Sum(o => o.TotalAmount);

        // Console.WriteLine($"Total Revenue: {totalRevenue}");

        // // Example 3: Customer with big spending
        // var bigCustomers = customers
        //     .Where(c => c.Orders.Sum(o => o.TotalAmount) > 2000);

        // Console.WriteLine("Big Customers:");
        // foreach (var c in bigCustomers)
        // {
        //     Console.WriteLine(c.Name);
        // }


//         // Order employees by name
// var linq=employees.OrderBy(e=>e.Name);
// foreach(var emp in linq){
//     Console.WriteLine(emp.Name);    

//     }

//order employees by thenby salary
// var linq2=employees.OrderBy(e=>e.Name).ThenBy(e=>e.Salary);
// foreach(var emp in linq2){
//     Console.WriteLine($"{emp.Name} - {emp.Salary}");        



    // }

    // order by descending
    // var linq3=employees.OrderByDescending(e=>e.Salary);
    // foreach(var emp in linq3){
    //     Console.WriteLine($"{emp.Name} - {emp.Salary}");    
    
    // }

    // Except example

// var list1 = new List<int> { 1, 2, 3, 4 };
// var list2 = new List<int> { 3, 4, 5 };

// var result = list1.Except(list2);

// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }  

// employees.First();
// employees.Last();
// employees.ElementAt(2);
// employees.FirstOrDefault();
// employees.LastOrDefault();

// employees.First(e => e.Department == "IT");
// employees.FirstOrDefault(e => e.Salary > 70000);
// employees.Last(e => e.Department == "HR");
// employees.LastOrDefault(e => e.Name == "Unknown");
// sngle methods only allow unique values
// employees.Single(e => e.Name == "David");
// employees.SingleOrDefault(e => e.Name == "Unknown");

    }
}
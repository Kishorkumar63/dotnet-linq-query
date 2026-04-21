public static class DataSeeder
{
    public static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Kishor",
                City = "Chennai",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 101,
                        CustomerId = 1,
                        OrderDate = DateTime.Now.AddDays(-10),
                        TotalAmount = 1500,
                        Items = new List<OrderItem>
                        {
                            new OrderItem { Id = 1, ProductId = 1, Quantity = 2, Price = 500 },
                            new OrderItem { Id = 2, ProductId = 2, Quantity = 1, Price = 500 }
                        }
                    }
                }
            },
            new Customer
            {
                Id = 2,
                Name = "Arun",
                City = "Bangalore",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 102,
                        CustomerId = 2,
                        OrderDate = DateTime.Now.AddDays(-5),
                        TotalAmount = 3000,
                        Items = new List<OrderItem>
                        {
                            new OrderItem { Id = 3, ProductId = 3, Quantity = 3, Price = 1000 }
                        }
                    }
                }
            }
        };
    }

    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 500 },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 500 },
            new Product { Id = 3, Name = "Phone", Category = "Electronics", Price = 1000 },
            new Product { Id = 4, Name = "Chair", Category = "Furniture", Price = 2000 }
        };
    }

    public static List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Sara", Department = "HR", Salary = 50000 },
            new Employee { Id = 3, Name = "David", Department = "IT", Salary = 80000 },
             new Employee { Id = 4, Name = "John", Department = "HR", Salary = 55000 }, // duplicate name
    new Employee { Id = 5, Name = "Mike", Department = "IT", Salary = 60000 }  // duplicate salary
        };
    }
}

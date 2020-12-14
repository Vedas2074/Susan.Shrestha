using System.Collections.Generic;
namespace EmployeeManagement.Models{

public class Employee{
    public int Id { get;set;}
    public string FirstName { get;set;}
    public string LastName { get; set;}
    public string Address { get; set;}
    public byte? Age { get; set;}
    public float? Salary { get; set;}
     
     public static List<Employee> GetEmployee()
     {
     Employee employee1 = new Employee()
            {
                Id =1,
                FirstName = "Susan",
                LastName ="Shrestha", 
                Address = "Ktm",
                Age = 21,
                Salary = 1546

            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Bjem",
                LastName ="Stha", 
                Address ="Bkt",
                Age = 32,
                Salary = 16511

            };
            List<Employee> employees =new List<Employee>(){employee1,employee2};
            return employees;
     }
}
}
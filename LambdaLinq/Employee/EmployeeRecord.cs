/*1. Given a collection of objects representing employees with properties like Name, Department, and JoiningDate, 
use a lambda expression to filter employees who joined in the last six months and are from a specific department.*/

using System;
using System.Collections.Generic;

namespace Employee
{
    public class EmployeeRecords
    {
        public static void FilterRecords()
        {
            List<Employees> employees = new List<Employees>
        {
            new Employees { Name="ABC", Department="IT", Date=DateTime.Now.AddMonths(-3) },
            new Employees { Name="DEF", Department="HR", Date=DateTime.Now.AddMonths(-4) },
            new Employees { Name="GHI", Department="IT", Date=DateTime.Now.AddMonths(-9) },
            new Employees { Name="JKL", Department="IT", Date=DateTime.Now.AddMonths(-2) }
        };

            Service service = new Service();
            var result = service.GetEmployee(employees, "IT");
            Console.WriteLine("Employees joined in last 6 months (IT) :");
            foreach (var emp in result)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}
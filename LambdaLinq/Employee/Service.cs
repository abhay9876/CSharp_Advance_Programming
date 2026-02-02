using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee
{
    public class Service
    {
        public List<Employees> GetEmployee(List<Employees> emp, string dept)
        {
            DateTime GivenDate = DateTime.Now.AddMonths(-6);

            var filterEmp = emp.Where(n => n.Department == dept && n.Date >= GivenDate).ToList();
            return filterEmp;
        }
    }
}
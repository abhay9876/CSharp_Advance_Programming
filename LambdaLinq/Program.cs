using System;
using Employee;
using SortList;
using Products;

namespace LambdaLinq
{
    class Program
    {
        public static void Main()
        {
            EmployeeRecords.FilterRecords();

            Sorting.GetSort();

            ManageProducts.GroupProducts();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Roman", "Ustymenko");
            Console.WriteLine($"Name: {employee.name} {employee.surname}\nExp: {employee.experience}\nPosition: {employee.position}\nTax: {employee.tax}\nSalary: {employee.Salary}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpNo = 0; 
                employee.EmpName = "Rani"; 
                employee.Salary = 10000.0;
                employee.DeptNo = 0; 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
              

            }

            Console.ReadLine();
        }
    }
}
 

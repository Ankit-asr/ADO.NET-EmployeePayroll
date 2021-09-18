using System;

namespace ADOEmployee_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To ADO.NET Employee Payroll Service");
            EmployeePayRollOperation emp = new EmployeePayRollOperation();
            emp.GetAllEmployeeDetails();
        }
    }
}

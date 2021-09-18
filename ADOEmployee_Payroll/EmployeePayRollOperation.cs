using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADOEmployee_Payroll
{
    class EmployeePayRollOperation
    {
        public int choice;
        public static string connectionString = "Data Source=(LocalDb)\\localdb;Initial Catalog=EmployeePayroll;Integrated Security=True";
        public static List<Employee> EmpList = new List<Employee>();
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public List<Employee> GetAllEmployeeDetails()
        {
            SqlCommand com = new SqlCommand("spGetAllEmployeeDetails", sqlConnection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            sqlConnection.Open();
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                EmpList.Add(

                    new Employee
                    {
                        ID = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        StartDate = Convert.ToString(dr["StartDate"]),
                        Gender = Convert.ToChar(dr["Gender"]),
                        EmployeeDepartment = Convert.ToString(dr["EmployeeDepartment"]),
                        EmployeePhoneNumber = Convert.ToDouble(dr["EmployeePhoneNumber"]),
                        BasicPay = Convert.ToDouble(dr["BasicPay"]),
                        Deduction = Convert.ToDouble(dr["Deduction"]),
                        TaxabalePay = Convert.ToDouble(dr["TaxablePay"]),
                        IncomeTax = Convert.ToDouble(dr["IncomeTax"]),
                        NetPay = Convert.ToInt32(dr["NetPay"]),

                    });

            }
            sqlConnection.Close();
            return EmpList;
        }

    }
}
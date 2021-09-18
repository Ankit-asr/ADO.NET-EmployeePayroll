create DataBase EmployeePayroll
use EmployeePayroll

Create Table employee_payroll (
Id int not null identity (1,1)primary key,
Name varchar(20),
Salary varchar(20),
StartDate varchar(20)
)

insert into employee_payroll (Name,Salary,StartDate)values ('Ankit','50000','2021-05-20')
insert into employee_payroll (Name,Salary,StartDate)values ('Karan','30000','2021-02-20')
insert into employee_payroll (Name,Salary,StartDate)values ('Priya','45000','2021-03-20')
insert into employee_payroll (Name,Salary,StartDate)values ('Priyanka','60000','2021-07-20')
select * from employee_payroll

Alter table employee_payroll
add Gender char(1)

Update employee_payroll 
set Gender='M' where Name='Ankit' or Name='Karan'
Update employee_payroll 
set Gender='F' where Name='Priyanka' or Name='Priya'

Alter table employee_payroll
add BasicPay float,Deduction float,TaxablePay float, IncomeTax float,NetPay float;

Alter table employee_payroll
add EmployeePhoneNumber varchar(20),EmployeeDepartment varchar(20)

select * from employee_payroll

Update employee_payroll 
set EmployeePhoneNumber='9450172185',EmployeeDepartment='Programming',BasicPay=50000,Deduction=3000,TaxablePay=2000,IncomeTax=0,NetPay=45000
where name='Ankit';

Update employee_payroll 
set EmployeePhoneNumber='9045673829',EmployeeDepartment='Teaching',BasicPay=60000,Deduction=3000,TaxablePay=2000,IncomeTax=0,NetPay=55000
where name='Karan';

Update employee_payroll 
set EmployeePhoneNumber='7890657890',EmployeeDepartment='Engineer',BasicPay=30000,Deduction=3000,TaxablePay=2000,IncomeTax=0,NetPay=25000
where name='Priya';

Update employee_payroll 
set EmployeePhoneNumber='6235467890',EmployeeDepartment='Manager',BasicPay=70000,Deduction=3000,TaxablePay=2000,IncomeTax=0,NetPay=65000
where name='Priyanka';

select * from employee_payroll


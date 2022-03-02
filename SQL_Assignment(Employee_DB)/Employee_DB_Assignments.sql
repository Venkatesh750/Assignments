create database ORG;
use ORG;
create table Employee(Employee_ID int not null primary key identity(1,1), First_Name varchar(25), Last_Name varchar(25), Salary int, Joining_Date varchar(50), Department varchar(25));
select * from Employee;
insert into Employee(First_Name, Last_Name, Salary, Joining_Date, Department) values ('Monika', 'Arora', 100000, '14–02–20 09.00.00',  'HR'),('Niharika', 'Verma', 80000, '14–06–11 09.00.00',  'Admin'), ('Vishal', 'Singhal', 300000, '14–02–20 09.00.00',  'HR'), ('Amitabh', 'Singh', 500000, '14–02–20 09.00.00',  'Admin'), ('Vivek', 'Bhati', 500000, '14–06–11 09.00.00',  'Admin'), ('Vipul', 'Diwan', 200000, '14–06–11 09.00.00',  'Account'), ('Satish', 'Kumar', 75000, '14–01–20 09.00.00',  'Account'), ('Geetika', 'Chauhan', 90000, '14–04–11 09.00.00',  'Admin');
drop table Employee;
create table Bonus(Employee_Ref_ID int, Bonus_Amount int, Bonus_Date varchar(40), Foreign key(Employee_Ref_ID) References Employee(Employee_ID));
select * from Bonus;
insert into Bonus(Employee_Ref_ID, Bonus_Amount, Bonus_Date) values (1, 5000, '16–02–20'), (2, 3000, '16–06–11'), (3, 4000, '16–02–20'), (1, 4500, '16–02–20'), (2, 3500, '16–06–11');
create table Title(Employee_Ref_ID int, Employee_Title varchar(30), Affected_From varchar(30) Foreign key(Employee_Ref_ID) References Employee(Employee_ID));
select * from Title;
insert into Title(Employee_Ref_ID, Employee_Title, Affected_From) values (1, 'Manager', '2016–02–20 00:00:00'), (2, 'Executive', '2016–06–11 00:00:00'), (8, 'Executive', '2016–06–11 00:00:00'),(5, 'Manager', '2016–06–11 00:00:00'),(4, 'Asst. Manager', '2016–06–11 00:00:00'),(7, 'Executive', '2016–06–11 00:00:00'),(6, 'Lead', '2016–06–11 00:00:00'),(3, 'Lead', '2016–06–11 00:00:00');

--Q-1. Write an SQL query to fetch “FIRST_NAME” from  Employee table using the alias name as  <EMPLOYEE_NAME>.
 select First_Name as Employee_Name from Employee;
 
--Q-2. Write an SQL query to fetch “FIRST_NAME” from  EMPLOYEE table in upper case. 
select UPPER(First_Name) from Employee;

--Q-3. Write an SQL query to fetch unique values of  DEPARTMENT from EMPLOYEE table. 
select distinct Department from Employee;

--Q-5. Write an SQL query to find the position of the  alphabet (‘a’) in the first name column ‘Amitabh’ from  EMPLOYEE table. 
--select INSTR(First_Name, Binary 'a') from Employee where First_Name = 'Amitabh';

--Q-6. Write an SQL query to print the FIRST_NAME from  EMPLOYEE table after removing white spaces from the right side. 
select RTRIM(First_Name) from Employee;

--Q-7. Write an SQL query to print the DEPARTMENT from  EMPLOYEE table after removing white spaces from the  left side. 
select LTRIM(Department) from Employee;

--Q-8. Write an SQL query that fetches the unique values of  DEPARTMENT from EMPLOYEE table and prints its  length. 
select distinct len(Department) from Employee;

--Q-9. Write an SQL query to print the FIRST_NAME from  EMPLOYEE table after replacing ‘a’ with ‘A’. 
select REPLACE(First_Name, 'a','A') from Employee;

--Q-10. Write an SQL query to print the FIRST_NAME and  LAST_NAME from EMPLOYEE table into a single column COMPLETE_NAME. A space char should separate them.
--select concat(First_Name,'',Last_Name) as Complete_Name from Employee;

--Q-11. Write an SQL query to print all EMPLOYEE details  from the EMPLOYEE table order by FIRST_NAME  Ascending. 
select * from Employee order by First_Name asc;

--Q-12. Write an SQL query to print all EMPLOYEE details  from the EMPLOYEE table order by FIRST_NAME  Ascending and DEPARTMENT Descending. 
select * from Employee order by Department desc, First_Name asc;

--Q-13. Write an SQL query to print details for EMPLOYEEs  with the first name as “Vipul” and “Satish” from  EMPLOYEE table. 
select * from Employee where First_Name in ('Vipul','Satish');

--Q-14. Write an SQL query to print details of EMPLOYEEs  excluding first names, “Vipul” and “Satish” from  EMPLOYEE table. 
select * from Employee where First_Name not in ('Vipul','Satish');

--Q-15. Write an SQL query to print details of EMPLOYEEs  with DEPARTMENT name as “Admin”. 
select * from Employee where Department like 'Admin%';

use Employee;
create table Emp2 ( emp_id int primary key, fname varchar(10), lname varchar(10), addr varchar(30), ph int, email varchar(20), dep varchar(20), desi varchar(20), salary int, dob varchar(10), doj varchar(10));
insert into  Emp2 values(101,'Ram','Kumar','Chennai',12345,'ram@gmail.com','Marketing','Manager',20000,'4/02/1980','8/05/2005');
insert into  Emp2 values(102,'Sathish','Rajan','Bangalore',302389,'sathish@gmail.com','Finance','Accountant',15000,'15/07/1979','25/06/2010');
select * from Emp2;
insert into Emp2 values(103, 'Saran', 'Raj', 'Mumbai', 232003, 'saran@gmail.com', 'Bank', 'Manager', 24000, '8/04/1984', '28/07/2007');
insert into Emp2 values(104, 'Dinesh', 'Kumar','Andhra', 230232, 'dinesh@gmail.com', 'IT', 'Developer', 30000, '3/04/1997', '23/03/2019');
insert into Emp2 values(105, 'Arun', 'Vijay', 'Delhi', 450403, 'arun@gmmail.com', 'Gaming', 'Game Designer', 40000, '6/12/1996', '30/8/2018');
insert into Emp2 values(106, 'Divya', 'Priya', 'Chennai', 420930, 'divya@gmail.com', 'Film', 'Actress', 80000, '18/04/1990', '5/12/2015');

-- 1. Write a query to display record of those employees who belongs to chennai
select * from Emp2 where addr = 'Chennai';

-- 2. Write a query to display record of those employees whose salary is 20 to 50 thousand
select * from Emp2 where salary between 20000 and 50000;

-- 3. Create a new table with existing table cols of fname, lname, dept, des, sal
--create table New_Emp as (select fname, lname, dep, desi,salary from Emp2);
--create table demo AS select * from Emp2;

-- 4. Change the address of those employees who lives in mumbai to delhi
update Emp2 set addr = 'Delhi' where addr = 'Mumbai';

-- 5. Write a query to min, max, avg, count
select MIN(salary) as 'min_sal'  from Emp2;
select MAX(salary) as 'max_sal' from Emp2;
select AVG(salary) as 'avg_sal' from Emp2;

--6. Write a query to display fname, dept, sal using group by salary
select  salary from Emp2 group by salary;

--7. Change the data type as salary as int to varchar (or) varchar into int 
alter table Emp2 alter column salary varchar;
alter table Emp2 alter column salary int;
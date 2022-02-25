create database Employee;
use Employee;
create table emp_details(em_id int,em_name varchar(15),em_add varchar(30),em_salary varchar(15));
insert into emp_details values(1,'Karthik','Chennai','8000'),(2,'Ganesh','Coimbatore','7000');
select * from emp_details;
insert into emp_details  (em_id,em_name)values (3,'Venkatesh'),(4,'Ajith');
update emp_details set em_add = 'Delhi' where em_id = 3;
update emp_details set em_add = 'Mumbai',em_salary = '6000' where em_id=4;
update emp_details set em_id = 5 where em_id =3;
update emp_details set em_add = 'Goa' where em_id = 1;
alter table emp_details add em_des varchar(20);
exec sp_rename 'emp_details.em_name','em_fname','column';


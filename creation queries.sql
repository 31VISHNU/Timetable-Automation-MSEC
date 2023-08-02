/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Course_id]
      ,[Course_name]
      ,[Department]
      ,[Course_type]
  FROM [login].[dbo].[Course_details]

  create table Course_details
  ( Course_id varchar(20),
    Course_name varchar(20),
	Department varchar(20),
	L int,
	T int,
	P int,
	C float,
	Course_type int)
	drop table Faculty_details;
create table Faculty_details
  ( faculty_id varchar(20),
    faculty_name varchar(20),
	faculty_phno int,
	faculty_email varchar(30),
	faculty_dob Date,
	faculty_address_dno varchar(20),
	faculty_address_place varchar(20),
	faculty_address_pincode varchar(20),
	faculty_dept varchar(20))
  insert into Faculty_details values('19AID201','VishnuSankar',2345416,'baf@gmail.com','2003-05-31','agagf','gafga','fadg','AI&DS')
create table Login_credentials
  ( login_id varchar(20),
    password_l varchar(20),
	faculty_id varchar(20),
	roleid int)

create table Login_credentials
  ( login_id varchar(20),
    password_l varchar(20),
	faculty_id varchar(20),
	roleid int)
insert into Login_credentials values('HOD','HOD','19AID001',105)
select * from Login_credentials;
create table allot_faculty
  ( Faculty_id varchar(20),
    Course_id varchar(20),
	S_year varchar(20),
	Batch int,
	Section varchar(20),
	Semester int)
drop table allot_faculty;
create table allot_lab
  ( sno int,
  semester_id int,
  year_s varchar(20),
  batch_start_year int,
  slot int,
  day_tt varchar(20),
  course_id varchar(20),
  dept varchar(20),
  sec varchar(20))
  drop table clg_tt_level;
create table clg_tt_level
  ( sno int,
  semester_id int,
  year_s varchar(20),
  batch_start_year int,
  slot int,
  day_tt varchar(20),
  elective_id int)

  drop table clg_tt_level;
 select * from [clg_tt_level] where semester_id = 6 and year_s = 'III' and batch_start_year = 2020;
 insert into Faculty_details values('19AID201','VishnuSankar',2345416,'baf@gmail.com','2003-05-31','agagf','gafga','fadg','AI&DS')
insert into Faculty_details values('19AID202','VishnuSankar',2345416,'baf@gmail.com','2003-05-31','agagf','gafga','fadg','AI&DS')



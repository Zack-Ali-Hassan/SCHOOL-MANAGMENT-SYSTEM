create SYL_MANAGMENT_SYSTEM
---------------------------
USE SYL_MANAGMENT_SYSTEM
------------TABLE USERS-------
create TABLE Users(
user_id int primary key identity(1,1),
firstname varchar(60),
lastname varchar(60),
details varchar(20),
mobile int unique,
username varchar(60) unique,
password varchar(60),
images image 
)
drop table users
select * from users 
------------TABLE STAFF-------
CREATE TABLE Staff(
staff_id int primary key identity(1,1),
firstname varchar(60),
lastname varchar(60),
mobile int unique,
sex varchar(20),
salary money,
address varchar(60) default 'Hodan'
)
drop table staff
select * from Staff
------------TABLE Class-------
CREATE TABLE Class(
class_id int primary key identity(1,1),
classname varchar(60) unique
)
drop table Class
select * from Class
------------TABLE SUBJECT-------
CREATE TABLE Subject(
subject_id int primary key identity(1,1),
subjectname varchar(60) ,
class_id int foreign key references class(class_id)
)
drop table Subject
select * from Subject 
------------TABLE STUDENT-------
CREATE TABLE Student(
student_id int primary key identity(1,1),
firstname varchar(60),
lastname varchar(60),
address varchar(60) default 'Hodan',
sex varchar(20),
class_id int foreign key references Class(class_id),
mobile int unique,
dateofbirth date default getdate(),
images image 
)
drop table Student
select * from Student
------------TABLE TEACHER-------
CREATE TABLE Teacher(
teacher_id int primary key identity(1,1),
firstname varchar(60),
lastname varchar(60),
mobile int unique,
subject_id int foreign key references subject(subject_id),
sex varchar(20),
salary money,
dateofbirth date default getdate()
)
drop table Teacher
select * from Teacher
------------TABLE ATTENDENCE-------
create TABLE Attendence(
attendence_id int primary key identity(1,1),
attendence_date date,
attendence_status varchar(20),
student_id int foreign key references Student(student_id)
)
drop table Attendence
select * from Attendence
---Ka saxda ah

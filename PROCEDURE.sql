USE SYL_MANAGMENT_SYSTEM 



---------procedure User--------
create proc allProUser
@id int, @fname varchar(60),@lname varchar(60),@detail varchar(60),
@mobile int,@username varchar(60),@password varchar(60),@image image,@type varchar(60)
as
BEGIN
if @type='INSERT'
 BEGIN
 insert into Users(FirstName,LastName,details,mobile,UserName,Password,images) 
values(@fname,@lname,@detail,@mobile,@username,@password,@image)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE USERS SET firstname=@fname,lastname=@lname,details=@detail,mobile=@mobile,
 USERNAME=@username,PASSWORD=@password,images=@image
 WHERE USER_ID=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE Users WHERE user_id=@ID
 END  
END



----------update profile image--
create proc allPrOFileUpdate
@id int, @fname varchar(60),@lname varchar(60),
@mobile int,@username varchar(60),@password varchar(60),@image image,@type varchar(60)
as
BEGIN
if @type='UPDATE'
BEGIN
 UPDATE USERS SET firstname=@fname,lastname=@lname,mobile=@mobile,
 USERNAME=@username,PASSWORD=@password,images=@image
 WHERE USER_ID=@id
 END
END



-----------procedure delete user----
create proc deleteProUser
@id int
as
 BEGIN
 DELETE Users WHERE user_id=@ID
 END



  -------------procedure forget Password-----
create proc proForgetPasswordUpdate
@tmobile int,@tusername varchar(60), 
@password varchar(60)
as
  BEGIN
 UPDATE USERS SET password=@password
 WHERE mobile=@tmobile or USERNAME=@tusername
 END



 ----------procedure read image----
 create proc rImagePro
 @id int 
 as
 select images from users where USER_ID=@id
 --end read image



 -------------check username or mobile-----
create proc CheckproForgetPassword 
 @mobile int ,@username varchar(60)
 as
BEGIN
select mobile,username from Users where
mobile=@mobile or username=@username
END 



-----procedure check user its already exite or not-----
create proc checkInsert 
@mobile int ,@username varchar(60)
as
BEGIN
select mobile,username,images from Users where
mobile=@mobile or username=@username
END



---------procedure Staff--------
create proc allProStaff
@id int, @fname varchar(60),@lname varchar(60),@mobile int,
@sex varchar(20),@salary money,@address varchar(60),@type varchar(60)
as
BEGIN
if @type='INSERT'
 BEGIN
 insert into Staff(firstname,lastname,mobile,sex,salary,address) 
values(@fname,@lname,@mobile,@sex,@salary,@address)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE Staff SET firstname=@fname,lastname=@lname,mobile=@mobile,sex=@sex,
 salary=@salary,address=@address
 WHERE staff_id=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE Staff WHERE staff_id=@ID
 END
END



-------procedure delete staff----
create proc deleteproStaff
@id int
as
BEGIN
 DELETE Staff WHERE staff_id=@ID
END



-----procedure check staff its all ready exite or not-----
create proc allCheckStaff
@mobile int
as
begin
select mobile from Staff where mobile=@mobile 
end




---------procedure Class--------
create proc allProClass
@id int, @cname varchar(60),@type varchar(60)
as
BEGIN 
if @type='INSERT'
 BEGIN
 insert into Class(classname) 
values(@cname)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE Class SET classname=@cname
 WHERE class_id=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE Class WHERE class_id=@id
 END
 END



 ---------procedure delete class--------
create proc deleteProClass
@id int
as
BEGIN
 DELETE Class WHERE class_id=@id
 END



  -----procedure check class its all ready exite or not-----
create proc allCheckClass
@cname varchar(60)
as
begin
select classname from class where classname=@cname
end



 ---------procedure Subject--------
create proc allProSubject
@id int, @sname varchar(60),@c_id int,@type varchar(60)
as
BEGIN
if @type='INSERT'
 BEGIN
 insert into subject(subjectname,class_id) 
values(@sname,@c_id)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE subject SET subjectname=@sname,class_id=@c_id
 WHERE subject_id=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE subject WHERE subject_id=@id
 END
 END



  ---------procedure delete subject--------
create proc deleteProSubject
@id int
as
BEGIN
 DELETE subject WHERE subject_id=@id
 END



 -----procedure check Subject its all ready exite or not-----
alter proc allCheckSubject
 @sname varchar(60),@c_id int
as
begin
select subjectname,class_id from subject where  subjectname=@sname and class_id=@c_id
end



---------procedure Student--------
create proc allProStudent
@id int, @fname varchar(60),@lname varchar(60),@address varchar(60),
@sex varchar(20),@c_id int,@mobile int,@date date ,@image image,@type varchar(60)
as
BEGIN
if @type='INSERT'
 BEGIN
 insert into Student(firstname,lastname,address,sex,class_id,mobile,dateofbirth,images) 
values(@fname,@lname,@address,@sex,@c_id,@mobile,@date,@image)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE Student SET firstname=@fname,lastname=@lname,address=@address,sex=@sex,
 class_id=@c_id,mobile=@mobile,dateofbirth=@date,images=@image
 WHERE student_id=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE Student WHERE student_id=@ID
 END
END



-----procedure delete student---
create proc pdeleteStudent
@id int
as
BEGIN
 DELETE Student WHERE student_id=@ID
END



-----procedure check student its all ready exite or not-----
create proc allCheckStudent
@mobile int
as
begin
select mobile from Student where mobile=@mobile 
end



----------procedure read image----
 create proc rImageProStudent
 @id int 
 as
 select images from Student where student_id=@id
 --end read image




---------procedure Teacher--------
create proc allProTeacher
@id int, @fname varchar(60),@lname varchar(60),@mobile int,@s_id int,
@sex varchar(20),@salary money,@date date,@type varchar(60)
as
BEGIN
if @type='INSERT'
 BEGIN
 insert into teacher(firstname,lastname,mobile,subject_id,sex,salary,dateofbirth) 
values(@fname,@lname,@mobile,@s_id,@sex,@salary,@date)
 END
 IF @type='UPDATE'
 BEGIN
 UPDATE Teacher SET firstname=@fname,lastname=@lname,mobile=@mobile,subject_id=@s_id,
 sex=@sex,salary=@salary,dateofbirth=@date
 WHERE teacher_id=@id
 END
 IF @type='DELETE'
 BEGIN
 DELETE Teacher WHERE teacher_id=@ID
 END
END



----------procedure delete teacher----
create proc deleteProTeacher
@id int
as
BEGIN
 DELETE Teacher WHERE teacher_id=@ID
END




-----procedure check teacher its all ready exite or not-----
create proc allCheckTeacher
@mobile int
as
begin
select mobile from Teacher where  mobile=@mobile 
end



--------CHECK ISVALID AGE-----
create proc isValidDate 
@date1 date
as
 begin
 select datediff(YY,@date1,GETDATE()) as 'TotalYear'
 end



  ----procedure attendance
create proc takeAttendance
@std_id int,
@status varchar(100),
@date date
as
insert into Attendence(student_id,attendence_status,attendence_date)
values(@std_id,@status,@date)
   ----read student



create proc readStd
@id int
as
select Student.student_id, firstname+' '+lastname as FullName from student
where class_id=@id
----------check attendance



create proc allCheckAttendance
@date date,@c_id int
as
begin
select s.student_id,s.firstname + ' ' + s.lastname as fullname,
attendence_status,attendence_date from attendence a inner join student s on 
a.student_id=s.student_id inner join class c on s.class_id=c.class_id
where attendence_date=@date and c.class_id=@c_id
end


-----------Proce Update View Attendance
create proc UpdateViewAttendance
@id int,@status varchar(50),@date date
as
update Attendence set attendence_status =@status 
where  student_id=@id and attendence_date = @date



-----------proc reading by all attendance------
CREATE proc ReadAllAttendance
@Bdate date,@Edate date,@c_id int
as
select s.student_id as ID,s.firstname + ' ' + s.lastname as Fullname,
attendence_status as Student_Status,@Bdate BeginDate,@Edate EndDate
from attendence a inner join student s 
on a.student_id=s.student_id inner join class c on s.class_id=c.class_id
where attendence_status='Absent'and c.class_id=@c_id 
and attendence_date between @Bdate and @Edate
-----------proc reading by any class attendance------
create proc ReadAnyClassAttendance
@cId int
as
select s.student_id as ID,s.firstname + ' ' + s.lastname as Fullname,
attendence_status as Student_Status from attendence a inner join student s 
on a.student_id=s.student_id inner join class c on s.class_id=c.class_id
where c.class_id=@cId


------------create proce All student
create proc procAllStudent
as
select s.student_id,s.firstname +' ' + lastname as Full_name,
s.address,s.sex ,s.mobile, s.dateofbirth,c.classname as class_name
from student s inner join class c on s.class_id=c.class_id

------------create proce specific student
create proc procSpecificStudent
@id int
as
select s.student_id,s.firstname +' ' + lastname as Full_name,
s.address,s.sex ,s.mobile,s.dateofbirth,c.classname as class_name
from student s inner join class c on s.class_id=c.class_id where s.student_id=@id
---ka saxda ah

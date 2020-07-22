create database Personnel

create table Employee(
employeeId int identity not null primary key,
name nvarchar(50) not null,
position nvarchar(50) not null,
hourly_pay_rate nvarchar(50) not null);

insert into Employee values('Alex','HR manager', 55.25);
insert into Employee values('Emily','Project Manager', 43.00);
insert into Employee values('Roger','Jr. Backend Developer', 23.25);
insert into Employee values('Shanel','Sr. Backend Developer', 35.50);
insert into Employee values('Charles','Front End Developer', 21.25);
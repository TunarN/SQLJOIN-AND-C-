CREATE DATABASE P326
USE P326

CREATE TABLE EMPLOYEE(
ID int primary key identity not null ,
[Fullname] nvarchar(255) not null,
Age int Check(Age > 0) not null,
Email nvarchar (50) unique not null,
Salary float Check (Salary > 300 and Salary <20000) not null 
)

Alter Table EMPLOYEE
ADD City nvarchar(50)

INSERT INTO EMPLOYEE([Fullname],Age,Email,Salary,City)
values
('Tunar Namazov', 21 , 'tunarzn@code.edu.az', 1500 ,'BAKU'),
('Rovsen Xalilov' , 19 , 'rovsen@code.edu.az', 1800 , 'BAKU'),
('Togrul Salmanzade' , 20 , 'togrul@code.edu.az', 1300 , 'BAKU'),
('Ferid Hacizade' , 25 , 'farid@code.edu.az' , 1000 , 'BAKU'),
('Leman Yaqubova', 19 , 'leman@code.edu.az', 700 , 'BAKU'),
('Ismayil Zeynalov', 19 , 'ismayil@code.edu.az', 1200 , 'BAKU'),
('Elnu Azizov' , 19 , 'elnur@code.edu.az', 800 , 'BAKU') 



select * from EMPLOYEE

UPDATE EMPLOYEE SET Salary = 1100 WHERE ID=1

select * from EMPLOYEE Where Salary BETWEEN 500 and 1500
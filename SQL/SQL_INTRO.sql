--                      DDL
--//////////////////////////////////////////////////////
--CREATE DATABASE BB202
--ALTER DATABASE ELI
--MODIFY NAME=BB202
--DROP DATABASE BB202


USE BB202

CREATE TABLE Students(
[Id] int,
[Name] NVARCHAR(25),
[Surname] NVARCHAR(25),
[Age] INT,
[Tel] NVARCHAR(13)
)

ALTER TABLE Students
ADD 
Id int,
[Name] NVARCHAR(25)

ALTER TABLE Students
DROP TABLE Students
DROP COLUMN [Id],[Name]



--Rename Table(procedur)
--EXEC sp_rename People,Students
EXEC sp_rename 'Students.Name',FirstName
EXEC sp_rename 'Students.Surname',LastName

--                      DML
--//////////////////////////////////////////////////////
--C
INSERT INTO Students  VALUES
(1,'Ilahe','Letifova',19,'060606'),
(2,'Nezrin','Askerova',19,'060605')
INSERT INTO Students (id,name,surname) VALUES(2,'Nezrin','Askerova')

--R
SELECT * FROM Students

--U
Update Students SET [Name]='Murad' WHERE  Age is NULL

--D
DELETE FROM Students  WHERE age IS NULL


--Constraints

CREATE TABLE Students(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(25) NOT NULL,
[Surname] NVARCHAR(25) DEFAULT('XXX'),
[Age] INT CHECK(Age>0),
[Email] NVARCHAR(25) UNIQUE NOT NULL, 
[Tel] NVARCHAR(13)
)

SELECT * FROM Students

INSERT INTO Students  VALUES
('Ilahe','Letifova',20,'IL1@code.edu.az','060606'),
('Nezrin','Askerova',19,'NA@code.edu.az','060605')
INSERT INTO Students (Name,Age,Email) VALUES('Samir',25,'SX@code.edu.az')




-------TASK----------
--USE BDU

--CREATE TABLE Students(
--Id int PRIMARY KEY IDENTITY,
--Name NVARCHAR(30) NOT NULL,
--Surname NVARCHAR(30) DEFAULT('AAAA'),
--Fin VARCHAR(7) NOT NULL UNIQUE,
--Email NVARCHAR(20) DEFAULT('XXXX'),
--Grade int CHECK(Grade>=0 AND Grade<=700)
--)

--ALTER TABLE Students 
--ADD Age int Check(Age>0)

--ALTER TABLE Students
--Alter COLUMN Name NVARCHAR(30)






--Normalizations,Relations,Joins
Alter TABLE Students 
ADD FinCodeId int 

ALTER TABLE Students
ADD FOREIGN KEY (FInCodeId) REFERENCES FinCodes(Id)

CREATE TABLE FinCodes(
Id int PRIMARY KEY IDENTITY,
Code VARCHAR(7) NOT NULL UNIQUE
)



CREATE TABLE Countries(
Id int PRIMARY KEY  IDENTITY,
Name Nvarchar(255) NOT NULL UNIQUE,
Population int 
)

CREATE TABLE Cities(
Id int PRIMARY KEY  IDENTITY,
Name Nvarchar(255) NOT NULL UNIQUE,
Population int ,
CountryId int,  -- REFERENCES Countries(Id)
--FOREIGN KEY (CountryId) REFERENCES Countries(Id)

CONSTRAINT FK_City_To_Cuntry FOREIGN KEY (CountryId) REFERENCES Countries(Id)
)



CREATE TABLE Courses(
Id int PRIMARY KEY  IDENTITY,
Name Nvarchar(255) NOT NULL UNIQUE
)



CREATE TABLE StudenCourses(
Id int PRIMARY KEY  IDENTITY,
StudentId int REFERENCES Students(Id),
CourseId int REFERENCES Courses(Id)
)

--inner join

SELECT ct.Id AS CityId,ct.Name AS CityName,c.Name CountryName FROM  Cities  AS ct
INNER JOIN Countries AS c 
ON ct.CountryId=c.Id


--Left outher Join
SELECT ct.Id AS CityId,ct.Name AS CityName,c.Name CountryName FROM  Cities  AS ct
LEFt JOIN Countries AS c 
ON ct.CountryId=c.Id

--Right outher Join
SELECT ct.Id AS CityId,ct.Name AS CityName,c.Name CountryName FROM  Cities  AS ct
Right JOIN Countries AS c 
ON ct.CountryId=c.Id

--Full outher Join
SELECT ct.Id AS CityId,ct.Name AS CityName,c.Name CountryName FROM  Cities  AS ct
Full JOIN Countries AS c 
ON ct.CountryId=c.Id



--Self join

CREATE TABLE Positions(
Id int primary key identity,
Role NVARCHAR(50) UNIQUE,
DepedOnId int 
)

select p1.Role,p2.Role AS DependOn from Positions As p1
 Join Positions As p2
On p1.DepedOnId=p2.Id


--Cross Join
CREATE TABLE Products(
Id int primary key identity,
Name NVarchar(50) 
)

CREATE TABLE Sizes(
Id int primary key identity,
Size NVarchar(50) 
)


Select p.Name,s.Size from Products p
CROSS JOIN Sizes s	



--Non-Equal Join

Alter table Students 
Add Point int Check(Point>=0 And Point <=100 )

CREATE TABLE Grades(
Id int primary key identity,
Letter char UNIQUE,
MinPoint int ,
MaxPoint int
)

Select  s.Name,s.Surname, s.Point,g.Letter from Students  s
Join Grades g
On s.Point Between g.MinPoint and g.MaxPoint
--s.Point>=g.MinPoint And s.Point<=g.MaxPoint







--Group by

Select C.Name Country,Count(ct.Name) from Countries c
join Cities ct
On ct.CountryId=c.Id
--where c.Population>10
GROUP BY c.Name
--HAVING Count(ct.Name)>=2
Order By c.Name DESC




--View
Alter Table Students
Add CityId int


CREATE VIEW StudentInfo
As
Select s.Name,s.Surname,ct.Name City,c.Name Country,s.Point,g.Letter Grade from  Students s
Join Cities ct
on 
s.CityId =ct.Id
Join Countries c
On 
ct.CountryId=c.Id
Join Grades g
On 
s.Point  BETWEEN g.MinPoint AND g.MaxPoint


Select Name,Surname,Point,Grade From StudentInfo



--Union,Union All,Intersect,Except
Create table  OldStudents(
Id int primary key identity,
Name Nvarchar(50),
Surname Nvarchar(50)
)

--Select Name,Surname from Students
--Union 
--Select Name,Surname from OldStudents

--Select Name,Surname from Students
--Union ALL
--Select Name,Surname from OldStudents

Select Name,Surname from Students
Except
Select Name,Surname from OldStudents

Select Name,Surname from Students
Intersect
Select Name,Surname from OldStudents



--Stored procedure
Create Procedure usp_StudentGrades @point int
As
Select s.Name,s.Surname,s.Point,g.Letter Grade from  Students s
Join Grades g
On 
s.Point  BETWEEN g.MinPoint AND g.MaxPoint
Where s.Point>@point 

Exec usp_StudentGrades 70



-- Stored Function

CREATE FUNCTION GetStudentByPoint (@Point int)
RETURNS int
AS
BEGIN
	DECLARE @Count int
	SELECT @Count=COUNT(*) FROM Students WHERE Point>=@Point
	RETURN @Count
END

SELECT dbo.GetStudentByPoint(50)

Select * From Students
Delete From Students Where Id=11
Update   Students set Surname='Mammadliiii' Where Id=8


CREATE TRIGGER SelectAllStudentsAfterDelete
ON Students
After DELETE,UPDATE,Insert
AS
BEGIN
	SELECT * FROM Students
END


CREATE TRIGGER InsertDeleteStudentFromStudentsToOldStudents
ON Students
AFTER DELETE
AS
BEGIN
	DECLARE @Name nvarchar(50)
	DECLARE @Surname nvarchar(50)
	SELECT @Name=StudentList.Name, @Surname=StudentList.Surname from deleted StudentList
	INSERT INTO OldStudents VALUES(@Name,@Surname)
END

Delete from Students where id=2
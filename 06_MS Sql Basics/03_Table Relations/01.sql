-- 01 One-To-One Relationship


CREATE TABLE Passports(
	PassportID INT IDENTITY(101, 1) PRIMARY KEY,
	PassportNumber CHAR(8) UNIQUE
	)

	INSERT INTO Passports(PassportNumber)
		VALUES 
			('N34FG21B'),
			('K65LO4R7'),
			('ZE657QP2')

CREATE TABLE Persons(
	PersonID INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(30) NOT NULL,
	Sallary DECIMAL(7, 2) NOT NULL,
	PassportID INT NOT NULL FOREIGN KEY REFERENCES Passports(PassportID) UNIQUE
	)

	INSERT INTO Persons(FirstName, Sallary, PassportID)
		VALUES
			('Roberto', 43300.00, 102),
			('Tom', 56100.00, 103),
			('Yana', 60200.00, 101)


--02 One-To-Many Relationship


CREATE TABLE Manufacturers(
	ManufacturerID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	EstablishedOn DATE NOT NULL
	)

	INSERT INTO Manufacturers([Name], EstablishedOn)
		VALUES
			('BMW', '03/07/1916'),
			('Tesla', '01/01/2003'),
			('Lada', '05/01/1966')

CREATE TABLE Models(
	ModelID INT IDENTITY(101, 1) PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID) NOT NULL
	)

	INSERT INTO Models([Name], ManufacturerID)
		VALUES	
			('X1', 1),
			('i6', 1),
			('ModelS', 2),
			('ModelX', 2),
			('Model3', 2),
			('Nova', 3)


--03 Many-To-Many Relationship


CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	)

	INSERT INTO Students([Name])	
		VALUES	
			('Mila'),
			('Toni'),
			('Roni')

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY IDENTITY(101, 1),
	[Name] NVARCHAR(30) NOT NULL
	)

	INSERT INTO Exams([Name])
		VALUES
			('SpringMVC'),
			('Neo4j'),
			('Oracle 11g')

CREATE TABLE StudentsExams(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentId),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
	PRIMARY KEY(StudentId, ExamID)
	)

	INSERT INTO StudentsExams(StudentID, ExamID)
		VALUES
			(1, 101),
			(1, 102),
			(2, 101),
			(3, 103),
			(2, 102),
			(2, 103)


--04 Self-Referencing 

CREATE TABLE Teachers(
	TeacherID INT IDENTITY(101, 1) PRIMARY KEY,
	[Name] NVARCHAR(30) NOT NULL,
	ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
	)

	INSERT INTO Teachers([Name], ManagerID)
		VALUES
			('John', NULL),
			('Maya', 106),
			('Silvia', 106),
			('Ted', 105),
			('Mark', 101),
			('Greta', 101)

--05 Online Store Database

CREATE DATABASE OnlineStore

CREATE TABLE ItemTypes(
	ItemTypeID INT PRIMARY KEY,
	[Name] VARCHAR(50)
	)

CREATE TABLE Items(
	ItemID INT PRIMARY KEY,
	[Name] VARCHAR(50),
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
	)

CREATE TABLE Cities(
	CityID INT PRIMARY KEY,
	[Name] varchar(50)
	)

CREATE TABLE Customers(
	CustomerID INT PRIMARY KEY,
	[Name] VARCHAR(50),
	Birthday DATE,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
	)

CREATE TABLE Orders(
	OrderID INT PRIMARY KEY,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
	)

CREATE TABLE OrderItems(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
	PRIMARY KEY(OrderID, ItemID)
	)


-- 06 Unoversity Database


CREATE DATABASE University

USE University

CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY,
	StudentNumber VARCHAR(10) NOT NULL,
	StudentName NVARCHAR(50) NOT NULL,
	MajorID INT NOT NULL FOREIGN KEY REFERENCES Majors(MajorID)
	)


CREATE TABLE Payments(
	PaymentID INT PRIMARY KEY IDENTITY,
	PaymentDate DATE NOT NULL,
	PaymentAmount DECIMAL(15, 2) NOT NULL,
	StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(StudentID)
	)

			
CREATE TABLE Subjects(
	SubjectID INT PRIMARY KEY IDENTITY,
	SubjectName NVARCHAR(50) NOT NULL,
	)


CREATE TABLE Agenda(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
	PRIMARY KEY(StudentID, SubjectID)
	)

-- 07 Peaks in Rila

USE Geography

SELECT MountainRange, PeakName, Elevation FROM Mountains
JOIN Peaks ON Mountains.Id = Peaks.MountainId 
WHERE MountainRange = 'Rila'
ORDER BY Elevation DESC

			




	


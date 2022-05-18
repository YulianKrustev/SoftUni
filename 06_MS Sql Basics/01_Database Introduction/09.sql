CREATE DATABASE Hotel

CREATE TABLE Employees
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(12) NOT NULL,
		LastName NVARCHAR(12) NOT NULL,
		Title VARCHAR(20) NOT NULL,
		Notes TEXT
	)

INSERT INTO Employees(FirstName, LastName, Title)
	VALUES
			('Joro', 'Ivanov', 'Manager'),
			('Gosho', 'Ivanov', 'Bartender'),
			('Ivan', 'Ivanov', 'Bartender')

CREATE TABLE Customers
	(
		AccountNumber INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(12) NOT NULL,
		LastName NVARCHAR(12) NOT NULL,
		PhoneNumber BIGINT,
		EmergencyName NVARCHAR(20),
		EmergencyNumber BIGINT,
		Notes TEXT
	)

INSERT INTO Customers(FirstName, LastName)
	VALUES
			('Joro', 'Goshev'),
			('Ivan', 'Ivanov'),
			('Pesho', 'Peshev')

CREATE TABLE RoomStatus
	(
		RoomStatus INT PRIMARY KEY IDENTITY NOT NULL,
		Notes TEXT
	)

INSERT INTO RoomStatus(Notes)
	VALUES
			('FOR CLEAN'),
			('FOR CLEAN'),
			('FOR CLEAN')

CREATE TABLE RoomTypes
	(
		RoomType VARCHAR(12) PRIMARY KEY NOT NULL,
		Notes TEXT
	)

INSERT INTO RoomTypes(RoomType)
	VALUES
			('Apartent'),
			('Room'),
			('BigApartment')

CREATE TABLE BedTypes
	(
		BedType INT PRIMARY KEY IDENTITY NOT NULL,
		Notes TEXT
	)

INSERT INTO BedTypes(Notes)
	VALUES
			('BIg'),
			('Small'),
			('Middle')


CREATE TABLE Rooms
	(
		RoomNumber INT PRIMARY KEY NOT NULL IDENTITY,
		RoomType VARCHAR(12) FOREIGN KEY REFERENCES RoomTypes(RoomType),
		BedType INT FOREIGN KEY REFERENCES BedTypes(BedType),
		Rate INT,
		RoomStatus INT FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
		Notes TEXT
	)



INSERT INTO Rooms(RoomType)
	VALUES
			('Apartent'),
			('Apartent'),
			('Apartent')

CREATE TABLE Payments 
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL, 
		EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
		PaymentDate DATE, 
		AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber), 
		FirstDateOccupied DATETIME2, 
		LastDateOccupied DATETIME2, 
		TotalDays INT, 
		AmountCharged DECIMAL(6,2), 
		TaxRate FLOAT, 
		TaxAmount DECIMAL(6,2), 
		PaymentTotal DECIMAL(6,2), 
		Notes TEXT
	)


INSERT INTO Payments(EmployeeId)
	VALUES
			(1),
			(2),
			(3)


CREATE TABLE Occupancies 
	(	
		Id INT PRIMARY KEY IDENTITY NOT NULL, 
		EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL, 
		DateOccupied DATE NOT NULL,
		AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
		RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
		RateApplied DECIMAL(7, 2) NOT NULL,
		PhoneCharge DECIMAL(8, 2) NOT NULL,
		Notes NVARCHAR(1000)
	)

INSERT INTO Occupancies(EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge) VALUES
(2, '2011-02-04', 3, 1, 70.0, 12.54),
(2, '2015-04-09', 1, 2, 40.0, 11.22),
(3, '2012-06-08', 2, 3, 110.0, 10.05)


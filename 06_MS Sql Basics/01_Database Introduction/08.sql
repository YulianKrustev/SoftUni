CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		CategoryName NVARCHAR(20) NOT NULL,
		DailyRate INT,
		WeeklyRate INT,
		MonthlyRate INT,
		WeekendRate INT
	)

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
	VALUES
			('Van', 1, 1, 1, 1),
			('Bus', 1, 1, 1, 1),
			('Car', 1, 1, 1, 1)


CREATE TABLE Cars
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		PlateNumber VARCHAR(12) UNIQUE NOT NULL,
		Manufacturer VARCHAR(12) NOT NULL,
		Model VARCHAR(12) NOT NULL,
		CarYear INT NOT NULL,
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		Doors TINYINT NOT NULL,
		Picture VARBINARY(MAX),
		Condition VARCHAR(30),
		Available BIT NOT NULL
	)
	
INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Available)
	VALUES
			('asdasasf', 'Ford', 'Focus', 1234, 2, 3, 1),
			('asdasasf1', 'Ford', 'Focus', 1234, 2, 3, 1),
			('asdasasf2', 'Ford', 'Focus', 1234, 2, 3, 1)


CREATE TABLE Employees
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		FirstName NVARCHAR(20) NOT NULL,
		LastName NVARCHAR(20) NOT NULL,
		Notes TEXT
	)

INSERT INTO Employees(FirstName, LastName)
	VALUES
			('Pesho', 'Peshov'),
			('Pesho1', 'Peshov'),
			('Pesho2', 'Peshov')

CREATE TABLE Customers
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		DriverLicenceNumber INT NOT NULL,
		FullName NVARCHAR(50) NOT NULL,
		[Address] NVARCHAR(50) NOT NULL,
		City NVARCHAR(15) NOT NULL,
		ZIPCode INT NOT NULL,
		Notes TEXT
	)

INSERT INTO Customers(DriverLicenceNumber, FullName, Address, City, ZIPCode)
	VALUES
			(12321, 'ASfasf', 'asfas', 'asfagfg', 124),
			(12321, 'ASfasf', 'asfas', 'asfagfg', 124),
			(12321, 'ASfasf', 'asfas', 'asfagfg', 124)



CREATE TABLE RentalOrders
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
		CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
		CarId INT FOREIGN KEY REFERENCES Cars(Id),
		TankLevel INT,
		KilometrageStart INT,
		KilometrageEnd INT,
		TotalKilometrage INT,
		StartDate DATE,
		EndDate DATE, 
		TotalDays INT,
		RateApplied INT,
		TaxRate INT, 
		OrderStatus VARCHAR(20),
		Notes TEXT
	)

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId)
	VALUES
			(1, 2, 3),
			(1, 2, 3),
			(1, 2, 3)


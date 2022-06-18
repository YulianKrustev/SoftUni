--01. Employees with Salary Above 35000

CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary > 35000

--02. Employees with Salary Above Number

CREATE PROC usp_GetEmployeesSalaryAboveNumber @SalaryAbove DECIMAL(18, 4)
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary >= @SalaryAbove

--03. Town Names Starting With

CREATE PROC usp_GetTownsStartingWith @TownStartingWith NVARCHAR(MAX)
AS
SELECT [Name] FROM Towns
WHERE [Name] LIKE CONCAT (@TownStartingWith, '%')

--04. Employees from Town

CREATE OR ALTER PROC usp_GetEmployeesFromTown @TownName NVARCHAR(30)
AS
SELECT e.FirstName, e.LastName FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
WHERE t.Name = @TownName

--05. Salary Level Function

CREATE OR ALTER FUNCTION ufn_GetSalaryLevel (@salary DECIMAL(18,4)) 
RETURNS VARCHAR(10) AS
BEGIN 
	DECLARE @SalaryLevel VARCHAR(10)
	IF (@salary < 30000) SET @SalaryLevel = 'Low';
	ELSE IF (@salary <= 50000) SET @SalaryLevel = 'Average';
	ELSE SET @SalaryLevel = 'High';
	RETURN @SalaryLevel
END

--06. Employees by Salary Level

CREATE OR ALTER PROC usp_EmployeesBySalaryLevel (@LevelOfSalary NVARCHAR(10))
AS
BEGIN
	SELECT FirstName, LastName FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @LevelOfSalary
END

--07. Define Function

CREATE OR ALTER FUNCTION ufn_IsWordComprised (@setOfLetters NVARCHAR(MAX), @word NVARCHAR(MAX))
RETURNS BIT
AS	
BEGIN
	DECLARE @i INT = 1;
	DECLARE @CurrentLetter NVARCHAR(1)

	WHILE(@i <= LEN(@word))

		BEGIN 
			SET @CurrentLetter = SUBSTRING(@word, @i, 1);

			IF(CHARINDEX(@currentLetter, @setOfLetters) = 0) 
			BEGIN
			RETURN 0;
			END

			SET @i += 1;	
		END
	RETURN 1;
END




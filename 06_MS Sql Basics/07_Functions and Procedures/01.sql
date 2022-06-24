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


--08.Delete Employees and Departments

CREATE OR ALTER PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN

	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN 
						(
							SELECT EmployeeID FROM Employees
							WHERE DepartmentID = @departmentId
						)

	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN ( 
						SELECT EmployeeID FROM Employees
						WHERE DepartmentId = @departmentId
						) 

	
	ALTER TABLE DEPARTMENTS
	ALTER COLUMN ManagerID INT

	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN ( 
						SELECT EmployeeID FROM Employees
						WHERE DepartmentId = @departmentId
						) 

	DELETE FROM Employees
	WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) FROM Employees
	WHERE DepartmentID = @departmentId

END

EXEC usp_DeleteEmployeesFromDepartment 1


--09.Find Full Name

CREATE PROC usp_GetHoldersFullName 
AS
BEGIN
	SELECT
	CONCAT(FirstName, ' ', LastName) AS [Full Name] FROM AccountHolders
END

--10.People with Balance Higher Than

CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan (@money MONEY)
AS
BEGIN

	SELECT ah.FirstName, ah.LastName FROM AccountHolders AS ah
	JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	GROUP BY ah.FirstName, ah.LastName
	HAVING SUM(a.Balance) > @money
	ORDER BY ah.FirstName, ah.LastName
	
	
END

--11.Future Value Function

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @rate FLOAT, @years int)
RETURNS MONEY
AS
BEGIN
	DECLARE @money DECIMAL(18, 4)

	SET @money = @sum * POWER(1 + @rate, @years)

	RETURN @money
END

--12.Calculating Interest

CREATE OR ALTER PROC usp_CalculateFutureValueForAccount (@accountID INT, @rate FLOAT)
AS
BEGIN
	DECLARE @year INT = 5;

	SELECT a.AccountHolderId AS [Account Id], 
		   ah.FirstName AS [First Name], 
		   ah.LastName AS [Last Name],
		   a.Balance AS [Current Balance],
		   dbo.ufn_CalculateFutureValue(a.Balance, @rate, @year) AS [Balance in 5 years]
		   FROM Accounts AS a
	JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
	WHERE a.Id = @accountID
	
END 

--13.Scalar Function: Cash in User Games Odd Rows


CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(50))
RETURNS @returnedTable TABLE
(
SumCash MONEY
)
AS
BEGIN

	DECLARE @SumCash MONEY;

	SET @SumCash = (SELECT SUM(Cash) FROM 
										(
										  SELECT GameId, 
								     	  Cash,
		                                  ROW_NUMBER() OVER(ORDER BY Cash DESC) AS RowNum
		                                  FROM UsersGames 
	                                      WHERE GameId = (SELECT Id FROM Games WHERE [Name] = @gameName)
	                                    ) AS query
	                WHERE RowNum % 2 != 0)

	INSERT INTO @returnedTable SELECT @SumCash
	RETURN 

END 

SELECT * FROM dbo.ufn_CashInUsersGames ('Love in a mist')
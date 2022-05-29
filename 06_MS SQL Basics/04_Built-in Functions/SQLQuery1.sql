-- 01 Find Names of All Employees by First name

SELECT FirstName, LastName FROM Employees
WHERE FirstName LIKE 'Sa%'

-- 02 Find Names of All employees by Last Name

SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'

-- 03. Find First Names of All Employess

SELECT FirstName FROM Employees
WHERE DepartmentID IN (3, 10) AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005

-- 04. Find All Employees Except Engineers

SELECT FirstName, LastName FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'


-- 05. Find Towns with Name Length

SELECT [Name] FROM Towns
WHERE LEN([Name]) IN (5,6)
ORDER BY [Name] ASC

-- 06. Find Towns Starting With

SELECT TownID, [Name] FROM Towns
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name] ASC

SELECT TownID, [Name] FROM Towns
WHERE LEFT([NAME], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name] ASC

-- 07. Find Towns Not Starting With

SELECT TownID, [NAME] FROM Towns
WHERE [Name] NOT LIKE '[RBD]%'
ORDER BY [Name] ASC

-- 08. Create View Employees Hired After


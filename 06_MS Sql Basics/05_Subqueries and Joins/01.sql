--01. Employee Address

SELECT TOP(5) e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY a.AddressID ASC

--02. Addresses with Towns

SELECT TOP(50) e.FirstName, e.LastName, t.Name AS Town, a.AddressText FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY FirstName ASC, LastName

--03. Sales Employees

SELECT e.EmployeeID, e.FirstName, e.LastName, d.Name AS DepartmentName FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--04. Employee Departments

SELECT TOP(5) EmployeeID, FirstName, Salary, d.Name AS DepartmentName FROM Employees AS e
JOIN Departments AS d ON  e.DepartmentID = d.DepartmentID
WHERE Salary > 15000 
ORDER BY e.DepartmentID ASC

--05. Employees Without Projects

SELECT TOP(3) e.EmployeeID, e.FirstName FROM Employees AS e
LEFT OUTER JOIN EmployeesProjects AS p ON e.EmployeeID = p.EmployeeID
WHERE ProjectID IS NULL
ORDER BY EmployeeID ASC

--06. Employees Hired After

SELECT e.FirstName, e.LastName, e.HireDate, d.Name AS DepName FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE HireDate > '1999-1-1' AND d.Name IN('Sales', 'Finance')
ORDER BY e.HireDate ASC

--07. Employees With Project

SELECT TOP(5) e.EmployeeID, e.FirstName, p.[Name] FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
ORDER BY e.EmployeeID ASC


--08. Employee 24

SELECT e.EmployeeID, e.FirstName, 
CASE 
	WHEN YEAR(p.StartDate) > 2004  THEN NULL
	ELSE p.[Name]
	END AS ProjectName FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24 






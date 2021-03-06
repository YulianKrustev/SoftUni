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


--09. Employee Manager

SELECT e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName AS ManagerName FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID ASC


--10. Employees Summary

SELECT TOP(50) e.EmployeeID, 
               CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName,
			   CONCAT(m.FirstName, ' ', m.LastName) AS ManagerName,
			   d.Name AS DepartmentName
			   FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
ORDER BY e.EmployeeID

--11. Min Average Salary

SELECT TOP(1) AVG(Salary) AS MinAverageSalary FROM Employees
GROUP BY DepartmentID 
ORDER BY MinAverageSalary


SELECT MIN([AVGSalery]) AS MinAverageSalary FROM (SELECT AVG(Salary) AS [AVGSalery] FROM Employees
GROUP BY DepartmentID) AS [AVGSalery]


--12. Highest Peaks in Bulgaria

SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m ON mc.MountainId = m.Id
JOIN Peaks AS p ON m.Id = p.MountainId
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC


--13. Count Mountain Ranges

SELECT CountryCode, COUNT(CountryCode) AS MountainRanges FROM MountainsCountries
WHERE CountryCode IN ('US', 'BG', 'RU')
GROUP BY CountryCode


--14. Countries With or Without Rivers

SELECT TOP(5) c.CountryName, r.RiverName FROM Countries AS c
LEFT OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName ASC

--15. Continents and Currencies

SELECT ContinentCode, CurrencyCode, CurrencyCount AS CurrencyUsage
		FROM(
		SELECT ContinentCode, 
		CurrencyCode, 
		CurrencyCount, 
		DENSE_RANK() OVER 
		(PARTITION BY ContinentCode ORDER BY CurrencyCount DESC) AS CurrencyRank FROM (
				SELECT ContinentCode,
					   CurrencyCode,
					   Count(*) AS [CurrencyCount]
				FROM Countries
				GROUP BY ContinentCode, CurrencyCode
				) AS CurrencyCountQuery
				WHERE CurrencyCount > 1
				) AS CurrencyRankingQuery
WHERE CurrencyRank = 1
ORDER BY ContinentCode


--16. Countries Without any Mountains

SELECT COUNT(c.CountryCode) AS Count FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
WHERE MountainId IS NULL


--17. Highest Peak and Longest River by Country

SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS HighestPeakElevation, MAX(r.[Length]) AS LongestRiverLength FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p ON m.Id = p.MountainId
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName ASC


--18. Highest Peak Name and Elevation by Country

SELECT TOP(5) Country, 
		CASE 
			WHEN PeakName IS NULL THEN '(no highest peak)'
			ELSE PeakName
		END AS [Highest Peak Name], 
		CASE
			WHEN Elevation IS NULL THEN 0
			ELSE Elevation
		END AS [Highest Peak Elevation], 
		CASE 
			WHEN MountainRange IS NULL THEN '(no mountain)'
			ELSE MountainRange
		END AS Mountain
		FROM
		(SELECT *,
				DENSE_RANK() OVER (PARTITION BY [Country] ORDER BY [Elevation] DESC) AS [PeakRank]
				FROM (
						SELECT c.CountryName AS Country,
								p.PeakName,
								p.Elevation,
								m.MountainRange
						FROM Countries AS c
					LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
					LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
					LEFT JOIN Peaks AS p ON m.Id = p.MountainId) AS [InfoQuery]) AS Rank
WHERE PeakRank = 1
ORDER BY Country ASC, [Highest Peak Name] ASC






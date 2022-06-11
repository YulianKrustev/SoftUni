--01. Records’ Count

SELECT COUNT(*) FROM WizzardDeposits

--02. Longest Magic Wand

SELECT MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits

--03. Longest Magic Wand per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits
GROUP BY DepositGroup

--04. Smallest Deposit Group per Magic Wand Size 

SELECT TOP(2) DepositGroup FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize) ASC

--05. Deposits Sum

SELECT DepositGroup, SUM(DepositAmount) FROM WizzardDeposits
GROUP BY DepositGroup

--06. Deposits Sum for Ollivander Family

SELECT DepositGroup, SUM(DepositAmount) FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--07. Deposits Filter

SELECT * FROM (SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family' 
GROUP BY DepositGroup) AS InfoQUery
WHERE TotalSum < 150000
ORDER BY TotalSum DESC

--08. Deposit Charge

SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator ASC, DepositGroup ASC

--09. Age Groups

SELECT *, COUNT(AgeGroup) AS WizardCount FROM (SELECT CASE
			WHEN Age < 11 THEN '[0-10]'
			WHEN Age < 21 THEN '[11-20]'
			WHEN Age < 31 THEN '[21-30]'
			WHEN Age < 41 THEN '[31-40]'
			WHEN Age < 51 THEN '[41-50]'
			WHEN Age < 61 THEN '[51-60]'
			ELSE '[61+]'
			END AS AgeGroup
FROM WizzardDeposits) AS CreateGroupQuery
GROUP BY AgeGroup

--10. First Letter

SELECT SUBSTRING(FirstName, 1 , 1) AS FirstLetter FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)
ORDER BY FirstLetter

--11. Average Interest

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest FROM WizzardDeposits
WHERE DepositStartDate > '01-01-1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired ASC

--12. Rich Wizard, Poor Wizard

SELECT SUM(Difference) FROM (SELECT FirstName AS [Host Wizard], 
		DepositAmount AS [Host Wizard Deposit],
		LEAD(FirstName) OVER(ORDER BY Id ASC) AS [Guest Wizard],
		LEAD(DepositAmount) OVER (ORDER BY Id ASC) AS [Guest Wizard Deposit],
		DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id ASC) AS Difference FROM WizzardDeposits) AS query
WHERE [Guest Wizard Deposit] IS NOT NULL


--13. Departments Total Salaries

SELECT DepartmentID, SUM(Salary) AS TotalSalary FROM Employees
GROUP BY DepartmentID

--14. Employees Minimum Salaries

SELECT DepartmentID, MIN(Salary) AS MinimumSalary FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND HireDate > '01.01.2000'
GROUP BY DepartmentID

--15. Employees Average Salaries

SELECT * INTO HighestSalery FROM Employees
WHERE Salary > 30000

DELETE FROM HighestSalery
WHERE ManagerID = 42

UPDATE HighestSalery
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentId, AVG(Salary) FROM HighestSalery
GROUP BY DepartmentID

--16. Employees Maximum Salaries

SELECT DepartmentID, MAX(Salary) AS MaxSalary FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

--17. Employees Count Salaries

SELECT COUNT(*) AS [Count] FROM Employees 
WHERE ManagerID IS NULL
GROUP BY ManagerID

--18. 3rd Highest Salary 

SELECT DISTINCT DepartmentID, Salary AS ThirdHighestSalary FROM (
				SELECT 
						DepartmentID, 
						Salary, 
						DENSE_RANK() OVER (PARTITION BY DepartmentId ORDER BY Salary DESC) AS ThirdHighestSalary 
				FROM Employees) AS query
WHERE ThirdHighestSalary = 3

--19. Salary Challenge

SELECT TOP(10) 
		e.FirstName, 
		e.LastName, 
		e.DepartmentID 
		FROM 
		Employees AS e, 
		(SELECT DepartmentID, AVG(Salary) AS [DepAvgSalary] FROM Employees GROUP BY DepartmentID) AS q
WHERE e.Salary > q.DepAvgSalary AND e.DepartmentID = q.DepartmentID



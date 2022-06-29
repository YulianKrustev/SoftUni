--1. Number of Users for Email Provider

USE Diablo

SELECT SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) AS [Email Provider], 
		COUNT(*) AS [Number Of Users] FROM Users
GROUP BY SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email))
ORDER BY [Number Of Users] DESC, [Email Provider] 


--02. All Users in Games

SELECT g.[Name] AS Game, gt.[Name] AS [Game Type], u.Username, ug.[Level], ug.Cash, c.[Name] AS [Character] 
		FROM Games AS g
JOIN GameTypes AS gt ON g.GameTypeId = gt.Id
JOIN UsersGames AS ug ON g.Id = ug.GameId
JOIN Users AS u ON ug.UserId = u.Id
JOIN Characters AS c ON ug.CharacterId = c.Id
ORDER BY ug.[Level] DESC, u.Username, g.[Name] 

--03. Users in Games with Their Items

SELECT u.Username , 
	   g.[Name] AS Game, 
	   COUNT(ugi.ItemId) AS [Items Count], 
	   SUM(i.Price) AS [Items Price] 
  FROM UserGameItems AS ugi
JOIN Items AS i ON ugi.ItemId = i.Id
JOIN UsersGames AS ug ON ugi.UserGameId = ug.Id
JOIN Games AS g ON ug.GameId = g.Id
JOIN Users AS u ON ug.UserId = u.Id
GROUP BY g.[Name], u.Username
HAVING COUNT(ugi.ItemId) >=10
ORDER BY [Items Count] DESC, [Items Price] DESC, u.Username


--04. * User in Games with Their Statistics


--05. All Items with Greater than Average Statistics
DECLARE @LuckAvg INT = (SELECT AVG(Luck) FROM [Statistics]);
DECLARE @SpeedAvg INT = (SELECT AVG(Speed) FROM [Statistics]);
DECLARE @MindAvg INT = (SELECT AVG(Mind) FROM [Statistics]);

SELECT i.[Name], i.Price, i.MinLevel, s.Strength, s.Defence, s.Speed, s.Luck, s.Mind FROM Items AS i
JOIN [Statistics] AS s ON i.StatisticId = s.Id
WHERE s.Mind >@MindAvg AND s.Luck > @LuckAvg AND s.Speed > @SpeedAvg
ORDER BY i.[Name]

--06. Display All Items about Forbidden Game Type

SELECT i.[Name] AS Item, i.Price, i.MinLevel, gt.[Name] AS [Forbidden Game Type] FROM Items AS i
LEFT JOIN GameTypeForbiddenItems AS fi ON i.Id = fi.ItemId
LEFT JOIN GameTypes AS gt ON fi.GameTypeId = gt.Id
ORDER BY [Forbidden Game Type] DESC, i.Name


--07. Buy Items for User in Game

DECLARE @UserID INT = (SELECT Id FROM Users WHERE Username = 'Alex');
DECLARE @GameID INT = (SELECT Id FROM Games WHERE [Name] = 'Edinburgh');
DECLARE @UserGameID INT = (SELECT Id FROM UsersGames WHERE UserId = @UserID AND GameId = @GameID)
DECLARE @PaySumForBuyingDesiredItems INT = (SELECT SUM(Price) FROM Items WHERE [Name] IN 
('Blackguard', 'Bottomless Potion of Amplification', 'Eye of Etlich (Diablo III)', 
'Gem of Efficacious Toxin', 'Golden Gorget of Leoric', 'Hellfire Amulet'))

INSERT INTO UserGameItems
	SELECT Id, @UserGameID FROM Items 
	WHERE [Name] IN ('Blackguard', 'Bottomless Potion of Amplification', 
	'Eye of Etlich (Diablo III)', 'Gem of Efficacious Toxin', 'Golden Gorget of Leoric', 'Hellfire Amulet')
	
UPDATE UsersGames
SET CASH -= @PaySumForBuyingDesiredItems
WHERE UserId = @UserID

SELECT u.Username, g.[Name], ug.Cash, i.[Name] AS [Item Name] FROM UserGameItems AS ugi
JOIN Items AS i ON ugi.ItemId = i.Id
JOIN UsersGames AS ug ON ugi.UserGameId = ug.Id
JOIN Games AS g ON ug.GameId = g.Id
JOIN Users AS u ON u.Id = ug.UserId
WHERE g.Id = @GameID
ORDER BY [Item Name]


--08. Peaks and Mountains

use Geography

Select p.PeakName, m.MountainRange, p.Elevation FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.Id
ORDER BY p.Elevation DESC, p.PeakName

--09. Peaks with Mountain, Country and Continent

SELECT p.PeakName, m.MountainRange AS Mountain, c.CountryName, cc.ContinentName FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.Id
JOIN MountainsCountries AS mc ON m.Id = mc.MountainId
JOIN Countries AS c ON mc.CountryCode = c.CountryCode
JOIN Continents AS cc ON c.ContinentCode = cc.ContinentCode
ORDER BY p.PeakName, c.CountryName


--10. Rivers by Country

SELECT c.CountryName, 
       cn.ContinentName, 
	   COUNT(r.RiverName) AS RiverCount, 
	   ISNULL (SUM(r.Length) , 0) AS TotalLength 
	   FROM Countries AS c
LEFT JOIN Continents AS cn ON c.ContinentCode = cn.ContinentCode
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName, cn.ContinentName
ORDER BY RiverCount DESC, TotalLength DESC, c.CountryName


--11. Count of Countries by Currency

SELECT c.CurrencyCode, c.Description AS Currency, COUNT(cc.ContinentCode) AS NumberOfCountries FROM Currencies AS c
LEFT JOIN Countries AS cc ON c.CurrencyCode = cc.CurrencyCode
GROUP BY c.CurrencyCode, c.Description
ORDER BY NumberOfCountries DESC, Currency


--12. Population and Area by Continent


SELECT c.ContinentName, 
       SUM(CAST(cc.AreaInSqKm AS bigint)) AS CountriesArea, 
	   SUM(CAST(cc.[Population] AS bigint)) AS CountriesPopulation 
	   FROM Continents AS c
JOIN Countries AS cc ON c.ContinentCode = cc.ContinentCode
GROUP BY c.ContinentName
ORDER BY CountriesPopulation DESC

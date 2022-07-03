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

    SELECT u.Username AS [Username],
           g.Name AS [Game],
           MAX(c.Name) AS [Character],
           SUM(ist.Strength) + MAX(gst.Strength) + MAX(cs.Strength) AS [Strength],
           SUM(ist.Defence) + MAX(gst.Defence) + MAX(cs.Defence) AS [Defence],
           SUM(ist.Speed) + MAX(gst.Speed) + MAX(cs.Speed) AS [Speed],
           SUM(ist.Mind) + MAX(gst.Mind) + MAX(cs.Mind) AS [Mind],
           SUM(ist.Luck) + MAX(gst.Luck) + MAX(cs.Luck) AS [Luck]
      FROM Users AS u
INNER JOIN UsersGames AS ug
        ON ug.UserId = u.Id
INNER JOIN Games AS g
        ON g.Id = ug.GameId
INNER JOIN Characters AS c
        ON c.Id = ug.CharacterId
INNER JOIN GameTypes AS gt
        ON gt.Id = g.GameTypeId
INNER JOIN [Statistics] AS gst
        ON gst.Id = gt.BonusStatsId
INNER JOIN [Statistics] AS cs
        ON cs.Id = c.StatisticId
INNER JOIN UserGameItems AS ugi
        ON ugi.UserGameId = ug.Id
INNER JOIN Items AS i
        ON i.Id = ugi.ItemId
INNER JOIN [Statistics] AS ist
        ON ist.Id = i.StatisticId
  GROUP BY u.Username, 
           g.Name
  ORDER BY [Strength] DESC, 
           [Defence] DESC, 
           [Speed] DESC, 
           [Mind] DESC, 
           [Luck] DESC


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


--13. Monasteries by Country

CREATE TABLE Monasteries
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(MAX) NOT NULL,
	CountryCode CHAR(2) NOT NULL REFERENCES Countries(CountryCode)
)

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery “St. Ivan of Rila”', 'BG'), 
('Bachkovo Monastery “Virgin Mary”', 'BG'),
('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

ALTER TABLE Countries 
ADD IsDeleted BIT NOT NULL
CONSTRAINT DF_ValueIsDeleted DEFAULT 0

UPDATE Countries
SET IsDeleted = 1
WHERE CountryCode IN 
(
	SELECT c.CountryCode FROM Countries AS c
	JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
	JOIN Rivers AS r ON cr.RiverId = r.Id
	GROUP BY c.CountryCode
	HAVING COUNT(c.ContinentCode) > 3
)   

SELECT m.Name AS Monastery, c.CountryName AS Country FROM Monasteries AS m
JOIN Countries AS c ON m.CountryCode = c.CountryCode
WHERE c.IsDeleted IS NULL
ORDER BY m.Name 

--14. Monasteries by Continents and Countries

UPDATE Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'

INSERT INTO Monasteries ([Name], CountryCode) VALUES
	('Hanga Abbey', (SELECT CountryCode FROM Countries WHERE CountryName = 'Tanzania')),
	('Myin-Tin-Daik', (SELECT CountryCode FROM Countries WHERE CountryName = 'Myanmar'))

SELECT c.ContinentName, cou.CountryName, COUNT(m.Name) AS MonasteriesCount FROM Continents AS c
JOIN Countries AS cou ON c.ContinentCode = cou.ContinentCode
LEFT JOIN Monasteries AS m ON cou.CountryCode = m.CountryCode
WHERE cou.IsDeleted = 0
GROUP BY c.ContinentName, cou.CountryName
ORDER BY MonasteriesCount DESC, CountryName

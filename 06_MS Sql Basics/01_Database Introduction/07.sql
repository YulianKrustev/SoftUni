CREATE DATABASE Moives

CREATE TABLE Directors
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		DirectorName NVARCHAR(30) NOT NULL,
		Notes TEXT
	)

INSERT INTO Directors(DirectorName)
	VALUES
			('Pesho'),
			('Pesho1'),
			('Pesho2'),
			('Pesho3'),
			('Pesho4')

CREATE TABLE Genres
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		GenreName NVARCHAR(20) NOT NULL,
		Notes TEXT
	)

INSERT INTO Genres(GenreName)
	VALUES
			('Action'),
			('Comedy'),
			('Drama'),
			('Horror'),
			('Fantasy')

CREATE TABLE Categories
	(
		Id INT PRIMARY KEY IDENTITY NOT NULL,
		CategoryName NVARCHAR(30) NOT NULL,
		Notes TEXT
	)

INSERT INTO Categories(CategoryName)
	VALUES
			('Best Director'),
			('Best Soundtrack'),
			('Best Effects'),
			('Best Male Role'),
			('Best Female Role')


CREATE TABLE Movies
	(
		Id INT PRIMARY KEY IDENTITY NOT NUll,
		Title NVARCHAR(30) NOT NULL,
		DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
		CopyrightYear INT NOT NULL,
		[Length] INT,
		GenreId INT FOREIGN KEY REFERENCES Genres(Id),
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		Rating INT,
		Notes TEXT
	)

INSERT INTO Movies(Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating)
	VALUES
			('MSSQL', 1, 1982, 120, 3, 2, 4),
			('MSSQL', 1, 1982, 120, 3, 2, 4),
			('MSSQL', 1, 1982, 120, 3, 2, 4),
			('MSSQL', 1, 1982, 120, 3, 2, 4),
			('MSSQL', 1, 1982, 120, 3, 2, 4)

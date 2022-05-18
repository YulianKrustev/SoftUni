CREATE TABLE People
(
	Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Name] nvarchar(200) NOT NULL,
	Picture varbinary(2000),
	Height float(2),
	[Weight] float(2),
	Gender char(1) NOT NULL CHECK (Gender = 'm' OR Gender = 'f'),
	Birthdate date NOT NULL,
	Biography nvarchar(max)
)

INSERT INTO People(Name, Gender, Birthdate)
	VALUES
			('Kosta1', 'm', '1984-10-15'),
			('Kosta2', 'm', '1984-10-15'),
			('Kosta3', 'm', '1984-10-15'),
			('Kosta4', 'm', '1984-10-15'),
			('Kosta5', 'm', '1984-10-15')




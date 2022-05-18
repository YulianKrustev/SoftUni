CREATE DATABASE Minions
USE Minions

CREATE TABLE Minions
(	
	Id int PRIMARY KEY NOT NULL,
	[Name] nvarchar(20) NOT NULL,
	Age tinyint
)

CREATE TABLE Towns
(
	Id int PRIMARY KEY NOT NULL,
	[Name] nvarchar(20) NOT NULL
)

ALTER TABLE Minions
ADD TownId int

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id);

INSERT INTO Towns(Id, Name)
	VALUES
		(1, 'Sofia'),
		(2, 'Plovdiv'),
		(3, 'Varna')

INSERT INTO Minions(Id, Name, Age, TownId)
	VALUES
		(1, 'Kevin', 22, 1),
		(2, 'Bob', 15, 3),
		(3, 'Steward', Null, 2)

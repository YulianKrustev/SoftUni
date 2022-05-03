CREATE TABLE Users
(
	Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(900),
	LastLoginTime DATETIME2 NOT NULL, 
	IsDeleted BIT NOT NULL
)

INSERT INTO Users(Username, Password, LastLoginTime, IsDeleted)
	VALUES
		('Pesho11', '23113','10-12-2012', 0), 
		('Pesho12', '23113','10-12-2012', 1), 
		('Pesho22', '23113','10-12-2012', 0), 
		('Pesho1', '23113','10-12-2012', 1), 
		('Pesho2', '23113','10-12-2012', 0);
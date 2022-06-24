--01. Create Table Logs

CREATE TABLE Logs 
(
	LogId INT PRIMARY KEY IDENTITY, 
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id), 
	OldSum MONEY, 
	NewSum MONEY
) 

CREATE OR ALTER TRIGGER tr_UpdateBalance ON Accounts FOR UPDATE
AS
BEGIN
	DECLARE @AccountId INT = (SELECT Id FROM inserted);
	DECLARE @oldSum MONEY = (SELECT Balance FROM deleted);
	DECLARE @newSum MONEY = (SELECT Balance FROM inserted);
	
	INSERT INTO Logs (AccountId, OldSum, NewSum)
	VALUES
		(@AccountId, @oldSum, @newSum)

END


--02. Create Table Emails

CREATE TABLE NotificationEmails 
(
	Id INT PRIMARY KEY IDENTITY, 
	Recipient INT FOREIGN KEY REFERENCES Accounts(Id), 
	Subject NVARCHAR(MAX), 
	Body NVARCHAR(MAX)
) 

CREATE OR ALTER TRIGGER tr_EmaiNotification ON Logs FOR Insert
AS
BEGIN
	DECLARE @Recipent INT = (SELECT AccountId FROM inserted)
	DECLARE @oldSum MONEY = (SELECT OldSum FROM inserted)
	DECLARE @newSum MONEY = (SELECT NewSum FROM inserted)
	DECLARE @Subject NVARCHAR(MAX) = (CONCAT('Balance change for account: ', @Recipent))
	DECLARE @Body NVARCHAR(MAX) = 
		(
		CONCAT
		('On ', 
		GETDATE(),
		' your balance was changed from', 
		CAST(@oldSum as NVARCHAR(20)), 
		'to', 
		CAST(@newSum as NVARCHAR(20)),
		'.')
		)

	INSERT INTO NotificationEmails (Recipient, Subject, Body)
	VALUES
		(@Recipent, @Subject, @Body)

END

UPDATE Accounts
SET Balance += 10
WHERE Id =2

SELECT * FROM Accounts

SELECT * FROM Logs

SELECT * FROM NotificationEmails

--03. Deposit Money

CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount MONEY)
AS
BEGIN TRANSACTION

DECLARE @Account INT = (SELECT Id FROM Accounts WHERE Id = @AccountId)
	
	IF(@Account IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid account ID!', 16,1)
		RETURN
	END


	IF (@MoneyAmount < 0)
	BEGIN
		ROLLBACK
		RAISERROR('The money can''t be negative', 16,1)
		RETURN
	END

	UPDATE Accounts	
	SET Balance += @MoneyAmount
	WHERE Id = @Account

COMMIT

EXEC usp_DepositMoney 1, 10

SELECT * FROM Accounts WHERE Id = 1

--04. Withdraw Money

CREATE OR ALTER PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount MONEY)
AS

BEGIN TRANSACTION

IF((SELECT Id FROM Accounts WHERE Id = @AccountId) IS NULL)
BEGIN
ROLLBACK
RAISERROR('Account is not wxisting', 16,1)
RETURN
END

IF(@MoneyAmount < 0)
BEGIN
ROLLBACK
RAISERROR('Money van''t be negative', 16,1)
RETURN
END

IF((SELECT Balance FROM Accounts WHERE Id = @AccountId) < @MoneyAmount)
BEGIN
ROLLBACK
RAISERROR('Insufficient funds', 16,1)
RETURN
END

UPDATE Accounts
SET Balance -= @MoneyAmount
WHERE Id = @AccountId

COMMIT
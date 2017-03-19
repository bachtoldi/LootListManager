-- create database
IF DB_ID(N'LootListManager') IS NULL
BEGIN
	CREATE DATABASE [LootListManager]
END
GO

USE [LootListManager]
GO

-- create tables
--- Users
IF OBJECT_ID(N'LootListManager.Users') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Users] (
		[UserId] INT IDENTITY(1,1) PRIMARY KEY,
		[UserName] NVARCHAR(50) NOT NULL UNIQUE,
		[UserPasswordHash] NVARCHAR(MAX) NOT NULL,
		[UserLoginAttempts] INT NOT NULL
	)
END
GO

--- Tokens
IF OBJECT_ID(N'LootListManager.Tokens') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Tokens] (
		[TokenId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_UserId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Users]([UserId]),
		[AuthToken] NVARCHAR(MAX) NOT NULL,
		[IssuedOn] DATETIME2(7) NOT NULL,
		[ExpiresOn] DATETIME2(7) NOT NULL
	)
END
GO
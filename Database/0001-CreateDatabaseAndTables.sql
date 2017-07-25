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
IF OBJECT_ID(N'Users') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Users] (
		[Id] INT IDENTITY(1,1) PRIMARY KEY,
		[UserName] NVARCHAR(50) NOT NULL UNIQUE,
		[PasswordHash] NVARCHAR(MAX) NOT NULL,
		[UserLoginAttempts] INT NOT NULL
	)
END
GO

--- Tokens
IF OBJECT_ID(N'Tokens') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Tokens] (
		[TokenId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_UserId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Users]([Id]),
		[AuthToken] NVARCHAR(MAX) NOT NULL,
		[IssuedOn] DATETIME2(7) NOT NULL,
		[ExpiresOn] DATETIME2(7) NOT NULL
	)
END
GO

-- Instances
IF OBJECT_ID(N'Instances') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Instances] (
		[InstanceId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[InstanceLogicalId] NVARCHAR(10) NOT NULL UNIQUE,
		[InstanceSort] INT NOT NULL UNIQUE--,
		--[InstanceImage] NVARCHAR(MAX) NULL
	)
END
GO

-- InstanceNames
--IF OBJECT_ID(N'InstanceNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[InstanceNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Instances] ( [InstanceLogicalId] ) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_InstanceNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture])
--	)
--END
--GO

-- Bosses
IF OBJECT_ID(N'Bosses') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Bosses] (
		[BossId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[BossLogicalId] NVARCHAR(10) NOT NULL UNIQUE,
		[BossSort] INT NOT NULL,
		[FK_InstanceId] INT FOREIGN KEY REFERENCES [dbo].[Instances]([InstanceId]) NOT NULL,
		CONSTRAINT [uq_InstanceBossSort] UNIQUE NONCLUSTERED ( [BossSort], [FK_InstanceId] ) ON [PRIMARY]
	)
END
GO

-- BossNames
--IF OBJECT_ID(N'BossNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[BossNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Bosses] ( [BossLogicalId] ) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_BossNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- Classes
IF OBJECT_ID(N'Classes') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Classes] (
		[ClassId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[ClassLogicalId] NVARCHAR(10) NOT NULL UNIQUE--,
		--[ClassImage] NVARCHAR(MAX) NULL,
	)
END
GO

-- ClassNames
--IF OBJECT_ID(N'ClassNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[ClassNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Classes]([ClassLogicalId]) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_ClassNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- Items
IF OBJECT_ID(N'Items') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Items] (
		[ItemId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[ItemLogicalId] NVARCHAR(10) NOT NULL UNIQUE--,
		--[ItemImage] NVARCHAR(MAX) NULL
	)
END
GO

-- ItemNames
--IF OBJECT_ID(N'ItemNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[ItemNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Items]([ItemLogicalId]) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_ItemNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- ItemBossSettings
IF OBJECT_ID(N'ItemBossSettings') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[ItemBossSettings] (
		[ItemBossSettingsId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_ItemId] INT FOREIGN KEY REFERENCES [dbo].[Items]([ItemId]) NOT NULL,
		[FK_BossId] INT FOREIGN KEY REFERENCES [dbo].[Bosses]([BossId]) NOT NULL,
		CONSTRAINT [uq_ItemBoss] UNIQUE NONCLUSTERED ( [FK_ItemId], [FK_BossId] ) ON [PRIMARY]
	)
END
GO

-- Talents
IF OBJECT_ID(N'Talents') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Talents] (
		[TalentId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[TalentLogicalId] NVARCHAR(10) NOT NULL UNIQUE,
		[FK_ClassId] INT FOREIGN KEY REFERENCES [dbo].[Classes]([ClassId]) NOT NULL--,
		--[TalentImage] NVARCHAR(MAX) NULL
	)
END
GO

-- TalentNames
--IF OBJECT_ID(N'TalentNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[TalentNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Talents]([TalentLogicalId]) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_TalentNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- Factions
IF OBJECT_ID(N'Factions') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Factions] (
		[FactionId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FactionLogicalId] NVARCHAR(10) NOT NULL UNIQUE--,
		--[FactionImage] NVARCHAR(MAX) NULL
	)
END
GO

-- FactionNames
--IF OBJECT_ID(N'FactionNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[FactionNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Factions]([FactionLogicalId]) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_FactionNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- Races
IF OBJECT_ID(N'Races') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Races] (
		[RaceId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[RaceLogicalId] NVARCHAR(10) NOT NULL UNIQUE,
		[FK_FactionId] INT FOREIGN KEY REFERENCES [dbo].[Factions]([FactionId]) NOT NULL--,
		--[RaceImage] NVARCHAR(MAX) NULL
	)
END
GO

-- RaceNames
--IF OBJECT_ID(N'RaceNames') IS NULL
--BEGIN
--	CREATE TABLE [LootListManager].[dbo].[RaceNames] (
--		[LogicalId] NVARCHAR(10) FOREIGN KEY REFERENCES [dbo].[Races]([RaceLogicalId]) NOT NULL,
--		[Culture] NVARCHAR(10) NOT NULL,
--		[Value] NVARCHAR(100) NOT NULL,
--		CONSTRAINT [pk_RaceNamesLogicalIdCulture] PRIMARY KEY ( [LogicalId], [Culture] )
--	)
--END
--GO

-- ClassRaceSettings
IF OBJECT_ID(N'ClassRaceSettings') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[ClassRaceSettings] (
		[ClassRaceSettingId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_ClassId] INT FOREIGN KEY REFERENCES [dbo].[Classes]([ClassId]) NOT NULL,
		[FK_RaceId] INT FOREIGN KEY REFERENCES [dbo].[Races]([RaceId]) NOT NULL,
		CONSTRAINT [uq_ClassRace] UNIQUE NONCLUSTERED ( [FK_ClassId], [FK_RaceId] ) ON [PRIMARY]
	)
END
GO

-- Characters
IF OBJECT_ID(N'Characters') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Characters] (
		[CharacterId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[CharacterName] NVARCHAR(50) NOT NULL UNIQUE,
		[FK_UserId] INT FOREIGN KEY REFERENCES [dbo].[Users]([Id]) NOT NULL,
		[FK_RaceId] INT FOREIGN KEY REFERENCES [dbo].[Races]([RaceId]) NOT NULL,
		[FK_TalentId] INT FOREIGN KEY REFERENCES [dbo].[Talents]([TalentId]) NOT NULL
	)
END
GO

-- NeedTypes
IF OBJECT_ID(N'NeedTypes') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[NeedTypes] (
		[NeedTypeId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[NeedTypeName] NVARCHAR(100) NOT NULL UNIQUE
	)
END
GO

-- Priorities
IF OBJECT_ID(N'Priorities') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Priorities] (
		[PriorityId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[PriorityName] NVARCHAR(50) NOT NULL UNIQUE
	)
END
GO

-- Needs
IF OBJECT_ID(N'Needs') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Needs] (
		[NeedId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_CharacterId] INT FOREIGN KEY REFERENCES [dbo].[Characters]([CharacterId]) NOT NULL,
		[FK_ItemId] INT FOREIGN KEY REFERENCES [dbo].[Items]([ItemId]) NOT NULL,
		[FK_NeedTypeId] INT FOREIGN KEY REFERENCES [dbo].[NeedTypes]([NeedTypeId]) NOT NULL,
		[FK_PriorityId] INT FOREIGN KEY REFERENCES [dbo].[Priorities]([PriorityId]) NOT NULL,
		CONSTRAINT [uq_CharItem] UNIQUE NONCLUSTERED ( [FK_CharacterId], [FK_ItemId] ) ON [PRIMARY]
	)
END
GO

-- Roles
IF OBJECT_ID(N'Roles') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[Roles] (
		[RoleId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[RoleName] NVARCHAR(50) NOT NULL UNIQUE
	)
END
GO

-- UserRoles
IF OBJECT_ID(N'UserRoles') IS NULL
BEGIN
	CREATE TABLE [LootListManager].[dbo].[UserRoles] (
		[UserRoleId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[FK_UserId] INT FOREIGN KEY REFERENCES [dbo].[Users] ( [Id] ) NOT NULL,
		[FK_RoleId] INT FOREIGN KEY REFERENCES [dbo].[Roles] ( [RoleId] ) NOT NULL
	)
END
GO
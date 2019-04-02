
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/02/2019 17:54:47
-- Generated from EDMX file: C:\develop\dev7k\ComplexVisualStudioProject\src\App.DataAccessLayer\Models\EmployeeTrainingModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EmployeeTraining];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeSet'
CREATE TABLE [dbo].[EmployeeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [DateOfBirth] datetime  NOT NULL,
    [DateOfHire] datetime  NOT NULL
);
GO

-- Creating table 'TrainingSet'
CREATE TABLE [dbo].[TrainingSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [EmployeeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TrainingSet'
ALTER TABLE [dbo].[TrainingSet]
ADD CONSTRAINT [PK_TrainingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeId] in table 'TrainingSet'
ALTER TABLE [dbo].[TrainingSet]
ADD CONSTRAINT [FK_EmployeeTraining]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[EmployeeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeTraining'
CREATE INDEX [IX_FK_EmployeeTraining]
ON [dbo].[TrainingSet]
    ([EmployeeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
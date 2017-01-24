CREATE TABLE [dbo].[Users] (
    [UsersID]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (255) NULL,
    [PhoneNumber]    VARCHAR (100) NULL,
    [Email]          VARCHAR (255) NULL,
    [BirthDate]      VARCHAR (255) NULL,
    [AddressStreet]  VARCHAR (255) NULL,
    [AddressCity]    VARCHAR (255) NULL,
    [AddressCountry] VARCHAR (100) NULL,
    [Company]        VARCHAR (255) NULL,
    [StartedWorking] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([UsersID] ASC)
);


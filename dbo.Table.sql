CREATE TABLE [dbo].[Lecturer] (
    [Id]        INT           NOT NULL,
    [Firstname] NVARCHAR (50) NULL,
    [Surname]   NVARCHAR (50) NULL,
    [DOB]       NVARCHAR (50) NULL,
    [County]    NVARCHAR (50) NULL,
    [Course]    NVARCHAR (50) NULL,
    [Hours]     INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


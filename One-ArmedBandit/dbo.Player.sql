CREATE TABLE [dbo].[Player] (
    [PlayerId]   INT        IDENTITY (1, 1) NOT NULL,
    [PlayerName] NCHAR (30) NOT NULL,
    [Password]   NCHAR (50) NOT NULL,
    [Cash]       INT        NOT NULL DEFAULT 0,
    [Tokens]     INT        NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([PlayerId] ASC)
);


CREATE TABLE [dbo].[SessionTable] (
    [session_ID]   INT            PRIMARY KEY,
    [name]         NVARCHAR (255) NULL,
    [notes]        NVARCHAR (MAX) NULL,
    [character_ID] INT            NULL,
    FOREIGN KEY (character_ID) REFERENCES [dbo].[CharacterTable]([character_ID])
);
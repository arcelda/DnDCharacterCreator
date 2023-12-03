CREATE TABLE [dbo].[CharacterTable] (
    [character_ID] INT            PRIMARY KEY,
    [password]     NVARCHAR (255) NULL,
    [name]         NVARCHAR (255) NULL,
    [level]        INT            NULL,
    [gender]       NVARCHAR (50)  NULL,
    [race]         NVARCHAR (255) NULL,
    [role]         NVARCHAR (50)  NULL,
    [strength]     INT            NULL,
    [dexterity]    INT            NULL,
    [constitution] INT            NULL,
    [intelligence] INT            NULL,
    [wisdom]       INT            NULL,
    [charisma]     INT            NULL
);

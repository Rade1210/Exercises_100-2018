﻿CREATE TABLE [dbo].[ExerciseTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StudentName] NVARCHAR(100) NOT NULL, 
    [StudentIndex] NVARCHAR(20) NOT NULL, 
    [Points] INT NOT NULL
)

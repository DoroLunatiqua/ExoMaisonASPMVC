CREATE TABLE [dbo].[Person]
(

	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[First_Name] NVARCHAR(120) ,
    [Last_Name] NVARCHAR(120) ,
	[Birth_Date] DATE NOT NULL, 
    CONSTRAINT [CK_Person_Birth_Date] 
        CHECK (DATEDIFF(YEAR, [Birth_Date], GETDATE()) >= 18 
               OR (MONTH([Birth_Date]) = MONTH(GETDATE()) 
               AND DAY([Birth_Date]) <= DAY(GETDATE())))
)


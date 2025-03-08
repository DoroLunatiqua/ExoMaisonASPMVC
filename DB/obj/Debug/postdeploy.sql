/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[Person] ([First_Name],[Last_Name],[Birth_Date])
    VALUES ('Debby', 'Ckx', '1993-07-27');

 INSERT INTO [dbo].[User] ([First_Name], [Last_Name], [Email], [Password], [Salt])
VALUES ('John', 'Doe', 'john.doe@example.com', 0x1234567890ABCDEF, NEWID());

INSERT INTO [dbo].[Person] ([First_Name],[Last_Name], [Birth_Date])
VALUES ('Alice','Doe', '2000-01-01');


GO

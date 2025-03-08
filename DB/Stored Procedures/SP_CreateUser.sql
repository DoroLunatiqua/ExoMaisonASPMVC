CREATE PROCEDURE [dbo].[SP_CreateUser]
	@UserId UNIQUEIDENTIFIER,
    @FirstName NVARCHAR(64),
    @LastName NVARCHAR(64),
    @Email NVARCHAR(320),
    @Password VARBINARY(64),
    @Salt UNIQUEIDENTIFIER
AS
BEGIN
    INSERT INTO [dbo].[User] (User_Id, First_Name, Last_Name, Email, Password, Salt, CreatedAt)
    VALUES (@UserId, @FirstName, @LastName, @Email, @Password, @Salt, GETDATE());
END;
CREATE PROCEDURE sp_UpdateUser
    @UserId UNIQUEIDENTIFIER,
    @FirstName NVARCHAR(64),
    @LastName NVARCHAR(64),
    @Email NVARCHAR(320)
AS
BEGIN
    UPDATE [dbo].[User]
    SET First_Name = @FirstName,
        Last_Name = @LastName,
        Email = @Email
    WHERE User_Id = @UserId;
END;
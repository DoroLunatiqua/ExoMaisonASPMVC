CREATE PROCEDURE [dbo].[sp_DeleteUser]
	  @UserId UNIQUEIDENTIFIER
AS
BEGIN
    UPDATE [dbo].[User]
    SET DisabledAt = GETDATE()
    WHERE User_Id = @UserId;
END;
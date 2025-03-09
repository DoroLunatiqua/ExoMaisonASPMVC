CREATE PROCEDURE [dbo].[sp_GetUserById]
   @user_id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	[User_Id],
			[First_Name],
			[Last_Name],
			[Email], 
			[CreatedAt], 
			[DisabledAt]
		
		FROM [User]
		WHERE [User_Id] = @user_id
END

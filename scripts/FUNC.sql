
CREATE OR ALTER FUNCTION GetAddressesByLogin(@login nvarchar(30))
RETURNS TABLE
AS
	RETURN SELECT * FROM [Client Address] WHERE [Client Login] = @login AND Active = 1
GO

-- SELECT * FROM GetAddressesByLogin('Alex')

CREATE OR ALTER FUNCTION GetOpenOrderDishes(@login nvarchar(30))
RETURNS TABLE
AS
	RETURN (SELECT [Dish ID] FROM [Orders View] WHERE [Client Login] = @login AND [Ordered At] IS NULL AND Status = 0)
GO

CREATE OR ALTER FUNCTION GetUserByLoginAndPassword(@login nvarchar(30), @password char(64))
RETURNS TABLE
AS 
	RETURN (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1) 
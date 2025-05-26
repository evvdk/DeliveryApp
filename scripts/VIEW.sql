
USE Delivery
GO

CREATE OR ALTER VIEW [Orders View]
AS
	SELECT [Order ID], [Client ID], [Client Address ID], Courier, [Status], [Ordered At], [Complited At], [Dish ID], [Count], [Producer ID]
		FROM ([Order] JOIN [Dishes Order] ON [Order].ID = [Dishes Order].[Order ID]) JOIN Dish ON [Dishes Order].[Dish ID] = Dish.ID

GO

CREATE OR ALTER TRIGGER OnDeleteDish ON [Orders View]
INSTEAD OF DELETE
AS
BEGIN
	DECLARE DishDeleteCursor CURSOR
	SCROLL FOR 
		SELECT [Order ID], [Dish ID], [Count] FROM deleted WHERE [Ordered At] IS NULL AND [Status] = 0;
	
	DECLARE @Order int, @Dish int, @Count int;

	OPEN DishDeleteCursor
	FETCH FIRST FROM DishDeleteCursor
	INTO @Order, @Dish, @Count

	WHILE(@@FETCH_STATUS = 0)
	BEGIN

		BEGIN TRAN

		IF(@Count = 1)
		BEGIN
			DELETE FROM [Dishes Order]
				WHERE [Order ID] = @Order AND [Dish ID] = @Dish
			IF @@ERROR = 0 AND @@ROWCOUNT = 1
				COMMIT TRAN
			ELSE
				ROLLBACK TRAN
		END
		ELSE 
		BEGIN
			UPDATE [Dishes Order]
				SET [Count] = [Count] - 1
				WHERE [Order ID] = @Order AND [Dish ID] = @Dish
			IF @@ERROR = 0 AND @@ROWCOUNT = 1
				COMMIT TRAN
			ELSE
				ROLLBACK TRAN
		END

		FETCH NEXT FROM DishDeleteCursor
			INTO @Order, @Dish, @Count
	END

	CLOSE DishDeleteCursor
	DEALLOCATE DishDeleteCursor
END

GO

CREATE OR ALTER TRIGGER ApplyInsertIntoOrders ON [Orders View]
INSTEAD OF INSERT
AS
BEGIN
	DECLARE OrdersViewCursor CURSOR
	SCROLL 
	FOR SELECT [Order ID], [Client ID], [Client Address ID], [Dish ID], [Count] FROM inserted;

	DECLARE @OrderID int, @ClientID int, @Address int, @Dish int, @Count int;

	OPEN OrdersViewCursor 
	FETCH FIRST FROM OrdersViewCursor 
	INTO @OrderID, @ClientID, @Address, @Dish, @Count

	WHILE(@@FETCH_STATUS = 0)
	BEGIN

		BEGIN TRAN

		DECLARE @openedOrderID int;
		SELECT @openedOrderID = ID FROM [Order] WHERE [Client ID] = @ClientID AND [Ordered At] IS NULL AND [Status] = 0 -- is any opend with this user

		IF (@openedOrderID IS NULL)
		BEGIN
			INSERT INTO [Order] ([Client ID], [Client Address ID]) VALUES (@ClientID, @Address);
			IF @@ERROR = 0 AND @@ROWCOUNT = 1
			BEGIN
				SET @openedOrderID = SCOPE_IDENTITY()
				INSERT INTO [Dishes Order] ([Dish ID],[Order ID], [Count])
					VALUES (@Dish, @OpenedOrderID, @Count)
				IF @@ERROR = 0 AND @@ROWCOUNT = 1 
					COMMIT TRAN;
				ELSE
					ROLLBACK TRAN;
			END
			ELSE
				ROLLBACK TRAN;
		END
		ELSE 
		BEGIN
			IF NOT EXISTS(SELECT * FROM [Dishes Order] WHERE [Dish ID] = @Dish AND [Order ID] = @openedOrderID)
			BEGIN
				INSERT INTO [Dishes Order] ([Dish ID],[Order ID],[Count])
					VALUES (@Dish, @OpenedOrderID, @Count)
				IF @@ERROR = 0 AND @@ROWCOUNT = 1
					COMMIT TRAN;
				ELSE
					ROLLBACK TRAN;
			END
			ELSE 
			BEGIN
				UPDATE [Dishes Order]
					SET [Count] = [Count] + @Count
					WHERE [Dish ID] = @Dish AND [Order ID] = @openedOrderID
				IF @@ERROR = 0 AND @@ROWCOUNT = 1
					COMMIT TRAN;
				ELSE
					ROLLBACK TRAN;
			END
		END
		FETCH NEXT FROM OrdersViewCursor 
		INTO @OrderID, @ClientID, @Address, @Dish, @Count
	END

	CLOSE OrdersViewCursor 
	DEALLOCATE OrdersViewCursor
END

GO

CREATE OR ALTER VIEW [Order Status Table]
AS
SELECT [Order].ID, Client.[Login] AS [Client Login],[Client Address ID],[Ordered At],[Complited At], [Status].ID AS [Status ID], [Status].Value AS [Status Value],[Order Grade]
  FROM ([Order] JOIN Status ON [Order].Status = Status.ID) JOIN Client ON [Order].[Client ID] = Client.ID
GO

CREATE OR ALTER VIEW [Address By Login]
AS
SELECT Client.[Login] AS [Client Login], [Password], [Active Account], [Client Address].ID AS [Address ID], [Region],[City],[District],
		[Street],[Building],[Floor],[Room],[Active] AS [Active Address]
FROM Client JOIN [Client Address] ON Client.ID = [Client Address].[Client ID]
GO

CREATE OR ALTER VIEW [Order Set]
AS
SELECT [Order].ID AS [Order ID], [Login] AS [Client Login], [Status] AS [Order Status], [Dish ID], [Count], Dish.[Name] As [Dish Name], [Image], Cost, Mass, Calories
FROM (([Order] RIGHT JOIN [Dishes Order] ON [Order].ID = [Dishes Order].[Order ID]) LEFT JOIN Dish ON [Dishes Order].[Dish ID] = Dish.ID) LEFT JOIN Client ON [Order].[Client ID] = Client.ID
WHERE Dish.Visible = 1
WITH CHECK OPTION

CREATE OR ALTER VIEW [All Dishes]
AS
SELECT 
FROM 
WHERE Dish.Visible = 1

USE Delivery
GO

CREATE OR ALTER VIEW [Orders View]
AS
	SELECT [Order ID], [Client Login], [Client Address ID], Courier, [Status], [Ordered At], [Complited At], [Dish ID], [Count], [Producer ID]
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
	FOR SELECT [Order ID], [Client Login], [Client Address ID], [Dish ID], [Count] FROM inserted;

	DECLARE @OrderID int, @Login nvarchar(30), @Address int, @Dish int, @Count int;

	OPEN OrdersViewCursor 
	FETCH FIRST FROM OrdersViewCursor 
	INTO @OrderID, @Login, @Address, @Dish, @Count

	WHILE(@@FETCH_STATUS = 0)
	BEGIN

		BEGIN TRAN

		DECLARE @openedOrderID int;
		SELECT @openedOrderID = ID FROM [Order] WHERE [Client Login] = @Login AND [Ordered At] IS NULL AND [Status] = 0 -- is any opend with this user

		IF (@openedOrderID IS NULL)
		BEGIN
			INSERT INTO [Order] ([Client Login], [Client Address ID]) VALUES (@Login, @Address);
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
		INTO @OrderID, @Login, @Address, @Dish, @Count
	END

	CLOSE OrdersViewCursor 
	DEALLOCATE OrdersViewCursor
END

GO

CREATE OR ALTER VIEW [Producer Dishes]
AS
SELECT [Producer].ID AS [Producer ID], Producer.Name, Dish.ID AS [Dish ID], Dish.Name AS [Dish Name], Dish.Cost AS [Dish Cost]
FROM [Producer] RIGHT JOIN Dish ON Producer.ID = Dish.[Producer ID]
WHERE Dish.Visible = 1
WITH CHECK OPTION
GO

CREATE OR ALTER VIEW [Courier Order To]
AS
SELECT [Courier].ID, [Order].ID AS [Order ID], [Order].[Client Login],[Region],[City],[District],[Street],[Building],[Floor],[Room]
	FROM (Courier RIGHT JOIN [Order] ON Courier.ID = [Order].Courier) LEFT JOIN [Client Address] ON [Client Address].ID = [Client Address ID]
	WHERE [Client Address].Active = 1
	WITH CHECK OPTION
GO


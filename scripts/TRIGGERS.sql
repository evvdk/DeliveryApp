USE Delivery
GO

CREATE TRIGGER CheckIfAddressBelongsToClient ON [Order]
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @Client int, @Address int;
	DECLARE @Found tinyint;
	SET @Found = 0
	DECLARE OrderCheckAddressCursor CURSOR
	SCROLL 
	FOR SELECT DISTINCT [Client], [Client Address] FROM inserted;

	OPEN OrderCheckAddressCursor
	FETCH FIRST FROM OrderCheckAddressCursor
	INTO  @Client, @Address

	WHILE(@@FETCH_STATUS = 0 AND @Found = 0)
	BEGIN
			IF NOT EXISTS(SELECT * FROM [Client Address] WHERE [ID] = @Address AND [Client] = @Client)
				SET @Found = 1

		FETCH NEXT FROM OrderCheckAddressCursor
		INTO @Client, @Address
	END
	CLOSE OrderCheckAddressCursor
	DEALLOCATE OrderCheckAddressCursor
	IF (@Found != 0) THROW 50015, 'Address doesn''t belong to user', 1;
END

GO

CREATE OR ALTER TRIGGER OneProducerInSingleOreder ON "Dishes Order"
AFTER INSERT
AS
BEGIN
	DECLARE @Order int;
	DECLARE @FoundDifferentProds tinyint;
	SET @FoundDifferentProds = 0
	DECLARE OrderCursorVar CURSOR
	SCROLL 
	FOR SELECT DISTINCT [Order ID] FROM inserted;

	OPEN OrderCursorVar
	FETCH FIRST FROM OrderCursorVar
	INTO @Order

	WHILE(@@FETCH_STATUS = 0 AND @FoundDifferentProds = 0)
	BEGIN
		IF((
			SELECT COUNT(DISTINCT [Producer ID])
				FROM Dish RIGHT JOIN (
										SELECT [Dish ID] 
											FROM [Dishes Order] 
											WHERE [Order ID] = @Order
										) AS OrderDishes 
				ON Dish.ID = OrderDishes.[Dish ID]
			) != 1)
			SET @FoundDifferentProds = 1

		FETCH NEXT FROM OrderCursorVar
		INTO @Order
	END
	CLOSE OrderCursorVar
	DEALLOCATE OrderCursorVar
	IF (@FoundDifferentProds != 0) THROW 50010, 'Different producers in the same order', 1;
END
GO

CREATE OR ALTER TRIGGER OnlyOneOpenedOrder ON [Order]
AFTER INSERT
AS
BEGIN
	IF ((
	SELECT COUNT(*)
		FROM [Order] JOIN inserted ON [Order].[Client] = inserted.[Client]
		WHERE [Order].[Ordered At] IS NULL AND [Order].[Status] = 0
	) > 1) THROW 50011, 'More than one opened order', 1;
		
END

GO

CREATE OR ALTER TRIGGER ClearOrderOnEmpty ON "Dishes Order"
AFTER DELETE
AS
BEGIN

	DECLARE @OrderID int;
	DECLARE DeltedOrdersCursorVar CURSOR
	SCROLL
	FOR SELECT DISTINCT [Order ID] FROM deleted

	OPEN DeltedOrdersCursorVar
	FETCH FIRST FROM DeltedOrdersCursorVar
	INTO @OrderID

	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF((SELECT COUNT(*) FROM [Dishes Order] WHERE [Order ID] = @OrderID) = 0)
		BEGIN

			DELETE FROM [Order] 
				WHERE [Order].ID = @OrderID

		END

		FETCH NEXT FROM DeltedOrdersCursorVar
		INTO @OrderID

	END
	CLOSE DeltedOrdersCursorVar
	DEALLOCATE DeltedOrdersCursorVar
END

GO


CREATE OR ALTER TRIGGER UpdateStatusMessage ON [Order]
AFTER UPDATE
AS
BEGIN
	DECLARE @Order int, @Status int, @Client int;
	DECLARE MessageOnOrderCursor CURSOR
	SCROLL
	FOR SELECT inserted.[ID], inserted.[Status], inserted.[Client] FROM inserted JOIN deleted ON inserted.[Status] != deleted.[Status]

	OPEN MessageOnOrderCursor

	FETCH FIRST FROM MessageOnOrderCursor
		INTO @Order, @Status, @Client

	WHILE(@@FETCH_STATUS = 0)
	BEGIN
	
		IF(@Status BETWEEN 1 AND 5) 
		BEGIN
			DECLARE @Message nvarchar(50);

			SELECT @Message = CASE @Status
				WHEN 1 THEN 'Order#' + CONVERT(varchar(10), @Order) + ' is processing'
				WHEN 2 THEN 'Order#' + CONVERT(varchar(10), @Order) + ' is beeing prepared'
				WHEN 3 THEN 'Order#' + CONVERT(varchar(10), @Order) + ' is beeing delivered'
				WHEN 4 THEN 'Order#' + CONVERT(varchar(10), @Order) + ' is complited'
				WHEN 5 THEN 'Order#' + CONVERT(varchar(10), @Order) + ' is canceled'
			END

			INSERT INTO Notifications([Client ID],[Value]) VALUES(@Client, @Message);

		END

		FETCH NEXT FROM MessageOnOrderCursor
			INTO @Order, @Status, @Client

	END
	CLOSE MessageOnOrderCursor
	DEALLOCATE MessageOnOrderCursor
END

GO

CREATE OR ALTER TRIGGER DestroyOrderAfterAddressHide ON [Client Address]
AFTER UPDATE
AS
BEGIN
	BEGIN TRY
		DECLARE @Address int;
		DECLARE AddressCursor CURSOR
		SCROLL
		FOR SELECT [ID] FROM inserted WHERE Active = 0

		OPEN AddressCursor
		FETCH FIRST FROM AddressCursor
		INTO @Address

		WHILE(@@FETCH_STATUS = 0)
		BEGIN
			DECLARE @Order int;
			DECLARE @Status int;
			DECLARE OrdersCursor CURSOR
			SCROLL
			FOR SELECT ID, [Status] FROM [Order] WHERE [Client Address] = @Address

			OPEN OrdersCursor
			FETCH FIRST FROM OrdersCursor
				INTO @Order, @Status

			WHILE(@@FETCH_STATUS = 0)
			BEGIN

				IF (@Status = 0)
					THROW 50013, 'Current order address can''not be deleted', 1

				FETCH NEXT FROM OrdersCursor
					INTO @Order, @Status

			END
			CLOSE OrdersCursor
			DEALLOCATE OrdersCursor

			FETCH NEXT FROM AddressCursor
				INTO @Address

		END
		CLOSE AddressCursor
		DEALLOCATE AddressCursor
	END TRY
	BEGIN CATCH

		IF CURSOR_STATUS('variable', '@OrdersCursor') >= 0 
			CLOSE OrdersCursor;
    
		DEALLOCATE OrdersCursor;

		IF CURSOR_STATUS('variable', '@AddressCursor') >= 0 
			CLOSE AddressCursor;
    
		DEALLOCATE AddressCursor;

		
		THROW;

	END CATCH
END
GO
USE Delivery
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
			) > 1) 
			SET @FoundDifferentProds = 1

		FETCH NEXT FROM OrderCursorVar
		INTO @Order
	END
	CLOSE OrderCursorVar
	DEALLOCATE OrderCursorVar
	IF (@FoundDifferentProds != 0) ROLLBACK TRAN;
END
GO

CREATE OR ALTER TRIGGER OnlyOneOpenedOrder ON [Order]
AFTER INSERT
AS
BEGIN
	IF ((
	SELECT COUNT(*)
		FROM [Order] JOIN inserted ON [Order].[Client Login] = inserted.[Client Login]
		WHERE [Order].[Ordered At] IS NULL AND [Order].[Status] = 0
	) > 1) ROLLBACK TRAN;
		
END

GO

CREATE OR ALTER TRIGGER ClearOrderOnEmpty ON "Dishes Order"
AFTER DELETE
AS
BEGIN
	BEGIN TRAN

	DECLARE @OrderID int;
	DECLARE DeltedOrdersCursorVar CURSOR
	SCROLL
	FOR SELECT DISTINCT [Order ID] FROM deleted

	OPEN DeltedOrdersCursorVar
	FETCH FIRST FROM DeltedOrdersCursorVar
	INTO @OrderID

	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		BEGIN TRAN
		IF((SELECT COUNT(*) FROM [Dishes Order] WHERE [Order ID] = @OrderID) = 0)
		BEGIN

			DELETE FROM [Order] 
				WHERE [Order].ID = @OrderID

			IF @@ERROR = 0 AND @@ROWCOUNT = 1
				COMMIT TRAN
			ELSE
				ROLLBACK TRAN

		FETCH NEXT FROM DeltedOrdersCursorVar
		INTO @OrderID

		END
	END
	CLOSE DeltedOrdersCursorVar
	DEALLOCATE DeltedOrdersCursorVar
END
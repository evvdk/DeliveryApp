
USE Delivery
GO

CREATE OR ALTER PROCEDURE RegisterClient(@login nvarchar(30), @password char(64), @name nvarchar(20), @phone PhoneNumber, @email nvarchar(50))
AS
BEGIN
	BEGIN TRY

		IF EXISTS (SELECT * FROM Client WHERE Login = @login)
			THROW 50000, 'Login already exists', 1;
		IF EXISTS (SELECT * FROM Client WHERE Phone = @phone)
			THROW 50001, 'Phone already used', 1;
		IF NOT (@phone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR
				@phone LIKE '8[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
			THROW 50002, 'Phone doesn''t match pattern', 1;
		IF NOT (@email LIKE '%[_a-zA-Z0-9.-]%@%[_a-zA-Z0-9.-]%.[a-zA-Z][a-zA-Z]%')
			THROW 50003, 'Email doesn''t match pattern', 1;
	
		BEGIN TRAN

			INSERT INTO Client(Login,Password,Name,Phone,Email)
				VALUES (@login, @password, @name, @phone, @email);

		COMMIT TRAN
	
	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

-- EXEC RegisterClient 'Alex', 'dijcfweilfd', 'Aleksandr', '+79605702154', NULL

GO

CREATE OR ALTER PROCEDURE DeleteClient(@login nvarchar(30), @password char(64))
AS
BEGIN
	BEGIN TRY
	
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password)
			THROW 50004, 'Client with login doesn''t exists', 1;

		BEGIN TRAN

			UPDATE Client
				SET [Active Account] = 0
				WHERE Login = @login AND Password = @password AND [Active Account] = 1

		COMMIT TRAN
	
	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

GO

-- EXEC DeleteClient 'Alex', 'dijcfweilfd'

CREATE OR ALTER PROCEDURE ChangeClientPassword(@login nvarchar(30), @oldPassword char(64), @newPassword char(64))
AS
BEGIN

	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @oldPassword AND [Active Account] = 1)
			THROW 50004, 'Client with login doesn''t exists', 1;
	
		BEGIN TRAN

			UPDATE Client
				SET Password = @newPassword
				WHERE Login = @login AND Password = @oldPassword AND [Active Account] = 1
	
		COMMIT TRAN
	
	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

-- EXEC ChangeClientPassword 'Alex', 'dijcfweilfd', 'hihihihi'

GO

CREATE OR ALTER PROCEDURE AddClientAddress(@login nvarchar(30), @password char(64),  @region nvarchar(50), @city nvarchar(50), @district nvarchar(50),
		@street nvarchar(50), @building nvarchar(10), @floor int, @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50004, 'Client with login doesn''t exists', 1;
	
		BEGIN TRAN

			INSERT INTO [Client Address] ([Client Login], Region, City, District, Street, Building, [Floor], Room)
				VALUES (@login, @region, @city, @district, @street, @building, @floor, @room)

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

-- EXEC AddClientAddress 'Alex', 'hihihihi', 'lkdscsjhks', 'lkvjsdid', 'dsichsjck','dicihdk','56',5,'656'

GO

CREATE OR ALTER PROCEDURE DeleteClientAddress(@addressID int, @login nvarchar(30), @password char(64))
AS
BEGIN

	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50004, 'Client with login doesn''t exists', 1;
		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE [Client Login] = @login AND ID = @addressID AND Active = 1)
			THROW 50005, 'Client with address doesn''t exists', 1;

		BEGIN TRAN

			UPDATE [Client Address]
				SET Active = 0
				WHERE [Client Login] = @login AND ID = @addressID AND Active = 1

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
	
END

--EXEC DeleteClientAddress 1, 'Alex', 'hihihihi'

GO

CREATE OR ALTER PROCEDURE AddToOrder(@login nvarchar(30), @addressID int, @dishID int, @dishCount int)
AS
BEGIN

	BEGIN TRY

		BEGIN TRAN

			INSERT INTO [Orders View]([Client Login],[Client Address ID],[Dish ID],[Count])
			VALUES (@login, @addressID, @dishID, @dishCount)

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END
GO

-- EXEC AddToOrder 'Alex', 1, 1, 1
-- EXEC AddToOrder 'Alex', 1, 4, 1
-- EXEC AddToOrder 'Alex', 1, 4, 5 -- summ
-- EXEC AddToOrder 'Alex', 1, 5, 1 -- error

GO

CREATE OR ALTER PROCEDURE DeleteFromOrder(@login nvarchar(30),  @dishID int)
AS
BEGIN
	BEGIN TRY

		BEGIN TRAN

			DELETE FROM [Orders View]
				WHERE [Client Login] = @login AND [Dish ID] = @dishID
	
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;

		THROW;

	END CATCH

END
GO

-- DeleteFromOrder 'Alex', 4

CREATE OR ALTER PROCEDURE ApplyOrder(@login nvarchar(30))
AS
BEGIN
	BEGIN TRY

	DECLARE @openedOrderID int;
	SELECT @openedOrderID = ID FROM [Order] WHERE [Client Login] = @login AND [Ordered At] IS NULL AND [Status] = 0
	IF (@openedOrderID IS NULL) -- if unassembeld order doesn't exists
		THROW 50006, 'Вы ничего не добавили в корзиру', 1;
	
		BEGIN TRAN
			UPDATE [Order]
				SET [Ordered At] = GETDATE(), [Status] = 1
				WHERE ID = @openedOrderID
	
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;

		THROW;

	END CATCH
END

-- EXEC ApplyOrder 'Alex'
GO


USE Delivery
GO

CREATE OR ALTER PROCEDURE RegisterClient(@login nvarchar(30), @password binary(32), @name nvarchar(20), @phone PhoneNumber, @email nvarchar(50))
AS
BEGIN
	BEGIN TRY

		IF NOT(LEN(@login) BETWEEN 5 AND 30) 
			THROW 50000, 'Login should be more than 5 and less than 30 letters', 1;

		IF EXISTS (SELECT * FROM Client WHERE Login = @login)
			THROW 50001, 'Login already exists', 1;

		IF NOT(LEN(@name) BETWEEN 3 AND 20) 
			THROW 50002, 'Name should be more than 2 and less than 20 letters', 1;

		IF EXISTS (SELECT * FROM Client WHERE Phone = @phone)
			THROW 50003, 'Phone already used', 1;		

		IF NOT (@phone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
			THROW 50004, 'Phone doesn''t match pattern', 1;

		IF NOT (@email LIKE '%[_a-zA-Z0-9.-]%@%[_a-zA-Z0-9.-]%.[a-zA-Z][a-zA-Z]%')
			THROW 50005, 'Email doesn''t match pattern', 1;
	
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
GO

CREATE OR ALTER PROCEDURE DeleteClient(@login nvarchar(30), @password binary(32))
AS
BEGIN
	BEGIN TRY
	
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

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

CREATE OR ALTER PROCEDURE ChangeClientLogin(@login nvarchar(30), @password binary(32), @newLogin nvarchar(30))
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

		IF EXISTS (SELECT * FROM Client WHERE Login = @newLogin)
			THROW 50001, 'User with this login already exist', 1;

		IF NOT(LEN(@newLogin) BETWEEN 5 AND 30)
			THROW 50000, 'Login should be more than 5 and less than 30 letters', 1;

		BEGIN TRAN

		UPDATE Client
			SET Login = @newLogin
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

CREATE OR ALTER PROCEDURE ChangeClientName(@login nvarchar(30), @password binary(32), @newName nvarchar(20))
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

		IF NOT(LEN(@newName) BETWEEN 3 AND 20) 
				THROW 50002, 'Name should be more than 2 and less than 20 letters', 1;		

		BEGIN TRAN

		UPDATE Client
			SET Name = @newName
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


CREATE OR ALTER PROCEDURE ChangeClientPhone(@login nvarchar(30), @password binary(32), @newPhone PhoneNumber)
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

		IF EXISTS (SELECT * FROM Client WHERE Phone = @newPhone)
			THROW 50003, 'Phone already used', 1;		

		IF NOT (@newPhone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
			THROW 50004, 'Phone doesn''t match pattern', 1;

		BEGIN TRAN

			UPDATE Client
				SET Phone = @newPhone
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


CREATE OR ALTER PROCEDURE ChangeClientEmail(@login nvarchar(30), @password binary(32), @newEmail nvarchar(50))
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

		IF NOT (@newEmail LIKE '%[_a-zA-Z0-9.-]%@%[_a-zA-Z0-9.-]%.[a-zA-Z][a-zA-Z]%')
			THROW 50005, 'Email doesn''t match pattern', 1;

		BEGIN TRAN
			UPDATE Client
				SET Email = @newEmail
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

CREATE OR ALTER PROCEDURE ChangeClientPassword(@login nvarchar(30), @oldPassword binary(32), @newPassword binary(32))
AS
BEGIN

	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @oldPassword AND [Active Account] = 1)
			THROW 50006, 'User dosn''t exist', 1;
	
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
GO

CREATE OR ALTER PROCEDURE AddClientAddress(@login nvarchar(30), @password binary(32), @city nvarchar(50), @district nvarchar(50),
		@street nvarchar(50), @building nvarchar(10), @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

		IF EXISTS (SELECT * FROM [Client Address] WHERE [Client ID] = @clientID AND City = @City AND 
									District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 1)
			THROW 50014, 'Address already exists', 1;

	
		BEGIN TRAN

			IF EXISTS (SELECT * FROM [Client Address] WHERE [Client ID] = @clientID AND City = @City AND 
									District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 0)
			BEGIN
				UPDATE [Client Address]
				SET Active = 1
				WHERE [Client ID] = @clientID AND City = @City AND District = @district 
							AND Street = @street AND Building = @building AND Room = @room AND Active = 0
			END
			ELSE
			BEGIN

				INSERT INTO [Client Address] ([Client ID],City, District, Street, Building, Room)
					VALUES (@clientID, @city, @district, @street, @building, @room)

			END

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END
GO

CREATE OR ALTER PROCEDURE EditClientAddress(@address int, @login nvarchar(30), @password binary(32),  @city nvarchar(50), 
		@district nvarchar(50), @street nvarchar(50), @building nvarchar(10), @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE Login = @login AND Password = @password AND [Active Account] = 1
	
		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE [Client ID] = @clientID AND ID = @address AND Active = 1)
			THROW 50007, 'Client with address doesn''t exists', 1;


		IF EXISTS (SELECT * FROM [Client Address] WHERE [Client ID] = @clientID AND City = @City AND 
									District = @district AND Street = @street AND Building = @building 
									AND Room = @room AND Active = 1 AND ID != @address)
			THROW 50014, 'Address already exists', 1;

		BEGIN TRAN

			UPDATE [Client Address]
				SET City = @city, District = @district, Street = @street, Building = @building, Room = @room
				WHERE ID = @address AND [Client ID] = @clientID AND [Active] = 1
 
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

GO

CREATE OR ALTER PROCEDURE DeleteClientAddress(@addressID int, @login nvarchar(30), @password binary(32))
AS
BEGIN

	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE [Client ID] = @clientID AND ID = @addressID AND Active = 1)
			THROW 50007, 'Client with address doesn''t exists', 1;

		BEGIN TRAN

			UPDATE [Client Address]
				SET Active = 0
				WHERE [Client ID] = @clientID AND ID = @addressID AND Active = 1

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
	
END

GO

CREATE OR ALTER PROCEDURE InitOrder(@login nvarchar(30), @addressID int)
AS
BEGIN
	BEGIN TRY
		
			
		IF NOT EXISTS(SELECT * FROM Client WHERE [Login] = @login AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE [Login] = @login AND [Active Account] = 1

		BEGIN TRAN
			INSERT INTO [Order] ([Client ID], [Client Address ID]) 
					VALUES (@ClientID, @AddressID);
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

GO

CREATE OR ALTER PROCEDURE AddToOrder(@OrderID int, @dishID int, @Count int)
AS
BEGIN

	BEGIN TRY

		IF NOT EXISTS(SELECT * FROM [Order] WHERE ID = @OrderID)
			THROW 50009, 'Order doesn''t exists', 1;

		BEGIN TRAN

			IF NOT EXISTS(SELECT * FROM [Dishes Order] WHERE [Dish ID] = @DishID AND [Order ID] = @OrderID)
			BEGIN
				INSERT INTO [Dishes Order] ([Dish ID],[Order ID],[Count])
					VALUES (@DishID, @OrderID, @Count)
			END
			ELSE 
			BEGIN
				UPDATE [Dishes Order]
					SET [Count] = [Count] + @Count
					WHERE [Dish ID] = @DishID AND [Order ID] = @OrderID
			END

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END
GO

GO

CREATE OR ALTER PROCEDURE DeleteFromOrder(@Order int, @dishID int)
AS
BEGIN
	BEGIN TRY

			IF NOT EXISTS(SELECT * FROM [Dishes Order] WHERE  [Order ID] = @Order AND [Dish ID] = @dishID)
				THROW 50012, 'Dish doesn''t found in order', 1;
		
		BEGIN TRAN
		
			IF((SELECT [Count] FROM [Dishes Order] WHERE [Order ID] = @Order AND [Dish ID] = @dishID) = 1)
			BEGIN

				DELETE FROM [Dishes Order]
					WHERE [Order ID] = @Order AND [Dish ID] = @DishID
			END
			ELSE 
			BEGIN
				UPDATE [Dishes Order]
					SET [Count] = [Count] - 1
					WHERE [Order ID] = @Order AND [Dish ID] = @DishID
			END
	
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;

		THROW;

	END CATCH

END
GO

CREATE OR ALTER PROCEDURE ApplyOrder(@Order int)
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS(SELECT * FROM [Order] WHERE ID = @Order AND [Ordered At] IS NULL AND [Status] = 0)
			THROW 50008, 'Order can''t be assembled', 1;
	
		BEGIN TRAN

			UPDATE [Order]
				SET [Ordered At] = GETDATE(), [Status] = 1
				WHERE ID = @Order
	
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;

		THROW;

	END CATCH
END
GO

CREATE OR ALTER PROC ChangeOrderAddress(@Order int, @Address int)
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE ID = @Address AND Active = 1)
			THROW 50007, 'Address doesn''t exists', 1;

		IF NOT EXISTS(SELECT * FROM [Order] WHERE ID = @Order)
			THROW 50009, 'Order doesn''t exists', 1;

		IF EXISTS(SELECT * FROM [Order] WHERE ID = @Order AND Status != 0)
			THROW 50012, 'Order already applied; Address unchangeable', 1;
		
		BEGIN TRAN

			UPDATE [Order]
				SET [Client Address ID] = @Address
				WHERE ID = @Order

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

GO
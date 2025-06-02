
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

-- EXEC RegisterClient 'UserLogin', 'Password', 'Name', '+77777777777', NULL
-- EXEC RegisterClient 'User', 'Password', 'Name', '+77777777777', NULL
-- EXEC RegisterClient 'UserLogin', 'Password', 'Name', '+77777777777', NULL

-- EXEC RegisterClient 'AnotherLogin', 'Password', 'Na', '+77777777771', NULL

-- EXEC RegisterClient 'AnotherLogin', 'Password', 'Name', '+77777777777', NULL
-- EXEC RegisterClient 'AnotherLogin', 'Password', 'Name', '+777777777', NULL

-- EXEC RegisterClient 'AnotherLogin', 'Password', 'Name', '+77777777772', 'MyEmail@mailru'

GO

CREATE OR ALTER PROCEDURE DeleteClient(@login nvarchar(30), @password binary(32))
AS
BEGIN
	BEGIN TRY
	
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password)
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


-- EXEC DeleteClient 'AnotherLogin', 'Password'
-- EXEC DeleteClient 'UserLogin', 'Password'

GO

CREATE OR ALTER PROCEDURE ChangeClientName(@login nvarchar(30), @password binary(32), @newName nvarchar(20))
AS
BEGIN
	BEGIN TRY

		IF NOT(LEN(@newName) BETWEEN 3 AND 20) 
				THROW 50002, 'Name should be more than 2 and less than 20 letters', 1;

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

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

		IF EXISTS (SELECT * FROM Client WHERE Phone = @newPhone)
			THROW 50003, 'Phone already used', 1;		

		IF NOT (@newPhone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
			THROW 50004, 'Phone doesn''t match pattern', 1;

		UPDATE Client
			SET Phone = @newPhone
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

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

		IF NOT (@newEmail LIKE '%[_a-zA-Z0-9.-]%@%[_a-zA-Z0-9.-]%.[a-zA-Z][a-zA-Z]%')
			THROW 50005, 'Email doesn''t match pattern', 1;

		UPDATE Client
			SET Email = @newEmail
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

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
			THROW 50006, 'Wrong old password', 1;
	
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

CREATE OR ALTER PROCEDURE AddClientAddress(@login nvarchar(30), @password binary(32), @region nvarchar(50), @city nvarchar(50), @district nvarchar(50),
		@street nvarchar(50), @building nvarchar(10), @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;	


		IF EXISTS (SELECT * FROM [Address By Login] WHERE [Login] = @login AND Region = @region AND City = @city AND -- if this user have it enabled
									District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 1)
			THROW 50014, 'Address already exists', 1;
		
		BEGIN TRAN
			
			IF EXISTS (SELECT * FROM [Address By Login] WHERE [Login] = @login AND Region = @region AND City = @City AND -- if this user have it disabled
									District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 0)
			BEGIN
				DECLARE @AddressID int;

				SELECT @AddressID = ID FROM [Address By Login] WHERE [Login] = @login AND Region = @region AND City = @City AND
									District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 0;

				UPDATE [Client Address] 
				SET Active = 1
				WHERE ID = @AddressID

			END
			ELSE 
			BEGIN
				DECLARE @tmp int;
				
				IF NOT EXISTS (SELECT * FROM Region WHERE Region = @region)
				BEGIN
					INSERT INTO Region(Region) VALUES(@region);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM Region WHERE Region = @region
				END

				IF NOT EXISTS (SELECT * FROM City WHERE City = @City AND Region = @tmp)
				BEGIN
					INSERT INTO City(City, Region) VALUES(@city, @tmp);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM City WHERE City = @City AND Region = @tmp
				END

				IF NOT EXISTS (SELECT * FROM City WHERE City = @City AND Region = @tmp)
				BEGIN
					INSERT INTO City(City, Region) VALUES(@city, @tmp);
						SET @tmp = SCOPE_IDENTITY();
					END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM City WHERE City = @City AND Region = @tmp
				END
				
				IF NOT EXISTS (SELECT * FROM District WHERE District = @district AND City = @tmp)
				BEGIN
					INSERT INTO District(District, City) VALUES(@district, @tmp);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM District WHERE District = @district AND City = @tmp
				END
				
				IF NOT EXISTS (SELECT * FROM Street WHERE Street = @street AND District = @tmp)
				BEGIN
					INSERT INTO Street(Street, District) VALUES(@street, @tmp);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM Street WHERE Street = @street AND District = @tmp
				END

				IF NOT EXISTS (SELECT * FROM Building WHERE Building = @building AND Street = @tmp)
				BEGIN
					INSERT INTO Building(Building, Street) VALUES(@building, @tmp);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM Building WHERE Building = @building AND Street = @tmp
				END
				
				IF NOT EXISTS (SELECT * FROM Room WHERE Room = @room AND Building = @tmp)
				BEGIN
					INSERT INTO Room(Room, Building) VALUES(@room, @tmp);
						SET @tmp = SCOPE_IDENTITY();
				END
				ELSE
				BEGIN
					SELECT @tmp = ID FROM Room WHERE Room = @room AND Building = @tmp
				END
				
				DECLARE @Client int;
				SELECT @Client = ID FROM Client WHERE Login = @login
				INSERT INTO [Client Address](Client, Room) VALUES(@Client, @tmp);

			END
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

--EXEC AddClientAddress 'Irina',0x48656C6C6F000000000000000000000000000000000000000000000000000000, 'Ryazan Oblsati', 'Ryazan', 'Diadkovo','1th Boluvar','56','66'
GO

CREATE OR ALTER PROCEDURE EditClientAddress(@address int, @login nvarchar(30), @password binary(32),  @region nvarchar(50), @city nvarchar(50), 
		@district nvarchar(50), @street nvarchar(50), @building nvarchar(10), @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE Login = @login AND Password = @password AND [Active Account] = 1
	
		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE [Client] = @clientID AND ID = @address AND Active = 1)
			THROW 50007, 'Client with address doesn''t exists', 1;

		IF EXISTS (SELECT * FROM [Address By Login] WHERE [Login] = @login AND Region = @region AND City = @City AND
					District = @district AND Street = @street AND Building = @building AND Room = @room AND Active = 1 AND ID != @address)
			THROW 50014, 'Address already exists', 1;

		BEGIN TRAN

			UPDATE [Client Address]
			SET Active = 0
			WHERE ID = @address AND [Client] = @clientID AND [Active] = 1

			EXEC AddClientAddress @login,@password, @region, @city, @district, @street, @building, @room
 
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END
--EXEC EditClientAddress 9, 'Irina', 0x48656C6C6F000000000000000000000000000000000000000000000000000000, 'Ryazan Ob', 'Ryazan', 'Diadkovo','1th Boluvar','56','66'
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

		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE [Client] = @clientID AND ID = @addressID AND Active = 1)
			THROW 50007, 'Client with address doesn''t exists', 1;

		BEGIN TRAN

			UPDATE [Client Address]
				SET Active = 0
				WHERE [Client] = @clientID AND ID = @addressID AND Active = 1

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

CREATE OR ALTER PROCEDURE InitOrder(@login nvarchar(30), @addressID int)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF NOT EXISTS(SELECT * FROM Client WHERE [Login] = @login AND [Active Account] = 1)
				THROW 50006, 'Client with login doesn''t exists', 1;

			DECLARE @clientID int;
			SELECT @clientID = ID FROM Client
				WHERE [Login] = @login AND [Active Account] = 1

			INSERT INTO [Order] ([Client], [Client Address]) 
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

CREATE OR ALTER PROCEDURE SetAddressToOpenedOrder(@login nvarchar(30), @addressID int)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF NOT EXISTS(SELECT * FROM Client WHERE [Login] = @login AND [Active Account] = 1)
				THROW 50006, 'Client with login doesn''t exists', 1;


			DECLARE @clientID int;
			SELECT @clientID = ID FROM Client
				WHERE [Login] = @login AND [Active Account] = 1

			IF NOT EXISTS(SELECT * FROM [Order] WHERE Client = @ClientID AND [Status] = 0)
				THROW 50009, 'Order doesn''t exists', 1;

			UPDATE [Order]
			SET [Client Address] = @addressID
			WHERE Client = @ClientID AND [Status] = 0

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

-- EXEC AddToOrder 'UserLogin', 1, 11, 1
-- EXEC AddToOrder 'UserLogin', 1, 12, 1
-- EXEC AddToOrder 'UserLogin', 1, 11, 5 -- summ
-- EXEC AddToOrder 'UserLogin', 1, 13, 1 -- error

GO

CREATE OR ALTER PROCEDURE DeleteFromOrder(@Order int, @dishID int)
AS
BEGIN
	BEGIN TRY

		BEGIN TRAN

			IF NOT EXISTS(SELECT * FROM [Dishes Order] WHERE  [Order ID] = @Order AND [Dish ID] = @dishID)
				THROW 50012, 'Dish doesn''t found in order', 1;
			
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

-- DeleteFromOrder 'Alex', 4

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

-- EXEC ApplyOrder 'Alex'
GO

CREATE OR ALTER PROC ChangeOrderAddress(@Order int, @Address int)
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM [Client Address] WHERE ID = @Address AND Active = 1)
			THROW 50007, 'Dddress doesn''t exists', 1;

		IF NOT EXISTS(SELECT * FROM [Order] WHERE ID = @Order)
			THROW 50009, 'Order doesn''t exists', 1;

		IF EXISTS(SELECT * FROM [Order] WHERE ID = @Order AND Status != 0)
			THROW 50012, 'Order already applied; Address unchangeable', 1;
		
		BEGIN TRAN

		UPDATE [Order]
			SET [Client Address] = @Address
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
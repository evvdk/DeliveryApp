
USE Delivery
GO

CREATE OR ALTER PROCEDURE RegisterClient(@login nvarchar(30), @password char(64), @name nvarchar(20), @phone PhoneNumber, @email nvarchar(50))
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

CREATE OR ALTER PROCEDURE DeleteClient(@login nvarchar(30), @password char(64))
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

CREATE OR ALTER PROCEDURE ChangeClientLogin(@login nvarchar(30), @password char(64), @newLogin nvarchar(30))
AS
BEGIN
	BEGIN TRY

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;

		IF EXISTS (SELECT * FROM Client WHERE Login = @newLogin)
			THROW 50001, 'User with this login already exist', 1;

		IF NOT(LEN(@login) BETWEEN 5 AND 30) 
			THROW 50000, 'Login should be more than 5 and less than 30 letters', 1;

		UPDATE Client
			SET Login = @newLogin
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH


END


-- EXEC DeleteClient 'AnotherLogin', 'Password'
-- EXEC DeleteClient 'UserLogin', 'Password'\

GO

CREATE OR ALTER PROCEDURE ChangeClientName(@login nvarchar(30), @password char(64), @newName nvarchar(20))
AS
BEGIN
	BEGIN TRY

		IF NOT(LEN(@newName) BETWEEN 3 AND 20) 
				THROW 50002, 'Name should be more than 2 and less than 20 letters', 1;

		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'User doesn''t exist', 1;		

		UPDATE Client
			SET Name = @newName
			WHERE Login = @login AND Password = @password AND [Active Account] = 1

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH


END

GO


CREATE OR ALTER PROCEDURE ChangeClientPhone(@login nvarchar(30), @password char(64), @newPhone PhoneNumber)
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


CREATE OR ALTER PROCEDURE ChangeClientEmail(@login nvarchar(30), @password char(64), @newEmail nvarchar(50))
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

CREATE OR ALTER PROCEDURE ChangeClientPassword(@login nvarchar(30), @oldPassword char(64), @newPassword char(64))
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

CREATE OR ALTER PROCEDURE AddClientAddress(@login nvarchar(30), @password char(64),  @region nvarchar(50), @city nvarchar(50), @district nvarchar(50),
		@street nvarchar(50), @building nvarchar(10), @floor int, @room nvarchar(10))
AS
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Client WHERE Login = @login AND Password = @password AND [Active Account] = 1)
			THROW 50006, 'Client with login doesn''t exists', 1;

		DECLARE @clientID int;
		SELECT @clientID = ID FROM Client
			WHERE Login = @login AND Password = @password AND [Active Account] = 1
	
		BEGIN TRAN

			INSERT INTO [Client Address] ([Client ID], Region, City, District, Street, Building, [Floor], Room)
				VALUES (@clientID, @region, @city, @district, @street, @building, @floor, @room)

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		IF @@TRANCOUNT > 0
			ROLLBACK TRAN;
		THROW;

	END CATCH
END

-- EXEC AddClientAddress 'UserLogin', 'e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a', 'Ryazan Oblsat', 'Ryazan', 'Diadkovo','1th Boluvar','56',5,'656'

GO

CREATE OR ALTER PROCEDURE DeleteClientAddress(@addressID int, @login nvarchar(30), @password char(64))
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

--EXEC DeleteClientAddress 1, 'Alex', 'hihihihi'

GO

CREATE OR ALTER PROCEDURE AddToOrder(@login nvarchar(30), @addressID int, @dishID int, @dishCount int)
AS
BEGIN

	BEGIN TRY

		BEGIN TRAN

			DECLARE @clientID int;
			SELECT @clientID = ID FROM Client
				WHERE Login = @login AND [Active Account] = 1

			INSERT INTO [Orders View]([Client ID],[Client Address ID],[Dish ID],[Count])
			VALUES (@clientID, @addressID, @dishID, @dishCount)

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

CREATE OR ALTER PROCEDURE DeleteFromOrder(@login nvarchar(30),  @dishID int)
AS
BEGIN
	BEGIN TRY

		BEGIN TRAN

			DECLARE @clientID int;
			SELECT @clientID = ID FROM Client
				WHERE Login = @login AND [Active Account] = 1

			DELETE FROM [Orders View]
				WHERE [Client ID] = @clientID AND [Dish ID] = @dishID
	
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

		DECLARE @clientID int;
			SELECT @clientID = ID FROM Client
				WHERE Login = @login AND [Active Account] = 1	

		DECLARE @openedOrderID int;
		SELECT @openedOrderID = ID FROM [Order] WHERE [Client ID] = @clientID AND [Ordered At] IS NULL AND [Status] = 0
		IF (@openedOrderID IS NULL)
			THROW 50008, 'Order is empty', 1;
	
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

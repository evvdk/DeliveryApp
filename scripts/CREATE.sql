USE master
CREATE DATABASE Delivery
ON
(NAME = 'Delivery',FILENAME = 'C:\Databases\Delivery.mdf',SIZE = 1,MAXSIZE = 10,FILEGROWTH = 1)
LOG ON
(NAME = 'Delivery_log',FILENAME = 'C:\Databases\Delivery_log.ldf',SIZE = 1,MAXSIZE = 5,FILEGROWTH = 1)
GO

USE Delivery
GO

CREATE TYPE PhoneNumber
FROM char(12)
GO

CREATE RULE PhoneTamplate
AS @value LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO

EXEC sp_bindrule 'PhoneTamplate', 'PhoneNumber';
GO

CREATE TYPE GradeValue
FROM smallint
GO

CREATE RULE GradeRange
AS @value BETWEEN 0 AND 5
GO

EXEC sp_bindrule 'GradeRange', 'GradeValue';
GO


CREATE RULE EmailTemplate
AS @value LIKE '%[_a-zA-Z0-9.-]%@%[_a-zA-Z0-9.-]%.[a-zA-Z][a-zA-Z]%'
GO

CREATE DEFAULT RightNow
AS GETDATE()
GO

CREATE DEFAULT DefaultOneValue
AS 1
GO

CREATE DEFAULT DefaultZeroValue
AS 0
GO

-- Client
CREATE TABLE "Client"
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Login nvarchar(30) NOT NULL,
	Password binary(32) NOT NULL,
    Name nvarchar(20) NOT NULL,
    Phone PhoneNumber NOT NULL,
    Email nvarchar(50),
	Created datetime NOT NULL,
	"Active Account" tinyint NOT NULL,
	CONSTRAINT "C_Unique_Phones" UNIQUE ("Phone"),
	CONSTRAINT "C_Unique_Login" UNIQUE ("Login")
);

EXEC sp_bindefault 'RightNow', 'Client.Created'
EXEC sp_bindefault 'DefaultOneValue', 'Client.Active Account'
GO

-- Client Address
CREATE TABLE "Client Address"
(
    [ID] int IDENTITY(1, 1) NOT NULL,
	[Client ID] int NOT NULL,
    City nvarchar(50) NOT NULL,
    District nvarchar(50) NOT NULL,
    Street nvarchar(50) NOT NULL,
    Building nvarchar(6) NOT NULL,
    Room nvarchar(5) NOT NULL,
	Active tinyint,
    CONSTRAINT "C_PK_ClientAddress_Address" PRIMARY KEY ("ID"),
	
	CONSTRAINT "C_Unique_ClientAdress" UNIQUE ("Client ID", "City", "District", "Street", "Building", "Room"),
	
	CONSTRAINT "C_FK_Login" FOREIGN KEY ("Client ID")
        REFERENCES "Client" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

EXEC sp_bindefault 'DefaultOneValue', 'Client Address.Active'

-- Producer
CREATE TABLE "Producer"
(
    "ID" int IDENTITY(1, 1) NOT NULL,
	"Login" nvarchar(30) NOT NULL,
	"Password" binary(32) NOT NULL,
    "Name" nvarchar(30) NOT NULL,
	"Grade" GradeValue,
    "City" nvarchar(50) NOT NULL,
    "District" nvarchar(50) NOT NULL,
    "Street" nvarchar(50) NOT NULL,
    "Building" nvarchar(6) NOT NULL,
    "Room" nvarchar(5) NOT NULL,
    CONSTRAINT "C_PK_ProducerID" PRIMARY KEY ("ID"),
	CONSTRAINT "C_U_Login" UNIQUE ("Login")
);

-- Status
CREATE TABLE "Status"
(
    "ID" smallint NOT NULL,
    "Value" nvarchar(50) NOT NULL,
    CONSTRAINT "C_PK_StatusID" PRIMARY KEY ("ID")
);

-- Courier
CREATE TABLE "Courier"
(
    "ID" int IDENTITY(1, 1) NOT NULL,
    "First Name" nvarchar(30) NOT NULL,
    "Second Name" nvarchar(30) NOT NULL,
    "Last Name" nvarchar(30) NOT NULL,
	"Phone" PhoneNumber NOT NULL,
    "Passport Number" char(10) NOT NULL,
    "Work Book" char(7) NOT NULL,
    CONSTRAINT "C_CourierID" PRIMARY KEY ("ID"),
	CONSTRAINT "C_U_Passport_Number" UNIQUE ("Passport Number"),
	CONSTRAINT "C_U_Work_Book" UNIQUE ("Work Book")
);

-- ProducerDishes
CREATE TABLE "Dish"
(
    "ID" int IDENTITY(1, 1) NOT NULL,
	"Producer ID" int NOT NULL,
    "Name" nvarchar(50) NOT NULL,
	"Image" varbinary(MAX),
	"Cost" money NOT NULL,
    "Description" nvarchar(100),
    "Calories" int NOT NULL,
    "Mass" int NOT NULL,
	"Visible" tinyint,
    CONSTRAINT "C_PK_DishID" PRIMARY KEY ("ID"),
	CONSTRAINT "C_U_Dish" UNIQUE ("Name", "Producer ID"),
	CONSTRAINT "C_FK_ProducerID_Producer ID" FOREIGN KEY ("Producer ID")
        REFERENCES Producer ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

EXEC sp_bindefault 'DefaultOneValue', 'Dish.Visible'

-- Order
CREATE TABLE "Order"
(
    "ID" int IDENTITY(1, 1) NOT NULL,
	"Client ID" int NOT NULL,
	"Client Address ID" int NOT NULL,
    "Ordered At" datetime,
	"Complited At" datetime,
	"Status" smallint NOT NULL,
	"Order Grade" GradeValue,
    CONSTRAINT "C_PK_Order" PRIMARY KEY ("ID"),
	
	CONSTRAINT "C_FK_OrderStatus" FOREIGN KEY ("Status")
        REFERENCES "Status" ("ID") 
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,

	CONSTRAINT "C_FK_Client_Address" FOREIGN KEY ("Client Address ID")
        REFERENCES "Client Address" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE,

	CONSTRAINT "C_FK_Client" FOREIGN KEY ("Client ID")
        REFERENCES "Client" ("ID")
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);

EXEC sp_bindefault 'DefaultZeroValue', 'Order.Status'
GO

CREATE TABLE "Order Courier"
(
	"Order ID" int NOT NULL,
	"Courier ID" int NOT NULL,

	CONSTRAINT "C_PK_Order_Courier" PRIMARY KEY ("Order ID"),

	CONSTRAINT "C_FK_Order" FOREIGN KEY ("Order ID")
        REFERENCES "Order" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE,

	CONSTRAINT "C_FK_Courier" FOREIGN KEY ("Courier ID")
        REFERENCES "Courier" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE,
)

-- Dishes-Order
CREATE TABLE "Dishes Order"
(
    "Order ID" int NOT NULL,
	"Dish ID" int NOT NULL,
	"Count" integer NOT NULL,
    CONSTRAINT "C_PK_DishID_OrderID" PRIMARY KEY ("Dish ID", "Order ID"),
    CONSTRAINT "C_FK_Dishes" FOREIGN KEY ("Dish ID")
        REFERENCES "Dish" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    CONSTRAINT "C_FK_OrderID" FOREIGN KEY ("Order ID")
        REFERENCES "Order" ("ID")
        ON UPDATE CASCADE
		ON DELETE CASCADE,
);

EXEC sp_bindefault 'DefaultOneValue', 'Dishes Order.Count'

CREATE TABLE "Ingredient" 
(
	"Ingredient ID" int IDENTITY(1, 1) NOT NULL,
	"Ingredient Name" nvarchar(30) NOT NULL,
	CONSTRAINT "C_PK_Ingredient" PRIMARY KEY ("Ingredient ID"),
	CONSTRAINT "C_U_IngredientName" UNIQUE ("Ingredient Name")
);

CREATE TABLE "Dish Ingredients" 
(
	"Ingredient ID" int NOT NULL,
	"Dish ID" int NOT NULL,
	CONSTRAINT "C_PK_Dish_Ingredient" PRIMARY KEY ("Ingredient ID", "Dish ID"),
	CONSTRAINT "C_FK_Dish" FOREIGN KEY ("Dish ID")
        REFERENCES "Dish" ("ID")
        ON UPDATE CASCADE
		ON DELETE CASCADE,
	CONSTRAINT "C_FK_Ingredient" FOREIGN KEY ("Ingredient ID")
        REFERENCES "Ingredient" ("Ingredient ID")
        ON UPDATE CASCADE
		ON DELETE CASCADE
);
GO

CREATE TABLE Notifications
(
	"Client ID" int NOT NULL,
	"Value" nvarchar(50) NOT NULL,
	"Send" datetime NOT NULL,
	"Read" smallint NOT NULL,

	CONSTRAINT "C_PK_Notification" PRIMARY KEY ("Client ID", "Send", "Value"),

	CONSTRAINT "C_FK_NotifyClient" FOREIGN KEY ("Client ID")
        REFERENCES "Client" ("ID")
        ON UPDATE CASCADE
        ON DELETE CASCADE
)

EXEC sp_bindefault 'RightNow', 'Notifications.Send'
EXEC sp_bindefault 'DefaultZeroValue', 'Notifications.Read'
GO

INSERT INTO "Status" ("ID", "Value")
VALUES
(0,'Собирается'),
(1,'Обрабатывается'),
(2,'Готовится'),
(3,'Доставляется'),
(4,'Завершён'),
(5,'Отменён');

GO

CREATE TRIGGER StatusBlock ON Status
AFTER INSERT, UPDATE, DELETE
AS ROLLBACK TRAN;
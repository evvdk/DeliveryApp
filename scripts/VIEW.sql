
USE Delivery
GO

CREATE OR ALTER VIEW [Order Status Table]
AS
SELECT [Order].ID, Client.[Login] AS [Client Login],[Client Address],[Ordered At],[Complited At], [Status].ID AS [Status ID], [Status].Value AS [Status Value],[Order Grade]
  FROM ([Order] JOIN Status ON [Order].Status = Status.ID) JOIN Client ON [Order].[Client] = Client.ID

GO

CREATE OR ALTER VIEW [Address By Login]
AS
SELECT [Client Address].ID AS [ID], Client.ID AS [Client ID], Client.Login, Region.Region, City.City,District.District,Street.Street, Building.Building,
Room.Room, [Client Address].Active
FROM (((((((Client JOIN [Client Address] ON Client.ID = [Client Address].[Client]) 
		LEFT JOIN Room ON [Client Address].Room = Room.ID)
		LEFT JOIN Building ON Room.Building = Building.ID)
		LEFT JOIN Street ON Street.ID = Building.Street)
		LEFT JOIN District ON District.ID = Street.District)
		LEFT JOIN City ON City.ID = District.City)
		LEFT JOIN Region ON Region.ID = City.Region)
GO

CREATE OR ALTER VIEW [Order Set]
AS
SELECT [Order].ID AS [Order ID], Client.[Login] AS [Client Login], [Status] AS [Order Status],[Status].[Value] AS [Order Status Value], [Dish ID], [Count], Dish.[Name] As [Dish Name], Producer.[Name] AS [Producer Name], [Image], Cost, Mass, Calories, ([Count]*Cost) AS [Sum]
FROM (((([Order] RIGHT JOIN [Status] ON [Order].[Status] = [Status].ID)
RIGHT JOIN [Dishes Order] ON [Order].ID = [Dishes Order].[Order ID])
LEFT JOIN Dish ON [Dishes Order].[Dish ID] = Dish.ID) 
LEFT JOIN Client ON ([Order].[Client] = Client.ID)
LEFT JOIN Producer ON Dish.[Producer ID] = Producer.ID)

GO

CREATE OR ALTER VIEW [All Dishes]
AS
SELECT Dish.ID AS [Dish ID], Producer.ID AS [Producer ID], Dish.[Name] AS [Dish Name], [Image], Cost, [Description], Calories, Mass, Producer.[Name] AS [Producer Name]
FROM Dish LEFT JOIN Producer ON Dish.[Producer ID] = Producer.ID
WHERE Dish.Visible = 1
WITH CHECK OPTION

GO

CREATE OR ALTER VIEW [Order On Producer]
AS
SELECT DISTINCT [Order ID], [Producer ID], Producer.Name AS [Producer Name]
FROM ([Dishes Order] LEFT JOIN Dish ON [Dishes Order].[Dish ID]=Dish.ID) LEFT JOIN Producer ON Dish.[Producer ID] = Producer.ID

GO

CREATE OR ALTER VIEW [Dish All Info]
AS
SELECT Dish.ID, [Producer ID], Producer.Name AS [Producer Name], Dish.Name AS [Dish Name], Dish.Image, Dish.Cost, Dish.Calories, Dish.Description, Ingredient.[Ingredient Name]
FROM (Dish LEFT JOIN Producer ON Dish.[Producer ID] = Producer.ID) LEFT JOIN([Dish Ingredients] LEFT JOIN Ingredient ON [Dish Ingredients].[Ingredient ID] = Ingredient.[Ingredient ID]) 
ON [Dish Ingredients].[Dish ID] = Dish.Id

GO
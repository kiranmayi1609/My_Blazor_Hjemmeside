USE Master
GO 
CREATE DATABASE McDonald_Menu
GO
USE McDonald_Menu
GO
CREATE TABLE Menu (
Id INT Identity(1,1),
Item_Name NVARCHAR(255),
Price DECIMAL(10,2),
Amount INT
)
Go
Insert Into Menu(Item_Name, Price, Amount) VALUES('Burger', 30, 3)
Insert Into Menu (Item_Name, Price, Amount) VALUES('Sides &Dips', 50, 2)
Insert Into Menu(Item_Name, Price, Amount) VALUES('Kolddrikke', 15, 1)
Insert Into Menu (Item_Name, Price, Amount) VALUES('kaffe& kage ', 25, 1)
Insert Into Menu (Item_Name, Price, Amount) VALUES('Is', 25, 1)
Insert Into Menu (Item_Name, Price, Amount) VALUES('Croissant', 5, 20)
Insert Into Menu (Item_Name, Price, Amount) VALUES('Boller', 8, 20)

SELECT * FROM Menu
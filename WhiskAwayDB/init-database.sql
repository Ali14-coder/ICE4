USE master;
GO

-- Create the WhiskAwayDB database only if it does not already exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'WhiskAwayDB')
BEGIN
    CREATE DATABASE WhiskAwayDB;
END
GO

-- Switch to the WhiskAwayDB database
USE WhiskAwayDB;
GO

-- Create Product table
CREATE TABLE Product (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Type VARCHAR(50) NOT NULL,
    Image VARCHAR(255) NULL,
    Description TEXT NOT NULL
);

-- Create Customer table
CREATE TABLE Customer (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Surname VARCHAR(100) NOT NULL
);

-- Create Admin table
CREATE TABLE Admin (
    AdminId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Surname VARCHAR(100) NOT NULL
);

-- Create Order table
CREATE TABLE [Order] (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT NOT NULL,
    ProductId INT NOT NULL,
    DateTimePurchased DATETIME NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);

-- Insert sample data into Product
INSERT INTO Product (ProductName, Price, Type, Image, Description) VALUES
('Chocolate Cake', 120.00, 'Cake', NULL, 'Rich chocolate layered cake with fudge icing'),
('Croissant', 25.00, 'Pastry', NULL, 'Flaky buttery croissant perfect for breakfast'),
('Blueberry Muffin', 30.00, 'Muffin', NULL, 'Moist muffin with fresh blueberries'),
('Sourdough Bread', 45.00, 'Bread', NULL, 'Artisan sourdough loaf with crusty finish'),
('Strawberry Tart', 50.00, 'Tart', NULL, 'Tart with fresh strawberries and creamy filling');

-- Insert sample data into Customer
INSERT INTO Customer (Name, Surname) VALUES
('Hermione', 'Granger'),
('Ron', 'Weasley'),
('Harry', 'Potter'),
('Neville', 'Longbottom');

-- Insert sample data into Admin
INSERT INTO Admin (Name, Surname) VALUES
('Minerva', 'McGonagall'),
('Severus', 'Snape');

-- Insert sample data into Order
INSERT INTO [Order] (CustomerId, ProductId, DateTimePurchased) VALUES
(1, 2, '2025-04-09 09:30:00'),
(2, 1, '2025-04-09 10:15:00'),
(3, 5, '2025-04-10 14:05:00'),
(4, 3, '2025-04-10 16:20:00'),
(1, 4, '2025-04-10 17:45:00');
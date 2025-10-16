--José Sánchez
--Desarrollo de Software IV
--1GS-222


USE Northwind

--Ejemplo 1
SELECT * FROM Products;

--Ejemplo 2
SELECT ProductID, ProductName, UnitPrice From Products;

--Ejemplo 3
SELECT ProductID, ProductName, UnitPrice 
From Products
WHERE UnitPrice > 15;

--Ejemplo 4
SELECT ProductID, ProductName, UnitPrice 
From Products
WHERE UnitPrice > = 15 AND UnitPrice <=50;

--Ejemplo 5
SELECT ProductID, ProductName, UnitPrice 
From Products
WHERE UnitPrice BETWEEN 15 AND 50;

--Ejemplo 6
SELECT ProductID, ProductName, UnitPrice 
From Products
WHERE NOT UnitPrice > 15;

--Ejemplo 7
SELECT ProductID, ProductName, UnitPrice 
From Products
WHERE ProductID > 15 OR UnitPrice < 10;

--Ejemplo 8
SELECT EmployeeID , LastName From Employees
WHERE LastName LIKE 'D%'

--Ejemplo 9
SELECT EmployeeID, LastName
FROM Employees
WHERE LastName LIKE '%N';

--Ejemplo 10
SELECT EmployeeID, LastName, Title
FROM Employees
WHERE Title LIKE '%SALE%'

--Ejemplo 11
SELECT EmployeeID, LastName
FROM Employees
WHERE LastName NOT LIKE 'D%';

--Ejemplo 12
SELECT ProductID, ProductName, UnitPrice  FROM Products
ORDER BY ProductID ASC;

--Ejemplo 13
SELECT ProductID, ProductName, UnitPrice  
FROM Products
ORDER BY ProductID DESC;

--Ejemplo 14
SELECT DISTINCT OrderID FROM [Order Details];

--Ejemplo 15
SELECT TOP 5 OrderID, ProductID, Quantity
FROM [Order Details];

--Ejemplo 16
SELECT TOP 10 PERCENT OrderID, ProductID, Quantity
FROM [Order Details];

--Ejemplo 17
SELECT CategoryName AS [Nombre de Categoria]
FROM Categories

--Ejemplo 18
SELECT OrderID, OrderDate, ShippedDate, ShippedDate +5 AS RetrasoEnvio
FROM Orders

--Ejemplo 19
SELECT OrderID, P.ProductID, ProductName
From Products p
INNER JOIN [Order Details] OD 
ON p.ProductID=OD.ProductID

--Ejemplo 20
SELECT ProductName, CompanyName, ContactName
From Products P
FULL JOIN Suppliers S
ON P.SupplierID=S.SupplierID
USE AdventureWorks2019
GO

--Q1
SELECT COUNT(ProductID) as ProductCnt
FROM Production.Product

--Q2
SELECT COUNT(ProductID)
FROM Production.Product
WHERE ProductSubcategoryID is not null

--Q3
SELECT COUNT(ProductID) as ProductInSubCatCnt
FROM Production.Product p JOIN Production.ProductSubcategory ps ON p.ProductSubcategoryID = ps.ProductSubcategoryID

--Q4
SELECT COUNT(ProductID) as NoSubCatCnt
FROM Production.Product
WHERE ProductSubcategoryID is null

--Q5
SELECT SUM(Quantity) as TotalInventory
FROM Production.ProductInventory 

--Q6
SELECT ProductID, SUM(Quantity) as TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--Q7
SELECT Shelf, ProductID, SUM(Quantity) as TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--Q8
SELECT ProductID, AVG(Quantity) as AvgQnt
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--Q9
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--Q10
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf

--Q11
SELECT Color, Class, COUNT(ProductID) as TheCount, AVG(ListPrice) as AvgPrice
FROM Production.Product
WHERE (Class is not null and Color is not null)
GROUP BY Color, Class

--Q12
SELECT cr.Name as Country, sp.Name as Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp on cr.CountryRegionCode = sp.CountryRegionCode
ORDER BY Country

--Q13
SELECT cr.Name as Country, sp.Name as Province
FROM Person.CountryRegion cr JOIN Person.StateProvince sp on cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada')
ORDER BY Country

USE Northwind
GO

--Q14
SELECT DISTINCT p.ProductName
FROM Products p 
JOIN [Order Details] od ON p.ProductID = od.ProductID 
JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate > DATEADD(year, -25, GETDATE())

--Q15
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity)
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID 
JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

--Q16
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity)
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID 
JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate > DATEADD(year, -25, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

--Q17
SELECT City, COUNT(CustomerID) as CustomerCnt
FROM Customers
GROUP BY City

--Q18
SELECT City, COUNT(CustomerID) as CustomerCnt
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--Q19
SELECT DISTINCT c.ContactName
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1/1/1998'

--Q20
SELECT c.ContactName, dt.OrderDate
FROM Customers c
JOIN
(
SELECT CustomerID, OrderDate, RANK() OVER (PARTITION BY CustomerID ORDER BY OrderDate DESC) RNK
FROM Orders
) dt ON c.CustomerID = dt.CustomerID
WHERE dt.RNK = 1

--Q21
SELECT c.ContactName, COUNT(od.Quantity) as BuyCnt
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName


--Q22
SELECT c.CustomerID, COUNT(od.Quantity) as BuyCnt
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.Quantity) > 100

--Q23
SELECT DISTINCT s.CompanyName as "Supplier Company Name", s2.CompanyName as "Shipping Company Name"
FROM [Order Details] od
JOIN Products p ON od.ProductID = p.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Suppliers s ON p.SupplierID = s.SupplierID
JOIN Shippers s2 ON o.ShipVia = s2.ShipperID
ORDER BY s.CompanyName


--Q24
SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate

--Q25
SELECT e1.EmployeeID, e2.EmployeeID
FROM Employees e1
JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID != e2.EmployeeID AND e1.EmployeeID < e2.EmployeeID

--Q26
SELECT e1.EmployeeID, COUNT(e2.EmployeeID) as SubCnt
FROM Employees e1
FULL JOIN Employees e2 ON e2.ReportsTo = e1.EmployeeID
WHERE e1.EmployeeID is not NULL
GROUP BY e1.EmployeeID
HAVING COUNT(e1.EmployeeID) >= 2

--Q27
SELECT City, CompanyName, ContactName, 'Customer' as Type
FROM Customers
UNION
SELECT City, CompanyName, ContactName, 'Customer' as Type
FROM Suppliers
USE Northwind
GO

--Q1
SELECT DISTINCT City
FROM Customers
WHERE City IN (
	SELECT DISTINCT City
	FROM Employees
)


--Q2
--a)
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN(
	SELECT DISTINCT City
	FROM Employees
)
--b)
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City is NULL

--Q3
SELECT ProductID, SUM(Quantity) as TotalSold
FROM [Order Details]
GROUP BY ProductID


--Q4
SELECT DISTINCT City, (SELECT COUNT(OrderID) FROM Orders o WHERE o.ShipCity = c.CIty ) OrderCnt
FROM Customers c

--Q5
SELECT City, COUNT(CustomerID) "Customer Number"
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

--NOT SURE HOW TO DO WITH Union

--Q6
SELECT City
FROM Customers
WHERE CustomerID IN (
	SELECT CustomerID
	FROM Orders o
	JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY CustomerID
	HAVING COUNT(od.ProductID)>2
)


--Q7
SELECT DISTINCT c.CustomerID
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity

--Q8
SELECT TOP 5 c.City, od.ProductID, AVG(od.UnitPrice) "Average UnitPrice", SUM(od.Quantity) as "Sold Number"
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
--JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.City, od.ProductID
ORDER BY [Sold Number] DESC

--Q9
--a)
SELECT DISTINCT City
FROM Employees e
WHERE e.City NOT IN (
	SELECT DISTINCT City
	FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
)
--b)
SELECT e.City
FROM Employees e
LEFT JOIN Customers c ON c.City = e.City LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID is NULL

--Q10
SELECT TOP 1 sq1.City
FROM (
	SELECT c.City, COUNT(od.Quantity) as "Total Quantity"
	FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY c.City
	--ORDER BY "Total Quantity" DESC
) sq1
INNER JOIN
(
	SELECT o.EmployeeID, e.City, COUNT(OrderID) as "Order Count"
	FROM Orders o 
	JOIN Employees e ON o.EmployeeID = e.EmployeeID
	GROUP BY o.EmployeeID, e.City
	--ORDER BY [Order Count] DESC
) sq2 ON sq1.City = sq2.City
ORDER BY sq1.[Total Quantity], sq2.[Order Count]

--Q11
-- here we assume id should be unique, so we will delete duplicate rows with same id
USE Northwind
GO

DROP TABLE Employee
CREATE TABLE Employee (
    Id int,
    EName varchar(20) NOT NULL,
    Age int
)

INSERT INTO Employee
VALUES(4, 'Fred', 45)

INSERT INTO Employee
VALUES(1, 'Laura', 34)

INSERT INTO Employee
VALUES(3, 'Peter', 19)

INSERT INTO Employee
VALUES(2, 'Stella', 24)

INSERT INTO Employee
VALUES(1, 'Laura', 34)

WITH DuplicateCTE AS
(
	SELECT *, ROW_NUMBER() OVER (PARTITION BY ID ORDER BY ID) as RowNum
	FROM Employee
)
--SELECT * FROM DuplicateCTE
DELETE FROM DuplicateCTE WHERE RowNum > 1
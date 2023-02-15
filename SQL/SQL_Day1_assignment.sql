--Q1
select ProductID, [Name], Color, ListPrice
from Production.product

--Q2
select ProductID, [Name], Color, ListPrice
from Production.product
where ListPrice = 0

--Q3
select ProductID, [Name], Color, ListPrice
from Production.product
where Color is NULL

--Q4
select ProductID, [Name], Color, ListPrice
from Production.product
where Color is not NULL

--Q5
select ProductID, [Name], Color, ListPrice
from Production.product
where (Color is not Null and ListPrice > 0)

--Q6
select Color + ' ' + [Name]
from Production.product
where Color is not NULL

--Q7
select 'NAME: '+[Name]+ ' -- '+ color
from Production.Product
where color is not NULL

--Q8
select ProductID, [Name]
from Production.product
where ProductId BETWEEN 400 and 500

--Q9
select ProductID, [Name], Color
from Production.Product
where Color IN ('black', 'blue')

--Q10
select [Name]
from Production.Product
where [Name] like 'S%'

--Q11
select [Name], ListPrice
from Production.Product
where [Name] LIKE '[S]%'
order by [Name]

--Q12
select [Name], ListPrice
from Production.Product
where [Name] LIKE '[SA]%'
order by [Name]


--Q13
select [Name]
from Production.Product
where [Name] LIKE '[SPO][^K]%'
order by [Name]

--Q14
select Distinct Color
from Production.Product
order by Color DESC

--Q15
select DISTINCT CAST(pp.ProductSubcategoryID as varchar) + ' ' + pp.Color as Result
from Production.Product pp
where (pp.ProductSubcategoryID is not NULL and pp.Color is not NULL)
order by Result
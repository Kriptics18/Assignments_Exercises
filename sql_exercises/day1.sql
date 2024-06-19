USE AdventureWorks2019
GO

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter.
Select p.ProductID, p.Name, p.Color, p.ListPrice from Production.Product p;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, excludes the rows that ListPrice is 0
Select p.ProductID, p.Name, p.Color, p.ListPrice from Production.Product p where p.ListPrice <> 0;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column.
Select p.ProductID, p.Name, p.Color, p.ListPrice from Production.Product p where p.Color is null;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NOT NULL for the Color column.
Select p.ProductID, p.Name, p.Color, p.ListPrice from Production.Product p where p.Color is not null;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
Select p.ProductID, p.Name, p.Color, p.ListPrice from Production.Product p where p.Color is not null and p.ListPrice > 0;

--Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.
Select p.Name + ' ' + p.Color as NameColor from Production.Product p where p.Color is not null;

--Write a query that generates the following result set  from Production.Product
Select 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color as NameColor from Production.Product p where p.Color is not null;

--Write a query to retrieve the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500
Select p.ProductID, p.Name from Production.Product p where p.ProductID between 400 and 500;

--Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table restricted to the colors black and blue
Select p.ProductID, p.Name, p.Color from Production.Product p where p.Color IN ('Black', 'Blue');

--Write a query to get a result set on products that begins with the letter S.
Select p.ProductID, p.Name from Production.Product p where p.Name like 'S%';

--Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Order the result set by the Name column.
Select p.Name, p.ListPrice from Production.Product p order by p.Name;

--Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Order the result set by the Name column. The products name should start with either 'A' or 'S'
Select p.Name, p.ListPrice from Production.Product p where p.Name like 'A%' or p.Name like 'S%' order by p.Name;

--Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.
Select p.Name from Production.Product p where p.Name like 'SPO[^k]%' order by p.Name;

--Write a query that retrieves unique colors from the table Production.Product. Order the results in descending  manner
Select DISTINCT p.Color from Production.Product p where p.Color is not null order by p.Color desc;

-- Question 15 details missing for format and sort. Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. Format and sort so the result set accordingly to the following. We do not want any rows that are NULL.in any of the two columns in the result.
Select DISTINCT p.ProductSubcategoryID, p.Color from Production.Product p where p.Color is not null and p.ProductSubcategoryID is not null;
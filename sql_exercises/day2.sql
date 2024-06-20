--Assigment 2
USE AdventureWorks2019
GO

--How many products can you find in the Production.Product table?
Select Count(*) as TotalCount from Production.Product;

--Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory
Select Count(ProductSubcategoryID) as CountedProducts from Production.Product;

--How many Products reside in each SubCategory? Write a query to display the results with the following titles: ProductSubcategoryID CountedProducts
Select p.ProductSubcategoryID, Count(p.ProductSubcategoryID) as CountedProducts from Production.Product p GROUP BY p.ProductSubcategoryID;

--How many products that do not have a product subcategory
Select Count(p.ProductSubcategoryID) as NoCategoryProducts from Production.Product p where p.ProductSubcategoryID is null GROUP BY p.ProductSubcategoryID;

--Write a query to list the sum of products quantity in the Production.ProductInventory table.
Select Sum(p.Quantity) as TotalQuantity from Production.ProductInventory p;

--Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
Select p.ProductID, Sum(p.Quantity) as TheSum from Production.ProductInventory p where p.LocationID = 40 GROUP BY p.LocationID, p.ProductID having sum(p.Quantity) < 100;

--Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
Select p.Shelf, p.LocationID, p.ProductID, Sum(p.Quantity) as TheSum from Production.ProductInventory p where p.LocationID = 40 GROUP BY p.LocationID, p.ProductID, p.Shelf having sum(p.Quantity) < 100;

--Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table
Select p.LocationID, p.ProductID, avg(p.Quantity) as TheAvg from Production.ProductInventory p where p.LocationID = 10 GROUP BY p.LocationID, p.ProductID;

--Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
Select p.ProductID, p.Shelf, avg(p.Quantity) as TheAvg from Production.ProductInventory p where p.LocationID = 10 GROUP BY p.LocationID, p.ProductID, p.Shelf;

--Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
Select p.ProductID, p.Shelf, avg(p.Quantity) as TheAvg from Production.ProductInventory p where p.LocationID = 10 and p.Shelf <> 'N/A' GROUP BY p.LocationID, p.ProductID, p.Shelf;

--List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null
Select p.Color, p.Class, Count(p.ProductID) as TheCount, avg(p.ListPrice) as AvgPrice from Production.Product p where p.Class is not null and p.Color is not null group by p.Color, p.Class;

--Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following
Select cr.Name as Country, sp.Name as Province from Person.CountryRegion cr INNER JOIN Person.StateProvince sp on cr.CountryRegionCode = sp.CountryRegionCode where cr.Name in ('Germany', 'Canada');


--USING NORTHWIND NOW
USE northwind
GO

--List all Products that has been sold at least once in last 27 years.
Select distinct p.ProductID, p.ProductName, o.OrderDate from Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on o.OrderID = od.OrderID where o.OrderDate >= '1997-06-19';

--List top 5 locations (Zip Code) where the products sold most
Select Top 5 o.ShipPostalCode, SUM(od.Quantity) as TotalQuantity from Orders o join [Order Details] od on o.OrderID = od.OrderID group by o.ShipPostalCode order by TotalQuantity desc;

--List top 5 locations (Zip Code) where the products sold most in last 27 years
Select Top 5 o.ShipPostalCode, SUM(od.Quantity) as TotalQuantity from Orders o join [Order Details] od on o.OrderID = od.OrderID where o.OrderDate >= '1997-06-19' group by o.ShipPostalCode order by TotalQuantity desc;

--List all city names and number of customers in that city
Select distinct c.City, count(c.CustomerID) as TotalCustomers from Customers c group by c.City;

--List city names which have more than 2 customers, and number of customers in that city
Select distinct c.City, count(c.CustomerID) as TotalCustomers from Customers c group by c.City having count(c.CustomerID) > 2;

--List the names of customers who placed orders after 1/1/98 with order date
Select c.CustomerID, c.ContactName, o.OrderDate from Customers c join Orders o on c.CustomerID = o.CustomerID where o.OrderDate > '1998-01-01';

--List the names of all customers with most recent order dates
Select c.CustomerID, c.ContactName, LatestOrders.MaxOrderDate from Customers c join (
	Select CustomerID, MAX(OrderDate) as MaxOrderDate from Orders group by CustomerID
) as LatestOrders on c.CustomerID = LatestOrders.CustomerID
order by LatestOrders.MaxOrderDate desc;

--Display the names of all customers  along with the  count of products they bought
Select c.CustomerID, c.ContactName, count(od.ProductID) as TotalProducts from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID group by c.CustomerID, c.ContactName;

--Display the customer ids who bought more than 100 Products with count of products
Select c.CustomerID, c.ContactName, count(od.ProductID) as TotalProducts from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID group by c.CustomerID, c.ContactName having count(od.ProductID) > 100;

--List all of the possible ways that suppliers can ship their products
Select s.CompanyName as SupplierCompanyName, sh.CompanyName as ShippingCompanyName
from Suppliers s
	join Products p on s.SupplierID = p.SupplierID
	join [Order Details] od on p.ProductID = od.ProductID
	join Orders o on od.OrderID = o.OrderID
	join Shippers sh on o.ShipVia = sh.ShipperID
group by s.CompanyName, sh.CompanyName;

--Display the products order each day. Show Order date and Product Name
Select o.OrderDate, p.ProductName from Orders o join [Order Details] od on o.OrderID = od.OrderID join Products p on od.ProductID = p.ProductID ORDER BY o.OrderDate, p.ProductName;

--Displays pairs of employees who have the same job title
Select e1.EmployeeID as EmployeeID1, e1.FirstName + ' ' + e1.LastName as Name1,
       e2.EmployeeID as EmployeeID2, e2.FirstName + ' ' + e2.LastName as Name2, 
       e1.Title
from Employees e1 join Employees e2 on e1.Title = e2.Title and e1.EmployeeID < e2.EmployeeID order by e1.Title, e1.EmployeeID, e2.EmployeeID;

--Display all the Managers who have more than 2 employees reporting to them
Select m.EmployeeID, m.FirstName, m.LastName, count(e.EmployeeID) as NumberOfSubs from Employees e join Employees m on e.ReportsTo = m.EmployeeID group by m.EmployeeID, m.FirstName, m.LastName having count(e.EmployeeID) > 2;

--Display the customers and suppliers by city. The results should have the following columns
--City
--Name
--Contact Name,
--Type (Customer or Supplier)
Select City, CompanyName as Name, ContactName, 'Customer' as TypeOfContact from Customers
Union
Select City, CompanyName as Name, ContactName, 'Supplier' as TypeOfContact from Suppliers
order by City, Name;
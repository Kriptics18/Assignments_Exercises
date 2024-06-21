USE northwind
GO

--List all cities that have both Employees and Customers
    Select distinct e.City from Employees e join Customers c on e.City = c.City;

--List all cities that have Customers but no Employee using a sub query
    Select distinct c.City from Customers c where c.City not in (Select distinct e.City from Employees e);

--List all cities that have Customers but no Employee using a left join
    Select distinct c.City from Customers c left join Employees e on c.City = e.City where e.City is null;

-- List all products and their total order quantities throughout all orders
    Select p.ProductID, p.ProductName, sum(od.Quantity) as TotalQuantity from Products p join [Order Details] od on p.ProductID = od.ProductID group by p.ProductID, p.ProductName;

--List all Customer Cities and total products ordered by that city
    Select c.City, sum(od.Quantity) as TotalProductsOrdered from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID group by c.City;

--List all Customer Cities that have at least two customers by using UNION
    Select City from (
        Select City from Customers
        UNION ALL
        Select City from Customers
    ) as CityList group by City having count(City) > 2;

--List all Customer Cities that have at least two customers without UNION with a sub query
    Select City
    from (
        Select City, count(CustomerID) as CustomerCount
        from Customers
        group by City
    ) as CityCounts
    where CustomerCount >= 2;

--List all Customer Cities that have ordered at least two different kinds of products.
    Select City
	from (
		Select c.City, count(distinct od.ProductID) AS ProductCount
		from Customers c
		join Orders o 
            on c.CustomerID = o.CustomerID
		join [Order Details] od 
            on o.OrderID = od.OrderID
		group by c.City
	) as CityProductCounts
	where CityProductCounts.ProductCount >= 2;

--List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities
    Select distinct c.CustomerID, c.ContactName, c.City as CustomerCity, o.ShipCity as OrderShipCity
    from Customers c join Orders o 
        on c.CustomerID = o.CustomerID
    where c.City <> o.ShipCity;

--List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
    With TopProducts as (
        Select TOP 5
            p.ProductID,
            p.ProductName,
            avg(od.UnitPrice) as AveragePrice,
            sum(od.Quantity) as TotalQuantity
        from Products p join [Order Details] od 
            on p.ProductID = od.ProductID
        group by p.ProductID, p.ProductName
        order by TotalQuantity DESC
    ),
    ProductTopCity as (
        Select
            p.ProductID,
            c.City,
            sum(od.Quantity) as CityTotalQuantity,
            dense_rank() over (partition by p.ProductID order by sum(od.Quantity) DESC) as CityRank
        from Products p
        join [Order Details] od 
            on p.ProductID = od.ProductID
        join Orders o 
            on od.OrderID = o.OrderID
        join Customers c 
            on o.CustomerID = c.CustomerID
        group by p.ProductID, c.City
    )
    Select
        tp.ProductID,
        tp.ProductName,
        tp.AveragePrice,
        ptc.City as TopCustomerCity
    from TopProducts tp join ProductTopCity ptc 
        on tp.ProductID = ptc.ProductID and ptc.CityRank = 1;

-- List all cities that have never ordered something but we have employees there by using a sub query
	Select distinct e.City
    from Employees e
    where e.City not in (
        Select distinct o.ShipCity
        from Orders o join Customers c 
            on o.CustomerID = c.CustomerID
    )
    and e.City is not null;

-- List all cities that have never ordered something but we have employees there without using a subquery
	Select distinct e.City from Employees e
    left join Orders o 
        on e.City = o.ShipCity
    left join Customers c 
        on o.CustomerID = c.CustomerID
    where o.ShipCity is null and e.City is not null;

--List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
    With EmployeeOrderCount as (
        Select e.City, count(o.OrderID) as OrderCount
        from Employees e join Orders o 
            on e.EmployeeID = o.EmployeeID
        group by e.City
    ),
    CustomerOrderQuantity as (
        Select o.ShipCity, sum(od.Quantity) as TotalQuantity
        from Orders o join [Order Details] od 
            on o.OrderID = od.OrderID
        group by o.ShipCity
    )
    Select TOP 1 eoc.City
    from EmployeeOrderCount eoc join CustomerOrderQuantity coq 
        on eoc.City = coq.ShipCity
    order by eoc.OrderCount DESC, coq.TotalQuantity DESC;

--How do you remove the duplicates record of a table?
--Answer: We could do a self join on the table and remove the duplicates by comparing the primary key of the table, which is gauranteed to be unique for each record and therefore, will ensure we area not deleting the same record multiple times.

--Example:
-- For a table MyTable with columns ID, Name, Value

-- DELETE t1 FROM MyTable t1 INNER JOIN MyTable t2      | the self join
-- ON t1.Name = t2.Name AND t1.Value = t2.Value         | the condition to remove duplicates
-- AND t1.ID > t2.ID;                                   | the condition to keep only one of the duplicates and not self delete all records



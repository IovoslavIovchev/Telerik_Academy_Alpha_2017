SELECT p1.ProductName, p1.UnitPrice, c.CategoryName
FROM Products p1
INNER JOIN
(
	SELECT CategoryID, MAX(UnitPrice) MaxPrice
	FROM Products
	GROUP BY CategoryID
) p2 
ON p1.CategoryID=p2.CategoryID 
	AND p1.UnitPrice = p2.MaxPrice
INNER JOIN Categories c
ON p1.CategoryID = c.CategoryID
ORDER BY p1.UnitPrice
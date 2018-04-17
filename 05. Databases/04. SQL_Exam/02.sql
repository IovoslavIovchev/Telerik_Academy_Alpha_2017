SELECT TOP(5) p.ProductName, s.CompanyName [Supplier company name]
FROM Products p
INNER JOIN Suppliers s
ON p.SupplierID = s.SupplierID
ORDER BY ProductName
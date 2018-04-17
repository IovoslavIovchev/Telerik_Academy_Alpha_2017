SELECT TOP(1) s.CompanyName
FROM Orders o
INNER JOIN Shippers s
ON o.ShipVia = s.ShipperID
GROUP BY s.CompanyName
ORDER BY COUNT(o.ShipVia)
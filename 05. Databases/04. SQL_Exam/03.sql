SELECT m.FirstName, m.LastName
FROM Employees m
WHERE 
(
	SELECT COUNT(*)
	FROM Employees e
	WHERE e.ReportsTo = m.EmployeeID
) > 2
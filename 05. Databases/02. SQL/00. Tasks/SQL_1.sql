--  Write n SQL query to find all information about all departments (use "TelerikAcademy" database). 
SELECT * FROM Departments;

--  Write a SQL query to find all department names. 
SELECT [Name] 
FROM Departments

--  Write a SQL query to find the salary of each employee. 
SELECT [FirstName] + ' ' + [LastName] AS [Name],
        [Salary]
FROM Employees

--  Write a SQL to find the full name of each employee. 
SELECT [FirstName],[MiddleName],[LastName] 
FROM Employees

--  Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses". 
SELECT CONCAT(FirstName, '.', LastName, '@telerik.com')
AS [Full Email Addresses] 
FROM Employees

--  Write a SQL query to find all different employee salaries. 
SELECT DISTINCT [Salary] 
FROM Employees

--  Write a SQL query to find all information about the employees whose job title is “Sales Representative“. 
SELECT * 
FROM Employees 
WHERE JobTitle = 'Sales Representative'

--  Write a SQL query to find the names of all employees whose first name starts with "SA". 
SELECT [FirstName],[LastName] 
FROM Employees 
WHERE FirstName 
LIKE 'Sa%'

-- Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT [FirstName],[MiddleName],[LastName] 
FROM Employees 
WHERE LastName 
LIKE '%ei%'

-- Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT [Salary] 
FROM Employees 
WHERE Salary 
BETWEEN 20000 AND 30000

-- Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT [FirstName] +' ' + [LastName] AS [Name]
FROM Employees 
WHERE Salary IN (25000, 14000, 12500, 23600)

-- Write a SQL query to find all employees that do not have manager.
SELECT [FirstName],[LastName] 
FROM Employees 
WHERE ManagerID 
IS NULL

-- Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT [FirstName],[LastName] 
FROM Employees 
WHERE Salary > 50000 
ORDER BY Salary DESC

-- Write a SQL query to find the top 5 best paid employees.
SELECT 
TOP 5 [FirstName],[LastName] 
FROM Employees 
ORDER BY Salary DESC

-- Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT [FirstName],[LastName] 
FROM Employees 
INNER JOIN dbo.Addresses 
ON Employees.AddressID = Addresses.AddressID

-- Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT [FirstName],[LastName],[AddressText] 
FROM Employees, Addresses 
WHERE Employees.AddressID = Addresses.AddressID

-- Write a SQL query to find all employees along with their manager.
SELECT (E.FirstName + ' ' + E.LastName) AS [Employee], 
        (M.FirstName + ' ' + M.LastName) AS [Manager] 
FROM Employees AS E 
INNER JOIN Employees AS M 
ON E.ManagerID = M.EmployeeID

-- Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT (E.FirstName + ' ' + E.LastName) AS [Employee], 
        (M.FirstName + ' ' + M.LastName) AS [Manager],
        (A.AddressText) AS [Address] 
FROM Employees AS E 
INNER JOIN Employees AS M 
ON E.ManagerID = M.EmployeeID 
INNER JOIN Addresses AS A 
ON E.AddressID = A.AddressID

-- Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT [Name] from Departments 
UNION 
SELECT [Name] from Towns

-- Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT (E.FirstName + ' ' + E.LastName) AS [Employee], 
        (M.FirstName + ' ' + M.LastName) AS [Manager]
FROM Employees AS E 
LEFT OUTER JOIN Employees AS M 
ON E.ManagerID = M.EmployeeID
OR M.EmployeeID IS NULL

-- Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT e.FirstName + ' ' + e.LastName 
AS [Name]
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '1995'
AND e.HireDate < '2005'
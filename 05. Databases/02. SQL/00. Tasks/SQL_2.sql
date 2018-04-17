-- Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
SELECT Firstname + ' ' + Lastname AS [Name],
	[Salary]
FROM Employees
WHERE Salary = (
    SELECT MIN(Salary) 
    FROM Employees)

-- Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT Firstname + ' ' + Lastname AS [Name],
	[Salary]
FROM Employees 
WHERE Salary < (
	SELECT MIN(Salary) 
	FROM Employees) * 1.1

-- Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
SELECT e.Salary, e.FirstName, e.LastName, d.Name
FROM Employees AS e
JOIN Departments as d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary IN (
	SELECT MIN(Salary) 
	FROM Employees 
	GROUP BY DepartmentID)

-- Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = 1

-- Write a SQL query to find the average salary in the "Sales" department.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = (
    SELECT DISTINCT DepartmentID 
    FROM Departments 
    WHERE Name = 'Sales')

-- Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) AS [Number of employees]
FROM Employees
WHERE DepartmentID = (
    SELECT DepartmentID 
    FROM Departments 
    WHERE Name = 'Sales')

-- Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) AS [Employees with a manager]
FROM Employees
WHERE ManagerID 
IS NOT NULL

-- Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS [Employees without a manager]
FROM Employees
WHERE ManagerID 
IS NULL

-- Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name AS [Department], 
	AVG(e.Salary) AS [Average Salary]
FROM Employees AS e
JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

--Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(e.EmployeeID) AS [Employees], 
	d.Name AS [Department], 
	t.Name AS [Town]
FROM Employees AS e
JOIN Departments AS d 
ON d.DepartmentID = e.DepartmentID
JOIN Addresses AS a
ON a.AddressID = e.AddressID
JOIN Towns AS t
on t.TownID = a.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name

--Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT e1.FirstName, e1.LastName
FROM Employees as e1
WHERE (
	SELECT COUNT(*) 
	FROM Employees 
	WHERE ManagerID = e1.EmployeeID) = 5

--Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee],
	ISNULL(m.Firstname + ' ' + m.LastName, 'None') AS [Manager]
FROM Employees AS e
LEFT JOIN Employees AS m
ON e.ManagerID = m.EmployeeID

--Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in `LEN(str)` function.
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--Write a SQL query to display the current date and time in the following format "`day.month.year hour:minutes:seconds:milliseconds`".
SELECT CONVERT(VARCHAR(30), GETDATE(), 103)

--Write a SQL statement to create a table `Users`. Users should have username, password, full name and last login time.
CREATE TABLE Users (
	User_ID int IDENTITY,
	Username varchar(100) NOT NULL UNIQUE,
	Password CHAR(64),
	[Full Name] varchar(100) NOT NULL,
	[Last Login] datetime NULL,
	CONSTRAINT PK_Users PRIMARY KEY(User_ID),
	CONSTRAINT Password_Length CHECK (DATALENGTH(Password) >= 5)
)

INSERT INTO Users (Username, Password, [Full Name], [Last Login])
VALUES ('Test 1', 'Password 1', 'Test1 Test', GETDATE())

INSERT INTO Users (Username, Password, [Full Name], [Last Login])
VALUES ('Test 2', 'Password 2', 'Test2 Test', DATEADD(DAY, -1, GETDATE()))

INSERT INTO Users (Username, Password, [Full Name], [Last Login])
VALUES ('Test 3', 'Password 3', 'Test3 Test', DATEADD(MONTH, -1, GETDATE()))

INSERT INTO Users (Username, Password, [Full Name], [Last Login])
VALUES ('Test 4', 'Password 4', 'Test4 Test', GETDATE())

--Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
SELECT *
FROM Users
WHERE YEAR([Last Login]) = YEAR(GETDATE()) 
	AND MONTH([Last Login]) = MONTH(GETDATE()) 
	AND DAY([Last Login]) = DAY(GETDATE()) 

--Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
CREATE TABLE Groups (
	ID int IDENTITY,
	Name varchar(100) NOT NULL UNIQUE,
	CONSTRAINT PK_Groups PRIMARY KEY(ID)
)

--Write a SQL statement to add a column GroupID to the table Users.
ALTER TABLE Users
	ADD [Group_ID] int

ALTER TABLE Users
	ADD FOREIGN KEY (Group_ID) REFERENCES Groups(ID)

INSERT INTO Groups
VALUES ('Web-Development')

INSERT INTO Groups
VALUES ('UNIX Porn')

UPDATE Users
SET Group_ID = 1
WHERE User_ID % 2 = 1

UPDATE Users
SET Group_ID = 2
WHERE User_ID % 2 = 0

--Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups
VALUES ('Algorithms')

INSERT INTO Groups
VALUES ('Roleplay')

INSERT INTO Users
VALUES ('Test 5', 'Password 5', 'Test5 Test', GETDATE(), 3)

--Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET [Full Name] = 'Updated ' + [Full Name]

UPDATE Groups
SET Name = 'Advanced ' + Name
WHERE ID = 4

--Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Group_ID = 1

DELETE FROM Groups
WHERE ID = 1

--Write SQL statements to insert in the Users table the names of all employees from the Employees table.
INSERT INTO Users (Username, Password, [Full Name], [Last Login], Group_ID)
SELECT LEFT(FirstName, 3) + LastName, LEFT(FirstName, 1) + LastName, FirstName + ' ' + LastName, NULL, 2
FROM Employees

--Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET Password = NULL
WHERE [Last Login] < '10.03.2010'

--Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE Password IS NULL

--Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name, e.JobTitle, 
	AVG(e.Salary) AS [Average Salary]
FROM Employees AS e
JOIN Departments as d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, JobTitle
ORDER BY d.Name

--Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT d.Name, e.JobTitle, 
	MIN(e.Salary) AS [Minimal Salary],
	CONCAT(e.FirstName, e.LastName)
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

--Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 COUNT(*) AS [Max Employees], 
	t.Name AS [Town]
FROM Employees AS e
JOIN Addresses AS a
ON e.AddressID = a.AddressID
JOIN Towns AS t
ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY [Max Employees] DESC

--Write a SQL query to display the number of managers from each town.

--Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).

--Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.

--Start a database transaction and drop the table EmployeesProjects.

--Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.
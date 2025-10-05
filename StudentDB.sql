CREATE DATABASE StudentDB;
GO
USE StudentDB;

CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    BirthDate DATE
);

DECLARE @i INT = 1;
WHILE @i <= 50
BEGIN
    INSERT INTO Students (Name, BirthDate)
    VALUES (CONCAT('Student ', @i), DATEADD(DAY, -@i*50, GETDATE()));
    SET @i += 1;
END

--
-- ���� ������������ � ������� SQLiteStudio v3.2.1 � �� ��� 21 09:58:42 2020
--
-- �������������� ��������� ������: System
--
--PRAGMA foreign_keys = off;
--BEGIN TRANSACTION;

-- �������: Course
CREATE TABLE [Course] (
    [CourseID] INT       NOT NULL,
    [Title]    NVARCHAR (50) NULL,
    [Credits]  INT           NULL
);

-- �������: Enrollment
CREATE TABLE [Enrollment] (
    [EnrollmentID] INT       NOT NULL,
    [Grade]        DECIMAL(3, 2) NULL,
    [CourseID]     INT NOT NULL,
    [StudentID]    INT NOT NULL
);

-- �������: Student
CREATE TABLE [Student] (
    [StudentID]      INT  NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [EnrollmentDate] DATETIME      NULL
);

--COMMIT TRANSACTION;
--PRAGMA foreign_keys = on;

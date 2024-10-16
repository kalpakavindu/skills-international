CREATE TABLE [Student] (
  [regNo] int PRIMARY KEY NOT NULL,
  [firstName] varchar(50) NOT NULL,
  [lastName] varchar(50) NOT NULL,
  [dateOfBirth] datetime NOT NULL,
  [gender] varchar(50) NOT NULL,
  [address] varchar(50) NOT NULL,
  [email] varchar(50) NOT NULL,
  [mobilePhone] decimal(11) NOT NULL,
  [homePhone] decimal(11) NOT NULL,
  [parentName] varchar(50) NOT NULL,
  [parentNic] varchar(50) NOT NULL,
  [parentPhone] decimal(11) NOT NULL
)
GO

CREATE TABLE [Teacher] (
  [regNo] int PRIMARY KEY NOT NULL,
  [firstName] varchar(50) NOT NULL,
  [lastName] varchar(50) NOT NULL,
  [dateOfBirth] datetime NOT NULL,
  [gender] varchar(50) NOT NULL,
  [address] varchar(50) NOT NULL,
  [email] varchar(50) NOT NULL,
  [mobilePhone] decimal(11) NOT NULL,
  [nic] varchar(50) UNIQUE NOT NULL,
  [civilStatus] varchar(50) NOT NULL
)
GO

CREATE TABLE [Class] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [name] varchar(50) UNIQUE NOT NULL,
  [batch] int NOT NULL
)
GO

CREATE TABLE [ClassToTeacher] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [classId] int NOT NULL,
  [teacherId] int NOT NULL
)
GO

CREATE TABLE [ClassToStudent] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [classId] int NOT NULL,
  [studentId] int NOT NULL
)
GO

ALTER TABLE [ClassToStudent] ADD FOREIGN KEY ([classId]) REFERENCES [Class] ([id])
GO

ALTER TABLE [ClassToTeacher] ADD FOREIGN KEY ([classId]) REFERENCES [Class] ([id])
GO

ALTER TABLE [ClassToStudent] ADD FOREIGN KEY ([studentId]) REFERENCES [Student] ([regNo])
GO

ALTER TABLE [ClassToTeacher] ADD FOREIGN KEY ([teacherId]) REFERENCES [Teacher] ([regNo])
GO
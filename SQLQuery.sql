CREATE TABLE [Student] (
  [regNo] int PRIMARY KEY NOT NULL,
  [fistName] varchar(50) NOT NULL,
  [lastName] varchar(50) NOT NULL,
  [dateOfBirth] datetime NOT NULL,
  [gender] varchar(50) NOT NULL,
  [address] varchar(50) NOT NULL,
  [email] varchar(50) NOT NULL,
  [mobilePhone] int,
  [homePhone] int NOT NULL,
  [parentName] varchar(50) NOT NULL,
  [parentNic] varchar(50) NOT NULL,
  [parentPhone] int NOT NULL,
  [classId] int
)
GO

CREATE TABLE [Teacher] (
  [regNo] int PRIMARY KEY NOT NULL,
  [fistName] varchar(50) NOT NULL,
  [lastName] varchar(50) NOT NULL,
  [dateOfBirth] datetime NOT NULL,
  [gender] varchar(50) NOT NULL,
  [address] varchar(50) NOT NULL,
  [email] varchar(50) NOT NULL,
  [mobilePhone] int NOT NULL,
  [nic] varchar(50) UNIQUE NOT NULL,
  [civilStatus] varchar(50) NOT NULL
)
GO

CREATE TABLE [Class] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [name] varchar(50) UNIQUE NOT NULL,
  [teacherId] int UNIQUE NOT NULL
)
GO

ALTER TABLE [Student] ADD FOREIGN KEY ([classId]) REFERENCES [Class] ([id])
GO

ALTER TABLE [Class] ADD FOREIGN KEY ([teacherId]) REFERENCES [Teacher] ([regNo])
GO
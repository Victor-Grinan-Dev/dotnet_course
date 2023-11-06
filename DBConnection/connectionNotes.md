# DB PART
(NOTE this sql is only for azure app)
- creating a dummy db:

```sql
CREATE DATABASE DotNetDB
GO

USE DotNetDB
GO

CREATE SCHEMA TutorialApp
GO

CREATE TABLE TutorialApp.Computer(
    ComputerId INT IDENTITY(1,1) PRIMARY KEY,
    Motherboard NVARCHAR(50),
    CPUCores INT,
    HasWifi BIT,
    HasLTE BIT,
    ReleaseDate DATE,
    Price DECIMAL (18,4),
    VideoCard NVARCHAR(50)
);

SELECT * FROM TutorialApp.Computer
```
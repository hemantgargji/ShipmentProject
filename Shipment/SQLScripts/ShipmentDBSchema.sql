
CREATE DATABASE Shipment
USE Shipment

CREATE TABLE ShipmentInfo(ShipmentId INT PRIMARY KEY IDENTITY(1,1),SenderName VARCHAR(100) not null,DESCRIPTION VARCHAR(100),RecipientAddress VARCHAR(200) not null,Expedited BIT,ShipmentType VARCHAR(20) not null,IsDeleted BIT DEFAULT 0,dtCreated DATETIME  DEFAULT GETDATE(),dtUpdated DATETIME,CreatedBy VARCHAR(100),UpdatedBy VARCHAR(100))







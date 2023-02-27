CREATE DATABASE TIENDA;

USE TIENDA;

CREATE TABLE PRODUCTO
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(255) NOT NULL
)

CREATE TABLE CLIENTE
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	APELLIDO VARCHAR(50) NOT NULL,
	EDAD INT NOT NULL
)



GO
INSERT INTO [dbo].[PRODUCTO]
           ([NOMBRE]
           ,[DESCRIPCION])
     VALUES
           ('Lapiz','Util escolar'),
		   ('Borrador','Util escolar'),
		   ('Lapicero','Util escolar')
GO



GO
INSERT INTO [dbo].[CLIENTE]
           ([NOMBRE]
           ,[APELLIDO]
           ,[EDAD])
     VALUES
           ('Pedro','Salazar',32),
           ('Ana','Perez',22)
GO


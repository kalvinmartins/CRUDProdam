use master
Create Database Cafeteria
go

use Cafeteria
go

Create Table Clientes
(
ClienteID int primary key Identity,
Name varchar(50),
Telefone varchar(50),
CPF varchar(11),
)

Select * from Clientes
Insert Into Clientes Values('doug', '192301401320', '12345678910') 


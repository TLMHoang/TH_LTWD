create database ProductOrder
go
use ProductOrder
go
create table Product
(
	ID varchar(20) primary key,
	Name nvarchar(100) not null,
	Unit nvarchar(50) not null,
	BuyPrice decimal(18,0) ,
	SellPeice decimal (18,0)
)

go 
create table Invoice
(
	NumID nvarchar(20) primary key,
	OrderDate datetime not null,
	DeliverryDate datetime not null,
	Note nvarchar(500),
)
go
create table Orders
(
	NumID nvarchar(20) foreign key references Invoice(NumID),
	No int not null,
	ProductID varchar(20),
	ProductName nvarchar(100) ,
	Unit nvarchar(50) ,
	Price  decimal (18,0),
	Quantity int not null,
	primary key (NumID,ProductID),
	foreign key (ProductID) references Product(ID)
)

go
create proc BaoGia
as
begin
	select ID,Name,Unit,SellPeice from Product
end


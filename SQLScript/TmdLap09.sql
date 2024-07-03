Create database TmdNhaHang
Use TmdNhaHang

create table TmdProducts (
	TmdId int primary key,
	TmdName nvarchar(50),
	TmdPicture nvarchar(50),
	TmdQuantity int,
	TmdPrice decimal(10, 2),
	TmdAmount decimal(10, 2),

);
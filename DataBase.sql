Create Database StoreMini;

Use StoreMini;

Create Table DeliveryProducts(
Id Int Primary Key Identity(1,1),
DeliveryName Varchar(50) Not null,
Company Varchar(100) Not null,
PhoneNumber Int Unique,
DeliveryDays Varchar(100) Not null
)

Create Table Products(
Id Int Primary Key Identity(1,1),
ProductName Varchar(45) Not null,
Desription Varchar(200) Not null,
Cant Float Not Null,
Price Float Not null,
Abadible Float,
Photo Image,
IdDelivery Int Foreign Key References DeliveryProducts(Id)
)

Create Procedure SP_SaveDeliveryProducts
@DeliveryName Varchar(50),
@Company Varchar(100),
@PhoneNumber int,
@DeliveryDays Varchar(100)
AS
BEGIN
	If Not Exists(Select PhoneNumber From DeliveryProducts Where PhoneNumber = @PhoneNumber)
	BEGIN
		Insert Into DeliveryProducts(DeliveryName, Company, PhoneNumber, DeliveryDays)
		Values (@DeliveryName, @Company, @PhoneNumber, @DeliveryDays);
	END
END


Create Procedure SP_SaveProducts
@ProductName Varchar(45),
@Desription Varchar(200),
@Size Float,
@Price Float,
@Abadible Float,
@Photo Image,
@IdDelivery Int
AS
BEGIN 
	Insert Into Products(ProductName, Desription, Cant, Price, Abadible, Photo, IdDelivery)
	Values(@ProductName, @Desription, @Size, @Price, @Abadible, @Photo, @IdDelivery)
END


Create Procedure SP_UpdateDeliveryProducts
@ID int,
@DeliveryName Varchar(50),
@Company Varchar(100),
@PhoneNumber int,
@DeliveryDays Varchar(100)
AS
BEGIN
	Update DeliveryProducts 
	Set DeliveryName = @DeliveryName, Company = @Company, PhoneNumber = @PhoneNumber, DeliveryDays = @DeliveryDays
	Where Id = @ID;
END

Create Procedure SP_UpdateProducts
@ID int,
@ProductName Varchar(45),
@Desription Varchar(200),
@Size Float,
@Price Float,
@Abadible Float,
@Photo Image,
@IdDelivery Int
AS
BEGIN 
	Update Products
	Set ProductName = @ProductName, Desription = @Desription, Cant = @Size, Price = @Price, Abadible = @Abadible,
	Photo = @Photo, IdDelivery = @IdDelivery
	Where Id = @ID; 
END

Create Procedure SP_DeleteDeliveryProducts
@ID int
As
BEGIN
	If Exists(Select Id From DeliveryProducts Where Id = @ID)
	BEGIN
		Delete DeliveryProducts Where Id = @ID; 
	END
END

Create Procedure SP_DeleteProducts
@ID int
As
BEGIN
	If Exists(Select Id From Products Where Id = @ID)
	BEGIN
		Delete Products Where Id = @ID; 
	END
END

Create Procedure SP_ShowDeliveryProducts
AS
BEGIN
	Select * From DeliveryProducts;
END

Create Procedure SP_ShowProducts
AS
BEGIN
	Select P.Id, P.ProductName, P.Desription, P.Cant, P.Price, P.Abadible, DP.DeliveryName, P.IdDelivery, P.Photo 
	From Products as P Inner Join DeliveryProducts as DP On DP.Id = P.IdDelivery;
END 

Exec SP_ShowDeliveryProducts

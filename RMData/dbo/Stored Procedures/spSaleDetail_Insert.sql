CREATE PROCEDURE [dbo].[spSaleDetail_Insert]
	@SaleId int,
	@ProductId int,
	@Quantity int,
	@PurchasePrice money,
	@Tax money
AS
	begin 

	set nocount on;

	Insert into dbo.SaleDetail(SaleId, ProductId, Quantity, PurchasePrice, Tax)
	values (@SaleId, @ProductId, @Quantity, @PurchasePrice, @Tax);
end

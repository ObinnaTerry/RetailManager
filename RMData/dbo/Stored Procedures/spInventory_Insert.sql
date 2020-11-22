CREATE PROCEDURE [dbo].[spInventory_Insert]
	--[Id], [ProductId], [Quantity], [PurchasePrice], [PurchaseDate]
	@ProductId int,
	@Quantity int,
	@PurchasePrice money,
	@PurchaseDate datetime2
AS
begin

set nocount on;

	Insert into dbo.Inventory(ProductId, Quantity, PurchasePrice, Purchasedate)
	values (@ProductId, @Quantity, @PurchasePrice, @PurchaseDate);
end

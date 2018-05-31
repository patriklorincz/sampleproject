
CREATE PROCEDURE dbo.GetProducts
	@Warehouse varchar(20) = 'WarehouseOne',
	@Category varchar(20) = NULL
AS
	SELECT p.Id, p.Name, c.Id as IdCategory, c.Name as Category, ws.Price, ws.Quantity
	FROM Stocks AS ws
	INNER JOIN Warehouses AS w on w.Id = ws.IdWarehouse
	INNER JOIN Products AS p on p.Id = ws.IdProduct
	INNER JOIN Categories AS c on p.CategoryId = c.Id
	WHERE (w.Name like @Warehouse and (@Category is null or c.Name like @Category))

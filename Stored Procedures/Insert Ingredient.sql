CREATE PROCEDURE dbo.spInsertIngredient

@ingredientName NVARCHAR(50)
AS
BEGIN

	INSERT INTO dbo.Ingredients(IngredientName)
	VALUES (@ingredientName);

END
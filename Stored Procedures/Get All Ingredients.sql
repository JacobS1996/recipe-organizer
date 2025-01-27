CREATE PROCEDURE dbo.spGetAllIngredients

AS
BEGIN

	SELECT dbo.Ingredients.IngredientName
	FROM dbo.Ingredients;

END
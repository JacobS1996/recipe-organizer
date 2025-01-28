CREATE PROCEDURE dbo.spGetIngredientIdByTitle

@ingredientName NVARCHAR(50)

AS
BEGIN

	SELECT Id
	FROM dbo.Ingredients
	WHERE IngredientName = @ingredientName;

END
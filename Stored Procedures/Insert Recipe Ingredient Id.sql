CREATE PROCEDURE dbo.spInsertRecipeIngredientId

@recipeId INT,
@ingredientId INT,
@ingredientProportion NVARCHAR(20)
AS
BEGIN

	INSERT INTO dbo.RecipeIngredientIds(RecipeId, IngredientId, Proportion)
	VALUES (@recipeId, @ingredientId, @ingredientProportion);

END
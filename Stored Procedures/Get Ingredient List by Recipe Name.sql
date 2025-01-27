CREATE PROCEDURE dbo.spGetIngredientListByRecipeName

@recipeName nvarchar(50)

AS
BEGIN
	SELECT Ingredients.IngredientName, RecipeIngredientIds.Proportion
	FROM dbo.RecipeIngredientIds
	left join dbo.Ingredients on Ingredients.Id = IngredientId
	left join dbo.Recipes on RecipeId = Recipes.Id
	WHERE RecipeName = @recipeName;
END
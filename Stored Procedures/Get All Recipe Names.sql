CREATE PROCEDURE dbo.spGetAllRecipeNames

AS
BEGIN

	SELECT dbo.Recipes.RecipeName
	FROM dbo.Recipes;

END
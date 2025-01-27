CREATE PROCEDURE dbo.GetRecipeIdByTitle

@recipeName NVARCHAR(50)

AS
BEGIN

	SELECT Id
	FROM dbo.Recipes
	WHERE RecipeName = @recipeName;

END
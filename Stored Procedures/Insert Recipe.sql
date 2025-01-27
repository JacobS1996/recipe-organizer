CREATE PROCEDURE dbo.spInsertRecipe

@recipeName NVARCHAR(50)
AS
BEGIN

	INSERT INTO dbo.Recipes(RecipeName)
	VALUES (@recipeName);

END
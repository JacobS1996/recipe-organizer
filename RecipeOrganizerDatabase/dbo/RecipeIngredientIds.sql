CREATE TABLE [dbo].[RecipeIngredientIds]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IngredientId] INT NOT NULL, 
    [RecipeId] INT NOT NULL, 
    [Proportion] NVARCHAR(20) NOT NULL
)

using RecipeOrganizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeOrganizerLibrary.Methods
{
    public class DataInteraction
    {
        /* This class references the Data Access class. The DataAccess class contains methods which utilize third-party software packages Dapper, System.Data.SqlClient, and System.Config.ConfigurationManager
         Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

        private List<IngredientModel> ReturnListOfNonExistentIngredients(List<IngredientModel> ingredientList, string databaseName)
        {
            DataAccess dataAccess = new DataAccess();
            List<IngredientModel> output = new List<IngredientModel>();
            List<string> ingredientsInDatabase = new List<string>();
            ingredientsInDatabase = dataAccess.GetAllIngredients(databaseName);
          
            foreach (var item in ingredientList)
            {
                if (!ingredientsInDatabase.Contains(item.IngredientName))
                {
                    output.Add(item);
                }

            } 
           

            return output;
        }

        private void AddListOfIngredientsToDatabase(List<IngredientModel> ingredients, string databaseName)
        {
            DataAccess dataAccess = new DataAccess();
            foreach(var item in ingredients)
            {
                dataAccess.InsertIngredient(item, databaseName);
            }
        }

        public bool VerifyRecipeNameExists(string recipeName, string databaseName)
        {
            DataAccess dataAccess = new DataAccess();
            List<string> recipeNames = dataAccess.GetAllRecipeNames(databaseName);
            if(recipeNames.Contains(recipeName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public RecipeModel AddIngredientListToRecipe(List<IngredientModel> ingredients, RecipeModel output)
        {
            output.IngredientList = ingredients;

            return output;

        }

        public void AddInformationToDatabase(RecipeModel recipe, List<IngredientModel> pendingIngredients, string databaseName)
        {
            DataAccess dataAccess = new DataAccess();
            List<IngredientModel> ingredientsToAddToDB = ReturnListOfNonExistentIngredients(pendingIngredients, databaseName);
            AddListOfIngredientsToDatabase(ingredientsToAddToDB, databaseName);
            dataAccess.InsertRecipe(recipe, databaseName);
            int recipeId = dataAccess.GetRecipeIdByTitle(recipe.RecipeName, databaseName);
            foreach(var item in pendingIngredients)
            {
                int ingredientId = dataAccess.GetIngredientIdByTitle(item.IngredientName, databaseName);
                dataAccess.InsertRecipeIngredientId(ingredientId, recipeId, item.Proportion, databaseName);
            }
            
        }

       

    }
}

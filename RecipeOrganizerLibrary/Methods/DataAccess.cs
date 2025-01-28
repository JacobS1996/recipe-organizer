using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using RecipeOrganizerLibrary.Models;
using System.Linq;
using System.Net.NetworkInformation;

namespace RecipeOrganizerLibrary.Methods
{
    public class DataAccess
    {
        /* the DataAccess class contains methods which utilize third-party software packages Dapper, Microsoft.Data.SqlClient, and System.Config.ConfigurationManager
         Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

        public int GetIngredientIdByTitle(string title, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<int> ids = connection.Query<int>("dbo.spGetIngredientIdByTitle @ingredientName", new { ingredientName = title }).ToList();
                return ids[ids.Count - 1];
            }
        }
        public int GetRecipeIdByTitle(string title, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<int> ids = connection.Query<int>("dbo.spGetRecipeIdByTitle @recipeName", new { recipeName = title }).ToList();
                return ids[ids.Count - 1];
            }
        }
        public List<string> GetAllIngredients(string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<string> ingredients = connection.Query<string>("dbo.spGetAllIngredients" ).ToList();
                return ingredients;
            }
        }

        public List<string> GetAllRecipeNames(string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<string> output = connection.Query<string>("dbo.spGetAllRecipeNames").ToList();
                return output;
            }
        }

        public List<IngredientModel> GetIngredientListByRecipeName(string nameOfRecipe, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                return connection.Query<IngredientModel>("dbo.spGetIngredientListByRecipeName @recipeName", new {recipeName = nameOfRecipe}).ToList();
            }
        }

        public void InsertIngredient(IngredientModel ingredient, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                connection.Execute("dbo.spInsertIngredient @ingredientName", ingredient);
            }
        }

        public void InsertRecipe(RecipeModel recipe, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                connection.Execute("dbo.spInsertRecipe @recipeName", recipe);
            }
        }

        public void InsertRecipeIngredientId(int idForIngredient, int idForRecipe, string proportionForIngredient, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                connection.Execute("dbo.spInsertRecipeIngredientId @recipeId, @ingredientId, @ingredientProportion", new { recipeId = idForRecipe, ingredientId = idForIngredient, ingredientProportion = proportionForIngredient });
            }
        }


    }
}

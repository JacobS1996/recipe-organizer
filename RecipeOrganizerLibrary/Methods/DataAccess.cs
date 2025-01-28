using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using RecipeOrganizerLibrary.Models;
using System.Linq;
using System.Net.NetworkInformation;

namespace RecipeOrganizerLibrary.Methods
{
    public class DataAccess
    {
        /* the DataAccess class contains methods which utilize third-party software packages Dapper, System.Data.SqlClient, and System.Config.ConfigurationManager
         Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

        public string GetIngredientIdByTitle(string title, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<string> ids = connection.Query<string>("dbo.spGetIngredientIdByTitle @ingredientName", new { ingredientName = title }).ToList();
                return ids[ids.Count - 1];
            }
        }
        public string GetRecipeIdByTitle(string title, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                List<string> ids = connection.Query<string>("dbo.spGetRecipeIdByTitle @recipeName", new { recipeName = title }).ToList();
                return ids[ids.Count - 1];
            }
        }
        public List<string> GetAllIngredients(string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                return connection.Query<string>("dbo.spGetAllIngredients" ).ToList();
            }
        }

        public List<string> GetAllRecipeNames(string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                return connection.Query<string>("dbo.spGetAllRecipeNames").ToList();
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

        public void InsertRecipeIngredientId(string idForIngredient, string idForRecipe, string proportionForIngredient, string databaseName)
        {
            using (IDbConnection connection = new SqlConnection(DatabaseConnectionHelper.ConnectionStringGetter(databaseName)))
            {
                connection.Execute("dbo.spInsertRecipeIngredientId @recipeId, @ingredientId, @ingredientProportion", new { recipeId = idForRecipe, ingredientId = idForIngredient, ingredientProportion = proportionForIngredient });
            }
        }


    }
}

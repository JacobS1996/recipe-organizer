using RecipeOrganizerLibrary.Methods;
using RecipeOrganizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeOrganizer
{
    /// <summary>
    /// Interaction logic for RecipeCreationWindow.xaml
    /// </summary>
    public partial class RecipeCreationWindow : Window
    {
        internal BindingList<IngredientModel> ingredients = new BindingList<IngredientModel>();
        internal RecipeModel recipe = new RecipeModel();
        internal string databaseName = "";
        public RecipeCreationWindow()
        {
            InitializeComponent();
            pendingIngredientsListBox.DataContext = ingredients;
            pendingIngredientsListBox.ItemsSource = ingredients;
        }

        private void addIngredientsButton_Click(object sender, RoutedEventArgs e)
        {
             IngredientModel ingredient = new IngredientModel();
            if(string.IsNullOrEmpty(ingredientNameTextBox.Text) || string.IsNullOrEmpty(ingredientProportionTextBox.Text))
            {
                ingredient.IngredientName = ingredientNameTextBox.Text;
                ingredient.Proportion = ingredientProportionTextBox.Text;
                ingredients.Add(ingredient);
            }
            else
            {
                MessageBox.Show("Ingredient name or proportion fields cannot be blank.", "user input error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

        }

        private void submitRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            /* This method references the DataAccess class which contains methods which utilize third-party software packages Dapper, System.Data.SqlClient, and System.Config.ConfigurationManager
         Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */

            DataInteraction dataInteraction = new DataInteraction();
            bool recipeIsNotValid = dataInteraction.VerifyRecipeNameExists(recipeNameTextBox.Text, databaseName);
            if(recipeIsNotValid )
            {
                MessageBox.Show("Recipe name field cannot be empty.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                recipe.RecipeName = recipeNameTextBox.Text;
           
                dataInteraction.AddInformationToDatabase(recipe, ingredients.ToList(), databaseName);
            }

            this.Close();
           
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RecipeOrganizerLibrary;
using RecipeOrganizerLibrary.Models;
using RecipeOrganizerLibrary.Methods;

namespace RecipeOrganizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    
    {
        public string DatabaseName { get; set; } = "RecipeDatabase";
        private List<string> recipeNames = new List<string>();
        private List<IngredientModel> ingredients = new List<IngredientModel>();
        private DataAccess dataAccess = new DataAccess();


        public MainWindow()
        {
            /* The MainWindow utilizes the DataAccess class. The DataAccess class contains methods which utilize third-party software packages Dapper, Microsoft.Data.SqlClient, and System.Config.ConfigurationManager
         Please see the Credits.txt file for the copyright information, licensing agreements, and links in compliance with these packages' licensing agreements. */
            
            InitializeComponent();
            recipeNames = dataAccess.GetAllRecipeNames(DatabaseName);
            recipeListItems.DataContext = recipeNames;
            recipeListItems.ItemsSource = recipeNames;
            recipeIngredients.DataContext = ingredients;
            recipeIngredients.ItemsSource = ingredients;

        }
        private void recipeCreationButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RecipeCreationWindow recipeCreationWindow = new RecipeCreationWindow();
            recipeCreationWindow.databaseName = DatabaseName;
            recipeCreationWindow.ShowDialog();
            recipeNames = dataAccess.GetAllRecipeNames(DatabaseName);
            recipeListItems.DataContext = recipeNames;
            recipeListItems.ItemsSource = recipeNames;
            this.Show();
        }

        private void displayIngredientsButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = recipeListItems.SelectedItem.ToString();
            recipeIngredients.ItemsSource = dataAccess.GetIngredientListByRecipeName(recipeName, DatabaseName);
        }

      
    }
}
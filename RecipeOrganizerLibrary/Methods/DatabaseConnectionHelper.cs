using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace RecipeOrganizerLibrary.Methods
{
    internal static class DatabaseConnectionHelper
    {

        /* this method utilizes the System.Configuration.Configuration Manager third-party package; please see the Credits.txt file for 
         * licensing and copyright information in compliance with 
        third-party package license agreements. */
        internal static string ConnectionStringGetter(string databaseName)
        {
            return ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
        }

    }
}

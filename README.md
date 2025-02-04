# Title

recipe-organizer

# About

I created this WPF application in Visual Studio 2022 to assist my wife in meal planning and preparation. This app provides a convenient way to create, store, and display recipe names along with their ingredients and proportions. While it does not contain the instructions for each recipe, it does provide a convenient place for my wife to quickly access the ingredients lists for various recipes without relying on her memory or scattered notes.

By clicking the "create recipe" button on the top of the home screen, a user is able to input data which will create a new recipe, along with its ingredients and their proportions. The recipe and its information are saved in a database. Once saved, the recipe name will appear in a list on the left side of the home page. The application works by having a list of recipes on the left side of the main page. Upon selecting a recipe and clicking a button, the list of ingredients will appear along with their proportions on the right side of the main page.

# How to Build

<h2>Getting Started</h2>

Ensure that you have Visual Studio installed and that it is connected to your GitHub profile. If you wish to contribute to this repository, create a fork, make changes on the development branch (or a newly created branch), and create a pull request to merge those changes with the development branch on this repo. If you only wish to build the application without making changes to this repository, select "open with Visual Studio" from the "Code" drop down menu. 

The project should open all relevant files automatically, but if it does not, all the relevant files should be opened automatically by double-clicking on the solution file(.sln). 

<h2>Creating the Database</h2>

This repo contains a database project named "RecipeOrganizerDatabase." It can be used to quickly create the database needed to build the program. You can publish the database to your sql database management system of choice by right clicking on the "RecipeOrganizerDatabase" project and selecting publish. To the right of the "target database connection" option, select "edit." There will be a tab named "browse" which will allow you to publish the database to your database management system of choice. If you only wish to test the database, a quick and convenient option is to use the MSSQLocalDB built into Visual Studio. In the "browse" tab mentioned previously, select local>MSSQLocalDB and fill out the information as desired. Finally, name your database and click "publish." One important issue to note is that there is a bug that prevents publishing the database when the target platform is set to "SQL Server 2022 or Azure SQL Database Managed Instance." To fix this issue, right click on the "MockQuizDatabase" project and select properties. Under properties, change the target platform to "SQL Server 2019." The database should not publish without issues.

If the database was published to MSSQLocalDB, it can be accessed using the SQL Server Object Explorer built into Visual Studio. Select View>SQL Server Object Explorer. In the object explorer, select Server>(localdb)MSSQLocalDB>Databases, and the database should be there.

<h2>Connecting the Database to the Application</h2>



<h2>Wiring Up Dependancies</h2>

# Contribution

This application was designed without the intention of having outside contribution. That being said, those who really wish to contribute to this application can do so by forking the repository, making changes on the development branch (or a newly created branch), and creating a pull request to merge those changes with the development branch on the original repo. 

This project is open-source and licensed under the MIT License. You are free to use this source code for your own purposes as long as you abide by the terms and condition of the license. Please note, however, that this application, when built, does rely upon third-party packages which are under their own licensing terms and conditions. Please see the credits section for more information on these third-party packages. 

# Credits

## <h2>Third Party Software Package Attribution</h2>

This application makes use of software packages which are under their own separate license agreements and copyright information. The following packages are not committed to this repository but are necessary installations to properly build the application. In keeping with the terms of these license agreements, the packages are listed below along with their respective copyright information, license agreements, and repository links. To install these packages, use the links provided, or find them using the NuGet Package Manager built into Visual Studio. Please note that the packages listed below may contain their own dependancies, each with their own licensing terms and conditions. In no way do I intend to claim ownership over work that is not mine. If I have failed to give proper attribution and/or have not properly complied with a license agreement, please reach out to me through my contact information listed on GitHub.

Dapper 2.1.35 Copyright (c) Stack Exchange, Inc.

Licensed under Apache, Version 2.0 which can be found at https://www.apache.org/licenses/LICENSE-2.0

Link to NuGet Package: https://www.nuget.org/packages/Dapper/2.1.35

Link to the Dapper repository on Github: https://github.com/DapperLib/Dapper

---

Microsoft.Data.SqlClient (6.0.1) Copyright (c) .Net Foundation. All Rights Reserved

Licensed under the MIT License which can be found at https://github.com/dotnet/SqlClient/blob/main/LICENSE

Link to NuGet Package: https://www.nuget.org/packages/Microsoft.Data.SqlClient/6.0.1

Link to SqlClient repository on GitHub: https://github.com/dotnet/SqlClient

---

System.Configuration.ConfigurationManager (9.0.1) Copyright (c) .Net Foundation and Contributors. All Rights Reserved.

Licensed under the MIT License which can be found at https://github.com/dotnet/runtime/blob/main/LICENSE.TXT

Link to NuGet Package: https://www.nuget.org/packages/System.Configuration.ConfigurationManager/9.0.1

Link to GitHub repository: https://github.com/dotnet/runtime

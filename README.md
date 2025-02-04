# Title

recipe-organizer

# About

I created this WPF application in Visual Studio 2022 to assist my wife in meal planning and preparation. This app provides a convenient way to create, store, and display recipe names along with their ingredients and proportions. While it does not contain the instructions for each recipe, it does provide a convenient place for my wife to quickly access the ingredients lists for various recipes without relying on her memory or scattered notes.

By clicking the "create recipe" button on the top of the home screen, a user is able to input data which will create a new recipe, along with its ingredients and their proportions. The recipe and its information are saved in a database. Once saved, the recipe name will appear in a list on the left side of the home page. The application works by having a list of recipes on the left side of the main page. Upon selecting a recipe and clicking a button, the list of ingredients will appear along with their proportions on the right side of the main page.

# How to Build

<h2>Getting Started</h2>

<h2>Setting Up the Database</h2>

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

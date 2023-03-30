# RainbowPlant inventory storage tool. 

This is an ASP.NET Core MVC web development with controllers and views application project. 
It is intended to help the user to track an inventory of trees and bushes at `RainbowPlant` store. 
A User can add/post a new arrived inventory item, get or update details on a particular item and delete an item.

### Description of the functionality: 
The application opens a Home page with a link to the Inventory list. 
The Inventory list page currently has a list of 6 plants with fields: `Plant Name`, `Plant Description`, `Date Delivered`, `Quantity`, `Unit Price`. 
Each inventory line has 3 options: `Edit`, `Update`, `Delete`. On the top of the page, there is an option to `Create` a new inventory item.

### Feature requirements implemented in this project:
1. Made a CRUD MVC application.
2. Implement a regular expression (regex). I implemented a regex to validate Unit Price field to insure there are only 2 decimal places.
3. Implemented async await.
4. Implemented EF (with 1 table)

### Usage:
1. Clone the repo on your machine
2. Fetch NuGet packages.
3. Run the project

### System requirements:
Visual Studio 2022, .NET 7.0 
If you cannot run the project and receive an exception at launch, you need to add "Database.EnsureCreated()" method inside
PlantContext constructor and then it should run with no problems.
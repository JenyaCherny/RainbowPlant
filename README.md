#RainbowPlant inventory storage tool. 

This is an ASP.NET Core MVC web development with controllers and views application project. 
It is intended to help the user to track an inventory of trees and bushes at `RainbowPlant` store. 
A User can add/post a new arrived inventory item, get or update details on a particular item and delete an item.

###Description of the functionality: 
The application opens a Home page with a link to the Inventory list. 
The Inventory list page currently has a list of 6 plants with fields: `Plant Name`, `Plant Description`, `Date Delivered`, `Quantity`, `Unit Price`. 
Each inventory line has 3 options: `Edit`, `Update`, `Delete`. On the top of the page, there is an option to `Create` a new inventory item.

###Feature requirements implemented in this project:
1. Implement a regular expression (regex). I implemented a regex to validate Unit Price field to insure there are only 2 decimal places.
2. Made a CRUD MVC application.
3. Add comments to your code explaining how you're using at least 2 of the solid principles (still working to add)

And most likely I will add unit tests.
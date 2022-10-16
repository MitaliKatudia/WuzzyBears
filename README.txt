2022-10-08  06:15pm

Created by : Mitali Katudia
Purpose : Create ASP.NET Core Web App
Used Individual Accounts for accessibility
Added a README file 
Changed the Views/Home/Index.cshtml file to display 'Welcome to Wuzzy Bears Company' instead of Welcome.
Had a look at the packages installed.... 
Updated some of the packages packages according to the requirement
Did not have Microsoft.VisualStudio.Web.CoreGeneration.Design package.
Installed the new package from Project/Manage NuGet Packages
Created a Git Repository named WuzzyBears
Build the application again and tried to test it.
Displayed the title correctly... Completed Part 1 of the Tutorial.

---------------------------------------------------------------------------------------------
Part 2 of Application - Add a Controller

Added a new controller called HelloWorld in Controllers folder.
Coded some content inside the controller to output the result when navigated
Tested the app by visiting  https://localhost:44311/HelloWorld and https://localhost:44311/HelloWorld/Welcome
Outputted the desired results.
Edited the Welcome method to display name and numTimes
Tested the application by URl: https://localhost:44311/HelloWorld/Welcome?name=Mitali&numTimes=4
Tried various names and numbers... it works good.
Modified Welcome method to display Id instead of numTimes... tested with URL: https://localhost:44311/HelloWorld/Welcome?name=Mitali&Id=3
When tested with numbers greater than its capacity, the Id as well as numTimes returns '1' instead of a long number
Finished Part 2 of the Application. 2022-10-08,  07:06pm
Tried Pushing the code to github... shows folowwing error:
	Hint: You can replace "git config" with "git config --global" to set a default
	Hint: preference for all repositories. You can also pass --rebase, --no-rebase,
	Hint: or --ff-only on the command line to override the configured default per
	Hint: invocation.
	Unable to pull because your local and remote branches changed.
	Set your preferred Git behavior for how to reconcile diverged branches in Git settings.

Tried closing the application and cloning repository and started Part 2 Again..... 
Edited the HelloWorldController.cs again....what a mess... 
Tested the Application again.. eveything good....
Committed the changes.....uff that was difficult....please dont go wrong again..
Finished Part 2 of Application
Closing the Application for now.... 2022-10-08, 07:44pm

---------------------------------------------------------------------------------------------
2022-10-09, 07:50pm
Rebuilt the project and tested it....everything looks good

Part 3 of Application - Add a View
Changed Action method in HelloWorldController.cs
Created a new folder - HelloWorld in Views folder and added an Index.cshtml file
Defined content to display from this template. This goes in the HelloWorldController.cs method and then it call out from here.
Modified the Naming conventions in Views/Shared/_Layout.cshtml to change titles suitable for the Application
Tested the app.... Looks nice...
Took a Tea Break...... :)
Added a new method in HelloWorldController to View Data
Tested the application with Different names and numbers... URL: https://localhost:44311/HelloWorld/Welcome?name=Mitali&numTimes=4
Works Perfect....
Completed Part 3 of the Application 09:05pm.

---------------------------------------------------------------------------------------------
2022-10-10, 02:17pm

Part 4 of Application - Add a Model
Added a new Class in Models called WuzzyBear.cs
Defined properties to be displayed in the database. 
TeddyId, TeddySerialNumbr, TypeOfTeddy, MaterialOfTeddy, ManufacureDate, SizeOfTeddy, CostOfTeddy
These are the suitable propertes to display a list of Teddy Bears according to me....lol
Created a database context class WuzzyBearContext.cs in Data and modified the content according to my application names
Registered the database with dependency injection in startup.cs
Setted the database connection string in appsettings.json by replacing default connection to WuzzyBearContext

Tried Scaffolding the controller with option WuzzyBears.Data.WuzzyBearContext....
It shows error of a Parameterless argument and a no parameter less contructor defined..,commiting all changes for now
I need 10 mins to refresh myself....uffff
Tried scaffolding the data context with ApplicationDbContext
Another error found was a primary key not defined.. might be because I used TeddyId
Changed the property to Id and it worked.... 
okayy? that was weird... according to me that should not be a problem...
The scaffolding added new folder WuzzyBears with new foiles to CRUD Pages
Initiated Migration by Tools > NuGet Package Manager > Package Manager Console
Added code--> Add-Migration InitialCreate.....showed error and asked to specify the database context
Tried again with--> Add-Migration InitialCreate -Context ApplicationDbContext
Updated database with--> Updated-Database -Context ApplicationDbContext
Examined newly created pages and compared them with the MvcMovie Tutorial....
Tested the Application and clicked the WuzzyBears App link... showed database row and columns.....
This was the longest Part till now... Ended at 04:50pm

---------------------------------------------------------------------------------------------
2022-10-12, 11:24pm

Ahh...had a long day with javascript midterm and other php assignment....had a good score in today's exam...:)
Part 5 of Application - Seed the Database
Edited some connection database in Startup.cs and appsettings.json
Created a class called SeedData.cs and added some Data to load in the database
Initialized seed in Program.cs by replacing some content.
Lets rebild the project...and run the application
Oooppppss... forgot to update the database
Will try running again after adding command to update database
The application now shows my seeded data in the database...
Finished Part 5 of the Tutorial
Gonna get some sleep now.... Ended at 12:40am

---------------------------------------------------------------------------------------------
2022-10-13, 12:12pm

Starting Part 6 of Application - Controller Methods and Views
Not gonna repeat the mistake from yesterday night and UPDATE THE DATABASE FIRSTTTT.....
Modified the names of the columns from pascal Casing to display a different name.
Examined and did changes in files where necessary according to my company name and previously defined variables
Run the application.... everything works fine
Commpleted Part 6 Of the Application....12:45pm

Started Part 7 of Application - Add Search Button
Updated the IActionResult method in WuzzyBears Controller to when someone passes a string in URl to Search....
Played with the method with different properties to search from.... URl:
Everytime it is not convenient for user to type such URl....honestly its frustrating
Added a form in Views/WuzzyBears/Index.cshtml so that the user can use it as a search button and filter accordingly...
Ran the application and tried different strings to search the Types of Teddy Bears Available...
Added a new class for Model for search component called WuzzyBearMaterialViewModel.cs
Changed some Variable names suitable and modified Index method in wuzzy bears controller.....
It was confusing to change all variables and properties to match from both controllers and Models...
Added the model in Index.cshtml to add search by material to Index View
Lets run the application.....works perfect...
Finished Part 7 of Application....Gotta go to College for lec... ended at 02:35pm

---------------------------------------------------------------------------------------------
2022-10-13, 04:45pm

Started Part 8 of Application - Add a New Field
Added a new Integer property called CustomerRating in WuzzyBear.cs
Binded the new property in Create and Edit methods, added new rows and other thins needed in Index.cshtml
Added the new Property for every WuzzyBear in SeedData.cs
Ran command Add-Migration CustomerRange -Context ApplicationDbContext
Showed the following Warning -- An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
Updated the Database with command -- Update-Database -Context ApplicationDbContext
Started the application again.....Everything went well but the data I updated in SeedData.cs did not show.
Closing the application and starting it again....
Built the application again and updated the database... ran the app and now it has the data I manually added in SeedData.cs
Completed Part 8 of Application....Ended at 06:09pm

Started Part 9 of Application - Adding Validation, 08:25pm
Added validation I felt appropriate for my properties....
Ran the application and tried to create false data to check validations... works good
Examined some methods in files...
Completed Adding Validation, Completed Microsoft Tutorial...10:00pm

---------------------------------------------------------------------------------------------
2022-10-13, 11:30pm

In the _Layout.cshtml, inside foot added a small code to show current date and time when the application is runned... @DateTme.Now
Created a new View in Home called AboutUs.cs and added the new View in HomeController.cs
Added an 'About Us' link in _Layout.cshtml.....
Added content about introduction, headquaters, employees and product description.
Added Images folder in wwwroot with images
Coded a flex wrap content to show in the page... code from one of my previous assignments in Semester 3
I dont know why but some thing is not working out and the images are not shown as I prefer.... will try something else
After some sweating struggle it is good.... AboutUs Content is now ready.
Changed css styles as per my preferences and the website looks presentable....
Will do the final touching tomorrow....Lets get some sleep.....Ended at 02:40am

---------------------------------------------------------------------------------------------
2022-10-16, 04:40pm
Did some css changes....added a photo in company's home page....
Doing final touches to the application

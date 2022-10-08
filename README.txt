2022-10-08  06:15pm

Created by : Mitali Katudia
Purpose : Create ASP.NET Core Web App
Used Individual Accounts for accessibility
Added a README file 
Changed the Views/Home/Index.cshtml file to display 'Welcome to Wuzzy Bears Company' instead of Welcome.
Had a look at the packages installed.... 
Updated some of the packages packages according to th requirement
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
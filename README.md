# Mini Gig RESTFul API Service
MiniGigApi is a ASP.NET Core Web application created in Visual Studio 2019 Professional, ASP.NET Core 3.1, Entity Framework Core 3.1 and c#.

The code illustrates the following topics:
* Implementation of a RESTful service using ASP.NET Core 3.1
* Encapsulation of Entity Framework Core 3.1 using GenericRepository for CRUD operations
* Allow for error handling in an HTTP way
* Testing API using POSTMAN

# Getting Started to use Postman
Install Postman and Import Request Collection
Open Postman.
Click Import, click Choose Files and specify NetCoreWebApiMiniGig.postman_collection.json. ...
Click on the settings icon in the top-right corner of the Postman interface next to the Eye icon to import an Environment.
Next, click on the Import button at the bottom of the Manage Environments screen and choose the localhost.postman_environment.json file


# Getting Started
To run the sample locally from Visual Studio:
* Build the solution
* Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
* Select the MiniGigApi as Default Project
* Enter the following command: Update-Database –Verbose
* Press F5 to debug

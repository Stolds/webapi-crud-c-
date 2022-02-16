# webapi-crud-c-
the project are set to run in a development environment at .NET, the .NET version is 6.0.102, and are using up to date frameworks, to run the API in your machine you have to have 
those versions of .NET core mentioned before, you can look at CRUD.csproj file to see what is the properly versions of the frameworks to make the application run properly in your 
machine.

Also do you have to install a package according to the database you will run at your computer and change the "connection string" structure at the file appsettings.Development.json 
or appsettings.json, which depends how your .NET hosting environment is defined, with you are having trouble with it, you can just set the hosting environment to development mode 
writing the following command line at your terminal 
$Env:ASPNETCORE_ENVIRONMENT = "Development"

after all the settings do you can use the API on postman or using Swagger UI throgh the web browser with this link: https://localhost:5001/swagger

the project is simple, but this is the second API I builded, I yet have to learn a lot.

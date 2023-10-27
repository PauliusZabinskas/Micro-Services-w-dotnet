# List of commands and explanation:

## 8. Create first micro service

-  Create a folder
	- ``mkdir <folderName>``
-   Change current working directory to folder
	- `cd <folderName>`
- Create a solution file first:
	- `dotnet new sln`
- Now we create web api and will direct to store this api in source folder.
	- `dotnet new webapi -o src/AuctionService` 
- Becouse in this case we are using a solutions file, we can put api to the solutions file:
	- `dotnet sln add src/AuctionService`

## 9 . Reviewing and simplifying the project

- Cleaning initial files will be added to git branch for future review
- To run api, live updates, hot reloads:
	- `dotnet watch`
## 10. Adding the entity classes
- Create new folder in Auction Services called `Entities`
- Create new file, class `Auction.cs` [[Auction class]] 
	- Auction class has nested classes
- Added some code in [[Item Class]] to indicate one-to-one mapping with [[Auction class]] 
## 11. Adding the Database context class
- Recommended to instill #NuGetGallery extension
	- Then use command `ctrl+shift+p` to open all commands 
	- Type `Nuget` and open Nuget gallery 
- Look for `Microsoft.EntityFrameworkCore.Design`package 
	- This package will be used to create migrations
	- will create DB schema via the code we wrote
- Then, install `Npgsql.EntityFrameworkCore.PostgreSQL`
- Also, install `AutoMapper.Extensions.Microsoft.DependencyInjection`
	- There are existing issues with auto mapper but for this tutorial will be ok. 
- Create new folder in Auction Service (main folder) `Data`
	- Create new file [[AuctionDbContext]] 
- Open [[Program class]] and modify the code as shown in the file
- Then, open [[appsettings.Development]] change the details as shown
- Then we need to install `dotnet ef`
	- `dotnet tool install dotnet-ef -g`
#### Ready to create first migration!
- Command to create first migration:
	- `dotnet ef migrations add "Initial Migration" -o Data/Migrations`
## Unrelated but worth to take a note of

- To check what SDK we have:
	- `dotnet --info`
- To check what can be created with dotnet
	- `dotnet new list`
- `>developer:reload window` 
- To find if `dotnet` tools is installed
	- `dotnet tool list -g` paste to terminal
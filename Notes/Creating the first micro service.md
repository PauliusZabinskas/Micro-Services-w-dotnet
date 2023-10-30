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
## 12. Adding a Postgres database server
- The database will be running using docker. 
- Install docker if needed.
- install wsl
	- `wsl --install`
		- I had to make config adjustments to windows features configs:
			- turn on: Virtual Machine Platform
			- turn on: windows Hypervisor Platform
		- This will interfere with Networks & Communications module
- at a solution level create `docekr-compose.yml` file
	-  ![[Pasted image 20231030154649.png]]
	- naming is requirement.
- Next: will need to [[docker-compose.yml file]] should contain formation about services used, and image used.
- Then run command:
	- `docker compose - up -d`
	- resulting in:
		- ![[Pasted image 20231030155416.png]]
	- Next: run command `dotnet ef database update`
		- This commend will update postgres running on docker with current database.
	- To inspect database in docker new extension will be needed for VS code
		- `PostgreSQL`
		- Click on postgreSQL icon:
			- Press on create `+` to create new instance on postgreSQL
				- host name: `localhost`
				- postgreSQL user: `postgres`
				- password: `postgrespw`
				- port number: `5432`
				- connection: `standard connection`
				- name of DB: `auctions`
				- display name: `localhost`
				- Result:
				- ![[Pasted image 20231030160841.png]]

## 13. Creating seed data
- The Database now is up & running
- To initiate some data:
	- We need to create new class inside `Data` folder [[DbInitializer.cs file]]
	- [[Program class]] file was updated.
- To change the DB context we will need to drop DB first
	- `dotnet ef database drop`
	- now run `dotnet watch`
		- this will populate DB with new data

## 14. Shaping the data to return
- Creating return DTOs
- In `Auction` folder create new folder `DTOs` to store DTO files
	- Create [[AuctionDTO.cs file]] 
	- Create [[CreateAutionDTO.cs file]]
	- Create [[UpdateAutionDTO.cs file]]
	- Create new folder inside Auctions `RequestHelpers`
		- inside this folder create [[MappingProfiles]] for AutoMaper. 
	- And one more time need to update [[Program class]]
## 15. Adding an API controller
## Unrelated but worth to take a note of

- To check what SDK we have:
	- `dotnet --info`
- To check what can be created with dotnet
	- `dotnet new list`
- `>developer:reload window` 
- To find if `dotnet` tools is installed
	- `dotnet tool list -g` paste to terminal
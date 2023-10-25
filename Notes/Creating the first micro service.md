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
- Create new folder in AuctionServices called `Entities`
- Create new file, class `Auction.cs`
- 
## Unrelated but worth to take a note of

- To check what SDK we have:
	- `dotnet --info`
- To check what can be created with dotnet
	- `dotnet new list`
- `>developer:reload window` 
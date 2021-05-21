# Project Name

#### _Brief Project Description, 5/21/2021_

#### By _**Tiffany Greathead**_

## Description

Project Description.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [MySQL Community Server][https://dev.mysql.com/downloads/file/?id=484914]

### Installation

1. Clone the repository: `$ git clone {clone link}`
2. Navigate to the `{Template.Solution}` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a database using MySQL:
   - Open your terminal and type: `mysql -uroot -pyour_password_here` (replace `your_password_here` with your MySQL password) and select the enter key
   - Type the following commands to setup the database:
     - > `CREATE DATABASE firstname_lastname;`
     - > `USE firstname_lastname;`
     - > `CREATE TABLE template_category (TemplateCategory INT, SomeProperty VARCHAR (255));`
     - > `CREATE TABLE template_item (TemplateItemId INT, TemplateCategoryId Int);`
5. To run the console app:
   - Navigate to `{Template.Solution/WeekThreeTemplate}` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `{Template.csproj}`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`

## Known Bugs

_No known bugs_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

- C#
- .NET 5 SDK
- ASP.NET
- Bootstrap

### License

MIT License.

Copyright (c) 2021 **_Tiffany Greathead_**

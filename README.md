BDD - https://specflow.org/getting-started/
https://www.softwaretestinghelp.com/specflow-and-selenium/
Install-Package Selenium.WebDriver.ChromeDriver
Install-Package Selenium.WebDriver
Install-Package DotNetSeleniumExtras.WaitHelpers

TDD - NUnit

Entity Framework
cd C:\Users\Administrador\source\repos\WebTddBdd\WebTddBdd
dotnet tool install --global dotnet-ef
dotnet add package EntityFrameworkCore
dotnet add package EntityFrameworkCore.SqlServer
dotnet add package EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Tools
dotnet ef migrations add ClienteMigration
dotnet ef database update
dotnet run
dotnet build

dotnet tool install --global dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name ClientesController


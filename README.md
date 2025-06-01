1) TODO:
   - try models with required keyword
2) 
   - Microsoft.AspNetCore.OpenApi
   - Microsoft.EntityFrameworkCore
   - Microsoft.EntityFrameworkCore.Design
   - Microsoft.EntityFrameworkCore.SqlServer
   - Microsoft.EntityFrameworkCore.Tools
2) .gitignore
3) appsettings.json:
   "ConnectionStrings": {
      "Default": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=apbd;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
   }
3) - Controllers/
   - DTOs/
   - Data/DatabaseContext
   - Exceptions
   - Migrations/
   - Models/
   - Properties/
   - Services/DbService & IdbService
4) Models
   - DataAnnotations
   - DataAnnotations.Schema
5) Controllers
   - [ApiController][Route("api/...")]
   - implement in build, Program.cs
6) DTOs
7) IDbService, DbService, DatabaseContext
8) Exceptions
9) Create dummy set in DatabaseContext
10) dotnet ef migrations add Init
    dotnet ef database update

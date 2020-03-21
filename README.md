Comment/uncomment entity.HasNoKey() before run/migrate

commands:
>dotnet new console
>dotnet add package Microsoft.EntityFrameworkCore.Sqlite
>dotnet add package Microsoft.EntityFrameworkCore.Design
>dotnet ef dbcontext scaffold "Data Source=DBStudents.db" Microsoft.EntityFrameworkCore.Sqlite -o Models
>dotnet ef migrations add InitialCreate
>dotnet ef database update

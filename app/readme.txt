repo: https://github.com/VladimirN73/postgres_01
file: app/readme.txt

=====================================================================
History (newest on top)
=====================================================================
26.02.23 WebApi: connect to db (running in docker)

2022
dotnet list package --outdated --interactive
dotnet tool update --global dotnet-ef 
dotnet ef migrations add "orderDate" --context "ApiDbContext"
dotnet ef dbcontext scaffold "username=postgres;Password=password;Server=localhost;Port=5432;Database=postgres-01; Integrated Security=true;Pooling=true;" Npgsql.EntityFrameworkCore.PostgreSQL  --context "MyDbContext" --context-dir "Models"  --output-dir "Models"
add column manually and try to generate context from Database
dotnet ef migrations add "orderDate" -- nope. OrderDate is not created
add DateOnly column "OrderDate"
dotnet ef database update
dotnet ef migrations add "initial_migrations"


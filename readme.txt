file: ./readme.txt

TODOs
add backend with swagger and connection to DB, run the app in containers (in docker) and locally


NEXT STEPS
deploy current docker-compose to the cloud (shall we deploy pgadmin too?)

DONE
* deploy to PWD (play with docker)

===================================================
History (newest on top)
===================================================
23.02.23 add docker-stack (run in PWD Play With Docker)
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
move source into ./app
dotnet new webapi -n App.WebApi  -- create web app (api)
review https://dev.to/moe23/net-6-with-postgresql-576a 
run local pgAdmin and connect to my postgres in docker
use 01.bat - create local postgres in docker
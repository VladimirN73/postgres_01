repo: https://github.com/VladimirN73/postgres_01
file: ./readme.txt

TODOs
add backend with swagger and connection to DB, run the app in containers (in docker) and locally


NEXT STEPS
1. https does not work in PWD. Shall it be fixed?     
   
2. Create image (for app) by push into github, and upload it to docker-hub
   
2. deploy docker-compose to the azure-cloud

DONE (newest on top)
* use the uploaded docker image in docker-stack
* use the uploaded docker image in docker-compose
* create docker image (localy) and upload it do docker-hub
* add backend with swagger and connection to DB, run the app locally and DB in container
* deploy to PWD (play-with-docker), see folder docker-stack


LINKS
https://learn.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-7.0 

===================================================
History (newest on top)
===================================================
05.03.23
 docker-stack (pwd) does not work due to https
 remote docker-compose is done
 local docker-compose is done 
28.02.23
 re-try create-push-pull-run. It works! Just navigate to http://localhost:8080/swagger/index.html
 
27.02.23
 https://docs.docker.com/docker-hub/repos/
 create image img-erp-webapi and put it into docker hub
 
26.02.23 
 https://learn.microsoft.com/en-us/azure/container-instances/tutorial-docker-compose
 add backend with swagger and connection to DB, run the app locally and DB in container

25.02.23 add docker-stack (run in PWD Play With Docker)

2022 
move source into ./app - see app/readme.txt
dotnet new webapi -n App.WebApi  -- create web app (api)
review https://dev.to/moe23/net-6-with-postgresql-576a 
run local pgAdmin and connect to my postgres in docker
use 01.bat - create local postgres in docker
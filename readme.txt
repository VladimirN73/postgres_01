repo: https://github.com/VladimirN73/postgres_01
file: ./readme.txt

TODOs
add backend with swagger and connection to DB, run the app in containers (in docker) and locally


NEXT STEPS 
1. deploy docker-compose-acr to the azure-cloud, usnig the images from docker-hub
1. deploy docker-compose to the azure-cloud
2. Create image (for app) by push into github, and upload it to docker-hub
   


DONE (newest on top)
* use the uploaded docker image in docker-stack
* use the uploaded docker image in docker-compose
* create docker image (localy) and upload it do docker-hub
* add backend with swagger and connection to DB, run the app locally and DB in container
* deploy to PWD (play-with-docker), see folder docker-stack

WILL NOT DONE
1. https does not work in PWD. Shall it be fixed? ---- Nope. Probably not. Do not loose time for this  

LINKS
https://learn.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-7.0 

===================================================
History (newest on top)
===================================================
12.23.03
 https://docs.docker.com/cloud/aci-integration/#using-azure-file-share-as-volumes-in-aci-containers
 
 probably the issue with volumes

 docker-compose up  <--- nothing happens
 docker context ls
 docker context use erpcontext
 docker context create aci erpcontext
 docker login azure
 cd C:\data\github\postgres_01\docker-compose-acr
 az acr login --name erpcontainerregistry
 try to repeat the below steps my erp-app : doker-compose-acr

09.03.23 
 docker-compose up --build -d  <---- nothing happens
 the key N0G... is copied from prev command
 az storage account keys list --resource-group erp --account-name erpgroupestorage --query "[0].value" --output tsv
 az storage share create --name erpshare --account-name erpgroupestorage
 az storage account create --resource-group erp --name erpgroupestorage  --location westeurope  --sku Standard_LRS
 check https://learn.microsoft.com/en-us/azure/container-instances/container-instances-volume-azure-files
 docker-compose up --build -d    <---- ERROR, cannot retrieve fileshare name for Azure file share
 cd C:\data\github\postgres_01\docker-compose-acr-local
 az acr login --name erpcontainerregistry
 now try to repeat the below steps my erp-app
 
 docker compose down
 check that the services available in azure -- yes, it works.
 docker ps   <---- see the ip where the services are running.
 docker compose up
 
 docker context ls
 docker context create aci myacicontext
 docker login azure
 az acr repository show --name votegroupeacr --repository azure-vote-front
 docker-compose push
 docker-compose up --build -d 
 cd c:\data\github\azure-voting-app-redis\
 az acr login --name votegroupeacr
 continue tutorial https://learn.microsoft.com/en-us/azure/container-instances/tutorial-docker-compose
 
06.03.23
 in azure create container registry 'erpcontainerregistry'
 in azure create the resource group 'erp'
 follow this tutorial https://learn.microsoft.com/en-us/azure/container-instances/tutorial-docker-compose
 try to deploy docker-compose to the azure-cloud
 
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
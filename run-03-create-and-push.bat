
docker login

REM create
cd app
cd App.WebApi
set name=erp-webapi
set image=vnalivaika/img-%name%

docker build -t %image% .

REM push
docker push %image%:latest

pause
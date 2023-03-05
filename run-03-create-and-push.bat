
docker login

REM create
cd app
cd App.WebApi
set name=erp-webapi
set image=img-%name%
docker build -t vnalivaika/%image% .

cd ..
cd ..

cd frontend
set name=erp-frontend
set image=img-%name%
docker build -t vnalivaika/%image% .

REM push
docker push vnalivaika/img-erp-webapi:latest
docker push vnalivaika/img-erp-frontend:latest

pause
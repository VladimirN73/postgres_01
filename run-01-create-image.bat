
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

pause
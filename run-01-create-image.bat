
cd app
cd App.WebApi

set name=erp-webapi
set image=img-%name%

docker build -t vnalivaika/%image% .

pause
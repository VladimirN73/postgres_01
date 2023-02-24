
@echo off 
REM
REM https://github.com/docker-library/docs/blob/master/postgres/README.md
REM 
REM docker run --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres
REM 
@echo on

set container=my-postgres

docker rm --force %container%
docker run --name %container% -e POSTGRES_PASSWORD=password -dp 5432:5432 postgres 

pause
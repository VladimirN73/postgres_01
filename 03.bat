
@echo off 
REM
REM https://docs.docker.com/engine/reference/commandline/build/
REM 
REM Build an image from a Dockerfile
REM
REM  docker build [OPTIONS] PATH | URL | -
REM
REM --tag , -t		Name and optionally a tag in the 'name:tag' format
REM
REM 
@echo on

docker run --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres


set name=postgres
set image=image_local_%name%
set container=ctn_local_%name%


docker build -t %image% .

docker rm --force %container%

docker run --name %container% -dp 80:80 %image% python -m flask run --host=0.0.0.0 --port=80

pause
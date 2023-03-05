
REM https://docs.docker.com/docker-hub/repos/
REM Pushing a Docker container image to Docker Hub
REM To push an image to Docker Hub, you must first name your local image using your Docker Hub username 
REM and the repository name that you created through Docker Hub on the web.

REM You can add multiple images to a repository by adding a specific :<tag> to them (for example docs/base:testing). 
REM If it’s not specified, the tag defaults to latest.

REM Name your local images using one of these methods:

REM When you build them, using docker build -t <hub-user>/<repo-name>[:<tag>]
REM By re-tagging an existing local image docker tag <existing-image> <hub-user>/<repo-name>[:<tag>]
REM By using docker commit <existing-container> <hub-user>/<repo-name>[:<tag>] to commit changes
REM Now you can push this repository to the registry designated by its name or tag.


REM docker push <hub-user>/<repo-name>:<tag>
REM The image is then uploaded and available for use by your teammates and/or the community.

docker login

docker push vnalivaika/img-erp-webapi:latest
docker push vnalivaika/img-erp-frontend:latest

pause
repo: https://github.com/VladimirN73/postgres_01
file: docker-compose/readme.txt

goal: start docker compose using the images from docker-hub

Commands
docker-compose rm -s -v -f    --- removes containers and unnamed volumes declared in docker-compose.yaml
docker-compose down -v        --- removes named volumes declared in docker-compose.yaml

History (newest on top)
27.02.23 add 03-docker-compose.webapi.yml
23.02.23 improve run-remove.ps1
19.02.23 working with docker compose

repo: https://github.com/VladimirN73/postgres_01
file: docker-stack/readme.txt


Links:
 https://training.play-with-docker.com/ops-s1-swarm-intro/#

 direct link
 https://labs.play-with-docker.com/?stack=https://raw.githubusercontent.com/VladimirN73/postgres_01/main/docker-stack/docker-stack.yml


commands
docker stack ls
docker stack services voting_stack

commands/steps:
1. navigate to https://labs.play-with-docker.com and login
2. in templates select "one manager, one worker"
3. Go to the manager-window and run the commands 
   git clone https://github.com/VladimirN73/postgres_01
   cd postgres_01
   cd docker_stack
   docker stack deploy --compose-file=docker-stack.yml erp_stack

=====================================================================
History (newest on top)
=====================================================================

01.03.23 
 add service 'webapi'. hm, docker-stack in PWD does not work now ... 
 either noting is created or if created then the swagger/index.html is not working ...

25.02.23 
 follow https://training.play-with-docker.com/ops-s1-swarm-intro/#
 created
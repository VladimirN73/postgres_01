
set name=erp-fronend
set image=img-%name%

docker build -t %image% .

docker run -p 3000:3000 -d %image%

pause
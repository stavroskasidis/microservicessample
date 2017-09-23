rem @echo off
cd /d "%~dp0"

cd "SampleApp.Web"
dotnet publish -c "Release" -o "bin\Release\PublishOutput"
docker build -f Dockerfile-publish -t microservicessample.azurecr.io/sampleapp.web:manual .
docker push microservicessample.azurecr.io/sampleapp.web:manual

cd ../SampleApp.Service1
dotnet publish -c "Release" -o "bin\Release\PublishOutput"
docker build -f Dockerfile-publish -t microservicessample.azurecr.io/sampleapp.service1:manual .
docker push microservicessample.azurecr.io/sampleapp.service1:manual

cd ../SampleApp.Service2
dotnet publish -c "Release" -o "bin\Release\PublishOutput"
docker build -f Dockerfile-publish -t microservicessample.azurecr.io/sampleapp.service2:manual .
docker push microservicessample.azurecr.io/sampleapp.service2:manual
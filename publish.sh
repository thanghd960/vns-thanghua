# pull code
echo 'Pulling ...'
git pull


echo 'Publish app ...'
dotnet publish thanghd-vnstyle.sln -c Release -o out

echo 'Build Image ...'
docker build -t thanghd96/thanghd-vnstyle-tattoo .

echo 'Push DockerHub ...'
docker push thanghd96/thanghd-vnstyle-tattoo:latest

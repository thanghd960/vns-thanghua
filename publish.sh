# pull code
echo 'Pulling ...'
git pull


echo 'Publish app'
dotnet publish thanghd-vnstyle.sln -c Release -o out

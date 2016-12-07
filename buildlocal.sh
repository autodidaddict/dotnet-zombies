rm -rf _builds _steps _projects _cache _temp
wercker build --git-domain github.com --git-owner autodidaddict --git-repository dotnet-zombies
rm -rf _builds _steps _projects _cache _temp 
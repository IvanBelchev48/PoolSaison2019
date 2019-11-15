FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build

# TODO :
# ok 1) Il faut placer ce Dockerfile au même niveau que le fichier .sln
# ok 2) Travaillez dans le dossier /app du container
# ok 3) Copiez le contenu du dossier courant (celui du dockerfile) dans le dossier courant du container
# ok 4) Dans le container positionnez-vous sur le répertoire qui contient celui qui contient le code (normalement, DECInfo)
# ok 5) Exécuter un dotnet publish de la configuration Release dans un dossier nommé "out"

WORKDIR /app
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime

# TODO :
# ok 1) Travaillez dans le dossier /app du container
# ok 2) À partir de l'image "build" utilisée ci-haut, copiez le contenu du répertoire de publication "out" dans le dossier courant
# ok 3) Exposez le port 6002 (le même qui a été défini dans votre appconfig.json)
# ok 3) Spécifiez le point d'entrée de l'application

WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 6002
ENTRYPOINT ["dotnet", "PoolSaison2019.dll"]

# Une fois fait, lancez le container sur le port 6002 et testez l'application dans votre navigateur



[![wercker status](https://app.wercker.com/status/1c8b7c7ff8f3dbcfdd5a2467bec0efbb/m/master "wercker status")](https://app.wercker.com/project/byKey/1c8b7c7ff8f3dbcfdd5a2467bec0efbb)

# dotnet-zombies

This is an extremely simple *Hello World* microservice using ASP.NET Core. As of this moment, it is built using *coreclr* ASP.NET Core *RC2*.

To build this app with RC2:

`dotnet restore`

`dotnet run`

With the app running, you can hit `/api/zombies` on that app with `GET` to test the resource. You'll notice some interesting console output showing the dependency injection at work for services.

To push this application to any Cloud Foundry:
```
cf push
```

Enjoy!

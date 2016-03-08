# dotnet-zombies

This is an extremely simple *Hello World* microservice using ASP.NET Core. As of this moment, it is built using *coreclr* ASP.NET 5 *RC1*. I will be updating it as ASP.NET revs versions.

To build this app with RC1:

`dnu restore`

`dnx web`

If you find that you have a permissions issue doing either of these commands, `sudo` them.

With the app running, you can hit `/api/zombies` on that app with `GET` to test the resource. You'll notice some interesting console output showing the dependency injection at work for services.

To push this application to any Cloud Foundry:
```
cf push
```

Enjoy!

## create a new console app:
- open powershell 
- navigate to the desired location of the app
- type:
```shell
dotnet new console -n AppName
```
- navegate inside the project.

- check if is working by running:
```shell
dotnet run
```

- check if you are connected to nuget:
```shell
dotnet nuget list source
```

-if you dont have nuget:
```shell
dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org
```

- vscode c# intellisense:
c# & c# dev kit

```shell
dotnet restore
```

```c#
Console.writeline(args[0]);
```
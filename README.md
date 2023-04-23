# CSHelloWorld
A C# HelloWorld with notes on compilation via Windows Terminal.

Compile as follows in Windows Terminal with the `dotnet` command to output a standalone, distributable executable. 
```
dotnet publish --self-contained true --runtime win-x64 /p:PublishSingleFile=true
```

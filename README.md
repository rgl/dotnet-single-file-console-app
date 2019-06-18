# Single file console application

See [SingleFileConsoleApp.csproj](SingleFileConsoleApp.csproj) to known which settings you need to enable to create a single file exe application.

Install [dotnet core 3.0 preview 6](https://github.com/dotnet/core/blob/master/release-notes/3.0/preview/3.0.0-preview6.md).

Build and publish the single file application:

```bash
dotnet publish -r win-x64 -c Release
```

And execute:

```bash
./bin/Release/netcoreapp3.0/win-x64/publish/SingleFileConsoleApp.exe
```

You should see something like:

```plain
Process Id:
    2924
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             C:\Users\Rui Lopes\Desktop\SingleFileConsoleApp\bin\Release\netcoreapp3.0\win-x64\publish\SingleFileConsoleApp.exe
    InternalName:     SingleFileConsoleApp.dll
    OriginalFilename: SingleFileConsoleApp.dll
    FileVersion:      1.0.0.0
    FileDescription:  SingleFileConsoleApp
    Product:          SingleFileConsoleApp
    ProductVersion:   1.0.0
    Debug:            False
    Patched:          False
    PreRelease:       False
    PrivateBuild:     False
    SpecialBuild:     False
    Language:         Idioma neutro
Process Current Directory:
    C:\Users\Rui Lopes\Desktop\SingleFileConsoleApp
Process MainModule FileName:
    C:\Users\Rui Lopes\Desktop\SingleFileConsoleApp\bin\Release\netcoreapp3.0\win-x64\publish\SingleFileConsoleApp.exe
Process MainModule Length:
    30581639 (29,164923667907715 MB)
Executing Assembly Location:
    C:\Users\RUILOP~1\AppData\Local\Temp\.net\SingleFileConsoleApp\2jejrexs.5y3\SingleFileConsoleApp.dll
Executing Assembly CodeBase:
    file:///C:/Users/RUILOP~1/AppData/Local/Temp/.net/SingleFileConsoleApp/2jejrexs.5y3/SingleFileConsoleApp.dll
Press ENTER to exit.
```

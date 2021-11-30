# Single file console application

See [SingleFileConsoleApp.csproj](SingleFileConsoleApp.csproj) to known which settings you need to enable to create a single file exe .NET 6.0 application.

For more information see:

* [Single file deployment and executable](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file)
* [Single file deployment and executable - API incompatibility](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file#api-incompatibility)
* [Trim self-contained deployments and executables](https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained)
* [Trimming options](https://docs.microsoft.com/en-us/dotnet/core/deploying/trimming-options)
* [App Trimming in .NET 5](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)

The following example outputs were done with the [dotnet 6.0 sdk](https://dotnet.microsoft.com/download/dotnet/6.0).

## Windows 2022 host

Build and publish the single file application:

```powershell
dotnet publish --runtime win-x64 --self-contained --configuration Release
```

And execute:

```powershell
./bin/Release/net6.0/win-x64/publish/SingleFileConsoleApp.exe arg1 arg2
```

**NB** The above file does not really contain all the dependencies, you also
need to distribute all the files beside it, like `coreclr.dll`.

You should see something like:

```plain
OS Version:
    Microsoft Windows NT 10.0.20348.0
Environment Version:
    6.0.0
Environment Framework:
    .NET 6.0.0-rtm.21522.10
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v6.0
AppContext BaseDirectory:
    C:\vagrant\dotnet-single-file-console-app\bin\Release\net6.0\win-x64\publish\
Command Line Arguments:
    C:\vagrant\dotnet-single-file-console-app\bin\Release\net6.0\win-x64\publish\SingleFileConsoleApp.exe
    arg1
    arg2
Process Id:
    1464
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             C:\vagrant\dotnet-single-file-console-app\bin\Release\net6.0\win-x64\publish\SingleFileConsoleApp.exe
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
    Language:         Language Neutral
Process Current Directory:
    C:\vagrant\dotnet-single-file-console-app
Process MainModule FileName:
    C:\vagrant\dotnet-single-file-console-app\bin\Release\net6.0\win-x64\publish\SingleFileConsoleApp.exe
Process MainModule Length:
    11898907 (11,347681999206543 MB)
Loaded Assemblies:
    Microsoft.Win32.Primitives
    SingleFileConsoleApp
    System.Collections.Concurrent
    System.Collections.NonGeneric
    System.ComponentModel.Primitives
    System.Console
    System.Diagnostics.FileVersionInfo
    System.Diagnostics.Process
    System.Linq
    System.Private.CoreLib
    System.Runtime
    System.Runtime.InteropServices.RuntimeInformation
    System.Text.RegularExpressions
Loaded Modules:
    C:\vagrant\dotnet-single-file-console-app\bin\Release\net6.0\win-x64\publish\SingleFileConsoleApp.exe
    C:\Windows\System32\ADVAPI32.dll
    C:\Windows\SYSTEM32\apphelp.dll
    C:\Windows\SYSTEM32\BCrypt.dll
    C:\Windows\System32\bcryptPrimitives.dll
    C:\Windows\System32\combase.dll
    C:\Windows\System32\GDI32.dll
    C:\Windows\System32\gdi32full.dll
    C:\Windows\SYSTEM32\icu.dll
    C:\Windows\System32\IMM32.DLL
    C:\Windows\SYSTEM32\kernel.appcore.dll
    C:\Windows\System32\KERNEL32.DLL
    C:\Windows\System32\KERNELBASE.dll
    C:\Windows\System32\msvcp_win.dll
    C:\Windows\System32\msvcrt.dll
    C:\Windows\SYSTEM32\ntdll.dll
    C:\Windows\System32\ole32.dll
    C:\Windows\System32\OLEAUT32.dll
    C:\Windows\System32\RPCRT4.dll
    C:\Windows\System32\sechost.dll
    C:\Windows\System32\SHELL32.dll
    C:\Windows\System32\ucrtbase.dll
    C:\Windows\System32\USER32.dll
    C:\Windows\SYSTEM32\VERSION.dll
    C:\Windows\System32\win32u.dll
Press ENTER to exit.
```

## Ubuntu 20.04 host

Build and publish the single file application:

```bash
dotnet publish --runtime ubuntu.20.04-x64 --self-contained --configuration Release
```

And execute:

```bash
./bin/Release/net6.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp arg1 arg2
```

You should see something like:

```plain
OS Version:
    Unix 5.4.0.90
Environment Version:
    6.0.0
Environment Framework:
    .NET 6.0.0-rtm.21522.10
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v6.0
AppContext BaseDirectory:
    /home/rgl/Projects/dotnet-single-file-console-app/bin/Release/net6.0/ubuntu.20.04-x64/publish/
Command Line Arguments:
    /home/rgl/Projects/dotnet-single-file-console-app/bin/Release/net6.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    arg1
    arg2
Process Id:
    9257
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             /home/rgl/Projects/dotnet-single-file-console-app/bin/Release/net6.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    InternalName:
    OriginalFilename:
    FileVersion:
    FileDescription:
    Product:
    ProductVersion:
    Debug:            False
    Patched:          False
    PreRelease:       False
    PrivateBuild:     False
    SpecialBuild:     False
    Language:
Process Current Directory:
    /home/rgl/Projects/dotnet-single-file-console-app
Process MainModule FileName:
    /home/rgl/Projects/dotnet-single-file-console-app/bin/Release/net6.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
Process MainModule Length:
    13248506 (12.634759902954102 MB)
Loaded Assemblies:
    Microsoft.Win32.Primitives
    SingleFileConsoleApp
    System.Collections.Concurrent
    System.Collections.Immutable
    System.Collections.NonGeneric
    System.ComponentModel.Primitives
    System.Console
    System.Diagnostics.FileVersionInfo
    System.Diagnostics.Process
    System.Linq
    System.Private.CoreLib
    System.Reflection.Metadata
    System.Runtime
    System.Runtime.InteropServices.RuntimeInformation
    System.Text.RegularExpressions
Loaded Modules:
    [vdso]
    /home/rgl/Projects/dotnet-single-file-console-app/bin/Release/net6.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    /lib/x86_64-linux-gnu/ld-2.31.so
    /lib/x86_64-linux-gnu/libc-2.31.so
    /lib/x86_64-linux-gnu/libdl-2.31.so
    /lib/x86_64-linux-gnu/libgcc_s.so.1
    /lib/x86_64-linux-gnu/libm-2.31.so
    /lib/x86_64-linux-gnu/libpthread-2.31.so
    /lib/x86_64-linux-gnu/librt-2.31.so
    /lib/x86_64-linux-gnu/libz.so.1.2.11
    /usr/lib/x86_64-linux-gnu/libicudata.so.66.1
    /usr/lib/x86_64-linux-gnu/libicui18n.so.66.1
    /usr/lib/x86_64-linux-gnu/libicuuc.so.66.1
    /usr/lib/x86_64-linux-gnu/libstdc++.so.6.0.28
Press ENTER to exit.
```

# Single file console application

See [SingleFileConsoleApp.csproj](SingleFileConsoleApp.csproj) to known which settings you need to enable to create a single file exe application.

For more information see:

* [Single file deployment and executable](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file)
* [Single file deployment and executable - API incompatibility](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file#api-incompatibility)
* [Trim self-contained deployments and executables](https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained)
* [Trimming options](https://docs.microsoft.com/en-us/dotnet/core/deploying/trimming-options)
* [App Trimming in .NET 5](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)

The following example outputs were done with the [dotnet 5.0 rc.2 sdk](https://dotnet.microsoft.com/download/dotnet/5.0).

## Windows 2019 host

Build and publish the single file application:

```powershell
dotnet publish -r win-x64 -c Release
```

And execute:

```powershell
./bin/Release/net5.0/win-x64/publish/SingleFileConsoleApp.exe arg1 arg2
```

**NB** The above file does not really contain all the dependencies, you also
need to distribute all the files beside it, like `coreclr.dll`.

You should see something like:

```plain
OS Version:
    Microsoft Windows NT 10.0.17763.0
Environment Version:
    5.0.0
Environment Framework:
    .NET 5.0.0-rc.2.20475.5
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v5.0
AppContext BaseDirectory:
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\
Command Line Arguments:
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\SingleFileConsoleApp.exe
    arg1
    arg2
Process Id:
    1464
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\SingleFileConsoleApp.exe
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
    C:\vagrant\dotnet-core-single-file-console-app
Process MainModule FileName:
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\SingleFileConsoleApp.exe
Process MainModule Length:
    3292597 (3.1400651931762695 MB)
Loaded Assemblies:
    Microsoft.Win32.Primitives
    SingleFileConsoleApp
    System.Collections.Concurrent
    System.Collections.NonGeneric
    System.ComponentModel.Primitives
    System.Console
    System.Diagnostics.FileVersionInfo
    System.Diagnostics.Process
    System.IO.FileSystem
    System.Linq
    System.Private.CoreLib
    System.Runtime.InteropServices.RuntimeInformation
    System.Text.RegularExpressions
Loaded Modules:
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\clrjit.dll
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\coreclr.dll
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\net5.0\win-x64\publish\SingleFileConsoleApp.exe
    C:\Windows\System32\ADVAPI32.dll
    C:\Windows\System32\BCrypt.dll
    C:\Windows\System32\bcryptPrimitives.dll
    C:\Windows\System32\cfgmgr32.dll
    C:\Windows\System32\combase.dll
    C:\Windows\System32\cryptsp.dll
    C:\Windows\System32\GDI32.dll
    C:\Windows\System32\gdi32full.dll
    C:\Windows\System32\IMM32.DLL
    C:\Windows\System32\kernel.appcore.dll
    C:\Windows\System32\KERNEL32.DLL
    C:\Windows\System32\KERNELBASE.dll
    C:\Windows\System32\msvcp_win.dll
    C:\Windows\System32\msvcrt.dll
    C:\Windows\SYSTEM32\ntdll.dll
    C:\Windows\System32\ole32.dll
    C:\Windows\System32\OLEAUT32.dll
    C:\Windows\System32\powrprof.dll
    C:\Windows\System32\profapi.dll
    C:\Windows\System32\RPCRT4.dll
    C:\Windows\System32\sechost.dll
    C:\Windows\System32\shcore.dll
    C:\Windows\System32\SHELL32.dll
    C:\Windows\System32\shlwapi.dll
    C:\Windows\System32\ucrtbase.dll
    C:\Windows\System32\USER32.dll
    C:\Windows\SYSTEM32\version.dll
    C:\Windows\System32\win32u.dll
    C:\Windows\System32\windows.storage.dll
Press ENTER to exit.
```

## Ubuntu 20.04 host

Build and publish the single file application:

```bash
dotnet publish -r ubuntu.20.04-x64 -c Release
```

And execute:

```bash
./bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp arg1 arg2
```

You should see something like:

```plain
OS Version:
    Unix 5.4.0.51
Environment Version:
    5.0.0
Environment Framework:
    .NET 5.0.0-rc.2.20475.5
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v5.0
AppContext BaseDirectory:
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/
Command Line Arguments:
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    arg1
    arg2
Process Id:
    9257
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
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
    /home/rgl/Projects/dotnet-core-single-file-console-app
Process MainModule FileName:
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
Process MainModule Length:
    13096682 (12.489969253540039 MB)
Loaded Assemblies:
    Microsoft.Win32.Primitives
    SingleFileConsoleApp
    System.Collections
    System.Collections.Concurrent
    System.Collections.Immutable
    System.Collections.NonGeneric
    System.ComponentModel.Primitives
    System.Console
    System.Diagnostics.FileVersionInfo
    System.Diagnostics.Process
    System.IO.FileSystem
    System.Linq
    System.Private.CoreLib
    System.Reflection.Metadata
    System.Runtime.InteropServices.RuntimeInformation
    System.Text.RegularExpressions
Loaded Modules:
    [vdso]
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/net5.0/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    /lib/x86_64-linux-gnu/ld-2.31.so
    /lib/x86_64-linux-gnu/libc-2.31.so
    /lib/x86_64-linux-gnu/libcom_err.so.2.1
    /lib/x86_64-linux-gnu/libdl-2.31.so
    /lib/x86_64-linux-gnu/libgcc_s.so.1
    /lib/x86_64-linux-gnu/libkeyutils.so.1.8
    /lib/x86_64-linux-gnu/libm-2.31.so
    /lib/x86_64-linux-gnu/libpthread-2.31.so
    /lib/x86_64-linux-gnu/libresolv-2.31.so
    /lib/x86_64-linux-gnu/librt-2.31.so
    /lib/x86_64-linux-gnu/libz.so.1.2.11
    /usr/lib/x86_64-linux-gnu/libcrypto.so.1.1
    /usr/lib/x86_64-linux-gnu/libgssapi_krb5.so.2.2
    /usr/lib/x86_64-linux-gnu/libicudata.so.66.1
    /usr/lib/x86_64-linux-gnu/libicui18n.so.66.1
    /usr/lib/x86_64-linux-gnu/libicuuc.so.66.1
    /usr/lib/x86_64-linux-gnu/libk5crypto.so.3.1
    /usr/lib/x86_64-linux-gnu/libkrb5.so.3.3
    /usr/lib/x86_64-linux-gnu/libkrb5support.so.0.1
    /usr/lib/x86_64-linux-gnu/liblttng-ust-tracepoint.so.0.0.0
    /usr/lib/x86_64-linux-gnu/libssl.so.1.1
    /usr/lib/x86_64-linux-gnu/libstdc++.so.6.0.28
    /usr/lib/x86_64-linux-gnu/liburcu-bp.so.6.1.0
Press ENTER to exit.
```

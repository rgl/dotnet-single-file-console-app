# Single file console application

See [SingleFileConsoleApp.csproj](SingleFileConsoleApp.csproj) to known which settings you need to enable to create a single file exe application.

For more information see:

* [Single file deployment and executable](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file)
* [Single file deployment and executable - API incompatibility](https://docs.microsoft.com/en-us/dotnet/core/deploying/single-file#api-incompatibility)
* [Trim self-contained deployments and executables](https://docs.microsoft.com/en-us/dotnet/core/deploying/trim-self-contained)
* [Trimming options](https://docs.microsoft.com/en-us/dotnet/core/deploying/trimming-options)

The following example outputs were done with the [dotnet-core 3.1 sdk](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Windows 2019 host

Build and publish the single file application:

```powershell
dotnet publish -r win-x64 -c Release
```

And execute:

```powershell
./bin/Release/netcoreapp3.1/win-x64/publish/SingleFileConsoleApp.exe arg1 arg2
```

You should see something like:

```plain
OS Version:
    Microsoft Windows NT 6.2.9200.0
Environment Version:
    3.1.9
Environment Framework:
    .NET Core 3.1.9
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v3.1
AppContext BaseDirectory:
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\
Command Line Arguments:
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\SingleFileConsoleApp.dll
    arg1
    arg2
Process Id:
    1464
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             C:\vagrant\dotnet-core-single-file-console-app\bin\Release\netcoreapp3.1\win-x64\publish\SingleFileConsoleApp.exe
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
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\netcoreapp3.1\win-x64\publish\SingleFileConsoleApp.exe
Process MainModule Length:
    27346344 (26.079505920410156 MB)
Executing Assembly Location:
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\SingleFileConsoleApp.dll
Executing Assembly CodeBase:
    file:///C:/Users/vagrant/AppData/Local/Temp/1/.net/SingleFileConsoleApp/oyi0y2oh.aao/SingleFileConsoleApp.dll
Loaded Assemblies:
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\Microsoft.Win32.Primitives.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\SingleFileConsoleApp.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Collections.NonGeneric.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.ComponentModel.Primitives.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Console.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Diagnostics.FileVersionInfo.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Diagnostics.Process.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.IO.FileSystem.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Linq.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Private.CoreLib.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Runtime.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Runtime.InteropServices.RuntimeInformation.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Text.RegularExpressions.dll
Loaded Modules:
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\clrjit.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\coreclr.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\hostfxr.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\hostpolicy.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\Microsoft.Win32.Primitives.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\SingleFileConsoleApp.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Collections.NonGeneric.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.ComponentModel.Primitives.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Console.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Diagnostics.FileVersionInfo.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Diagnostics.Process.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.IO.FileSystem.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Linq.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Private.CoreLib.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Runtime.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Runtime.InteropServices.RuntimeInformation.dll
    C:\Users\vagrant\AppData\Local\Temp\1\.net\SingleFileConsoleApp\oyi0y2oh.aao\System.Text.RegularExpressions.dll
    C:\vagrant\dotnet-core-single-file-console-app\bin\Release\netcoreapp3.1\win-x64\publish\SingleFileConsoleApp.exe
    C:\Windows\System32\advapi32.dll
    C:\Windows\System32\bcrypt.dll
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
./bin/Release/netcoreapp3.1/ubuntu.20.04-x64/publish/SingleFileConsoleApp arg1 arg2
```

You should see something like:

```plain
OS Version:
    Unix 5.4.0.51
Environment Version:
    3.1.9
Environment Framework:
    .NET Core 3.1.9
AppContext TargetFrameworkName:
    .NETCoreApp,Version=v3.1
AppContext BaseDirectory:
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/
Command Line Arguments:
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/SingleFileConsoleApp.dll
    arg1
    arg2
Process Id:
    9257
Process Name:
    SingleFileConsoleApp
Process MainModule FileVersionInfo:
    File:             /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/netcoreapp3.1/ubuntu.20.04-x64/publish/SingleFileConsoleApp
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
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/netcoreapp3.1/ubuntu.20.04-x64/publish/SingleFileConsoleApp
Process MainModule Length:
    37526417 (35.78798007965088 MB)
Executing Assembly Location:
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/SingleFileConsoleApp.dll
Executing Assembly CodeBase:
    file:///var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/SingleFileConsoleApp.dll
Loaded Assemblies:
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/SingleFileConsoleApp.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Collections.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Collections.Immutable.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Collections.NonGeneric.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.ComponentModel.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.ComponentModel.Primitives.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Console.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Diagnostics.FileVersionInfo.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Diagnostics.Process.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.IO.FileSystem.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Linq.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Private.CoreLib.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Reflection.Metadata.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Runtime.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Runtime.InteropServices.RuntimeInformation.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Text.RegularExpressions.dll
Loaded Modules:
    [vdso]
    /home/rgl/Projects/dotnet-core-single-file-console-app/bin/Release/netcoreapp3.1/ubuntu.20.04-x64/publish/SingleFileConsoleApp
    /lib/x86_64-linux-gnu/ld-2.31.so
    /lib/x86_64-linux-gnu/libc-2.31.so
    /lib/x86_64-linux-gnu/libdl-2.31.so
    /lib/x86_64-linux-gnu/libgcc_s.so.1
    /lib/x86_64-linux-gnu/libm-2.31.so
    /lib/x86_64-linux-gnu/libnsl-2.31.so
    /lib/x86_64-linux-gnu/libnss_compat-2.31.so
    /lib/x86_64-linux-gnu/libnss_files-2.31.so
    /lib/x86_64-linux-gnu/libnss_nis-2.31.so
    /lib/x86_64-linux-gnu/libpthread-2.31.so
    /lib/x86_64-linux-gnu/librt-2.31.so
    /usr/lib/x86_64-linux-gnu/libicudata.so.66.1
    /usr/lib/x86_64-linux-gnu/libicui18n.so.66.1
    /usr/lib/x86_64-linux-gnu/libicuuc.so.66.1
    /usr/lib/x86_64-linux-gnu/liblttng-ust-tracepoint.so.0.0.0
    /usr/lib/x86_64-linux-gnu/liblttng-ust.so.0.0.0
    /usr/lib/x86_64-linux-gnu/libnuma.so.1.0.0
    /usr/lib/x86_64-linux-gnu/libstdc++.so.6.0.28
    /usr/lib/x86_64-linux-gnu/liburcu-bp.so.6.1.0
    /usr/lib/x86_64-linux-gnu/liburcu-cds.so.6.1.0
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libclrjit.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libcoreclr.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libcoreclr.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libcoreclrtraceptprovider.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libhostfxr.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/libhostpolicy.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Collections.dll
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Globalization.Native.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Native.so
    /var/tmp/.net/rgl/SingleFileConsoleApp/mudu220c.bv5/System.Private.CoreLib.dll
Press ENTER to exit.
```

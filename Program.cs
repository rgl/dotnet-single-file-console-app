using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SingleFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainModulePath = Process.GetCurrentProcess().MainModule.FileName;
            var mainModuleFileInfo = new FileInfo(mainModulePath);

            Console.WriteLine($"OS Version:\n    {Environment.OSVersion}");
            Console.WriteLine($"Environment Version:\n    {Environment.Version}");
            Console.WriteLine($"Environment Framework:\n    {RuntimeInformation.FrameworkDescription}");
            Console.WriteLine($"AppContext TargetFrameworkName:\n    {AppContext.TargetFrameworkName}");
            Console.WriteLine($"AppContext BaseDirectory:\n    {AppContext.BaseDirectory}");
            Console.WriteLine($"Command Line Arguments:");
            foreach (var v in Environment.GetCommandLineArgs())
            {
                Console.WriteLine($"    {v}");
            }
            Console.WriteLine($"Process Id:\n    {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Process Name:\n    {Process.GetCurrentProcess().ProcessName}");
            Console.WriteLine($"Process MainModule FileVersionInfo:\n{Regex.Replace(Process.GetCurrentProcess().MainModule.FileVersionInfo.ToString().Trim(), "^", "    ", RegexOptions.Multiline)}");
            Console.WriteLine($"Process Current Directory:\n    {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Process MainModule FileName:\n    {mainModulePath}");
            Console.WriteLine($"Process MainModule Length:\n    {mainModuleFileInfo.Length} ({mainModuleFileInfo.Length / 1024.0 / 1024.0} MB)");
            Console.WriteLine($"Loaded Assemblies:");
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies().Select(a => $"{a.GetName().Name}").OrderBy(a => a))
            {
                Console.WriteLine($"    {a}");
            }
            Console.WriteLine($"Loaded Modules:");
            foreach (var a in Process.GetCurrentProcess().Modules.Cast<ProcessModule>().Select(m => m.FileName).OrderBy(a => a))
            {
                Console.WriteLine($"    {a}");
            }
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}

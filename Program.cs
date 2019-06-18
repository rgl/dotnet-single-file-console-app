using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SingleFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainModulePath = Process.GetCurrentProcess().MainModule.FileName;
            var mainModuleFileInfo = new FileInfo(mainModulePath);

            Console.WriteLine($"Process Id:\n    {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Process Name:\n    {Process.GetCurrentProcess().ProcessName}");
            Console.WriteLine($"Process MainModule FileVersionInfo:\n{Regex.Replace(Process.GetCurrentProcess().MainModule.FileVersionInfo.ToString().Trim(), "^", "    ", RegexOptions.Multiline)}");
            Console.WriteLine($"Process Current Directory:\n    {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Process MainModule FileName:\n    {mainModulePath}");
            Console.WriteLine($"Process MainModule Length:\n    {mainModuleFileInfo.Length} ({mainModuleFileInfo.Length / 1024.0 / 1024.0} MB)");
            Console.WriteLine($"Executing Assembly Location:\n    {Assembly.GetExecutingAssembly().Location}");
            Console.WriteLine($"Executing Assembly CodeBase:\n    {Assembly.GetExecutingAssembly().CodeBase}");
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}

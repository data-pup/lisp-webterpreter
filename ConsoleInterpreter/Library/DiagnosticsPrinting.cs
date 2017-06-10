using System;
using System.Reflection;

namespace ConsoleInterpreter.Diagnostics
{
    public class DiagnosticsPrinting
    {
        public static void PrintAssemblyInformation(Assembly assembly)
        {
            AssemblyName assemblyName = assembly.GetName();
            Console.WriteLine("Name: {0}", assemblyName.ToString());
            int assemblyHash = assembly.GetHashCode();
            Console.WriteLine("Hash: {0}", assemblyHash.ToString());
        }

        public static void PrintLoadedModules(Assembly assembly)
        {
            var modules = assembly.GetModules();
            int moduleLoopCounter = 1;
            Console.WriteLine("Assembly Modules:");
            foreach(var currentModule in modules)
            {
                PrintModuleInformation(currentModule, moduleLoopCounter);
                moduleLoopCounter++;
            }
        }

        private static void PrintModuleInformation(Module module, int itemNumber)
        {
            string currentModuleName = module.Name;
            string currentModuleFullName = module.FullyQualifiedName;
            var currentModuleVersion = module.ModuleVersionId;
            string currentModuleVersionString = currentModuleVersion.ToString();
            string currentModuleIsResource = module.IsResource() ?
                "Module is a resource." : "Module is not a resource.";
            Console.WriteLine("\t{0}. {1}", itemNumber, currentModuleName);
            Console.WriteLine("\t\tFully Qualified Module Name: {0}", currentModuleFullName);
            Console.WriteLine("\t\tModule Version ID: {0}", currentModuleVersionString);
            Console.WriteLine("\t\t{0}", currentModuleIsResource);
        }
    }
}
using System;
using System.Reflection;

namespace ConsoleInterpreter.Diagnostics
{
    public class DiagnosticsPrinting
    {
        public static void PrintAssemblyInformation(Assembly _assembly)
        {
            AssemblyName assemblyName = _assembly.GetName();
            Console.WriteLine("Name: {0}", assemblyName.ToString());
            int assemblyHash = _assembly.GetHashCode();
            Console.WriteLine("Hash: {0}", assemblyHash.ToString());
        }

        public static void PrintLoadedModules(Assembly _assembly)
        {
            var modules = _assembly.GetModules();
            Console.WriteLine("Assembly Modules:");
            foreach(var currentModule in modules)
            {
                string currentModuleName = currentModule.Name;
                string currentModuleFullName = currentModule.FullyQualifiedName;
                var currentModuleVersion = currentModule.ModuleVersionId;
                var currentModuleVersionString = currentModuleVersion.ToString();
                Console.WriteLine("\t{0}", currentModuleName);
                Console.WriteLine("\t{0}", currentModuleFullName);
                Console.WriteLine("\t{0}", currentModule.ModuleVersionId);
            }
        }
    }
}
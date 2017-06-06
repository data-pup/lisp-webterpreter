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
            foreach(var currModule in modules)
            {
                Console.WriteLine("\t{0}", currModule.Name);
                Console.WriteLine("\t{0}", currModule.FullyQualifiedName);
                Console.WriteLine("\t{0}", currModule.ModuleVersionId);
                // Console.WriteLine("\t{0}", );
            }
        }
    }
}
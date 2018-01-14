using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoadAssemnlyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load assemnly
            Assembly assembly = Assembly.LoadFrom("ProjectManager.Core.dll");
            var ReferencedAssemblies = assembly.GetReferencedAssemblies();

            // we can  Chek existance of all referenced assemblie
            foreach (var item in ReferencedAssemblies)
            {
                // Assembly assembly = Assembly.LoadFrom(item.Name);
            }

            // Show All Types 
            var teypes = assembly.GetTypes();
            foreach (var type in teypes)
            {
                Console.WriteLine(type.Name);

                // Show Properties
                foreach (var item in type.GetProperties())
                {
                    Console.WriteLine("\t" + item.Name);
                }

            }
            Console.Read();

        }
    }
}

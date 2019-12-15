using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace ShapeParser
{
    public class Bootstraper
    {
        public CompositionContainer Container { get; }
        public  Bootstraper()
        {
            var catalog = new AggregateCatalog();


            var pluginFolderPath = Path.Combine(Directory.GetParent(Assembly
                                  .GetExecutingAssembly().Location)
                                  .Parent.Parent.Parent.FullName,
                                  System.Configuration.ConfigurationManager.AppSettings["DllLocation"]);
            catalog.Catalogs.Add(new DirectoryCatalog(pluginFolderPath, "*.*"));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly().Location));
            Container = new CompositionContainer(catalog);
            Container.ComposeParts(this);
        }
    }
}

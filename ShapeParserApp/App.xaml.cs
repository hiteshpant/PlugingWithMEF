using System.Windows;

namespace ShapeParser
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {        
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstraper bootstraper = new Bootstraper();           
            MainWindow = bootstraper.Container.GetExportedValue<MainWindow>();
            MainWindow.DataContext = bootstraper.Container.GetExportedValue<ShapeParserViewModel>();
            MainWindow.Show();
        }       
    }
}

using KSharpGui.Control;
using KSharpGui.Model;
using KSharpGui.View;
using System.Windows;

namespace KSharpGui
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            BootsTrap();
        }
        
        private void BootsTrap()
        {
            MainControl control = new MainControl();
            var mainview = new MainView();

            mainview.DataContext = control;
            mainview.Show();
        }
    }


}

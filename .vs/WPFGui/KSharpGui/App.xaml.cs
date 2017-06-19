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
            MainModel model = new MainModel();
            PasswordRegistModel passmodel = new PasswordRegistModel();

            var mainview = new MainView();
            var passwordgeneratorView = new PasswordView();

            mainview.DataContext = model;
            passwordgeneratorView.DataContext = passmodel;
            mainview.Show();
            passwordgeneratorView.Show();
        }
    }


}

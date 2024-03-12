using ConversationEditor.MVVM.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ConversationEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            UserViewModel VM = new UserViewModel();

            window.DataContext = VM;
            window.Show();

            window.WindowState = WindowState.Maximized;
        }

    }

}

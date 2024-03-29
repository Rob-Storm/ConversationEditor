﻿using ConversationEditor.MVVM.ViewModel;
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
            DialogueViewModel VM = new DialogueViewModel();

            window.DataContext = VM;
            window.Show();

            window.WindowState = WindowState.Maximized;
        }

    }

}
